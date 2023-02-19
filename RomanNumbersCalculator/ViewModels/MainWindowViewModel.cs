using ReactiveUI;
using RomanNumbersCalculator.Models;
using System;
using System.Collections.Generic;
using System.Reactive;

namespace RomanNumbersCalculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string currentOperationStringRepresentation = string.Empty;
        private string currentNumberStringRepresentation = string.Empty;
        private Stack<RomanNumberExtend> StackRomanNumbers = new Stack<RomanNumberExtend>();

        public string CurrentNumberStringRepresentation
        {
            get => currentNumberStringRepresentation;
            set
            {
                this.RaiseAndSetIfChanged(ref currentNumberStringRepresentation, value);
            }
        }
        public ReactiveCommand<string, Unit> AddNumber { get; }
        public ReactiveCommand<Unit, Unit> PlusCommand { get; }
        public ReactiveCommand<Unit, Unit> SubCommand { get; }
        public ReactiveCommand<Unit, Unit> MulCommand { get; }
        public ReactiveCommand<Unit, Unit> DivCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateCommand { get; }
        public ReactiveCommand<Unit, Unit> ResetCommand { get; }
        private bool CalculateCheck(string symbol)
        {
            if (currentNumberStringRepresentation == "#ERROR")
            {
                return false;
            }

            if (currentNumberStringRepresentation == string.Empty)
            {
                if (currentOperationStringRepresentation != string.Empty) currentOperationStringRepresentation = symbol;
                return false;
            }

            if (currentOperationStringRepresentation == "=")
            {
                currentOperationStringRepresentation = symbol;
                CurrentNumberStringRepresentation = string.Empty;
                return false;
            }

            return true;
        }
        private void CalculateCommandByType(string symbol)
        {
            if (!CalculateCheck(symbol))
            {
                return;
            }
            try
            {
                switch (currentOperationStringRepresentation)
                {
                    case "":
                        {
                            currentOperationStringRepresentation = symbol;
                            RomanNumberExtend newNumber = new(currentNumberStringRepresentation);
                            StackRomanNumbers.Push(newNumber);
                            CurrentNumberStringRepresentation = string.Empty;
                            break;
                        }
                    default:
                        {
                            RomanNumberExtend newNumber = new(currentNumberStringRepresentation);
                            switch (currentOperationStringRepresentation)
                            {
                                case "+":
                                    StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                                    break;
                                case "-":
                                    StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                                    break;
                                case "*":
                                    StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                                    break;
                                case "/":
                                    StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                                    break;
                                default:
                                    break;
                            }
                            currentOperationStringRepresentation = symbol;
                            CurrentNumberStringRepresentation = string.Empty;
                            break;
                        }
                }
            }
            catch (RomanNumberException exception)
            {
                CurrentNumberStringRepresentation = exception.Message;
            }
        }
        public MainWindowViewModel()
        {
            AddNumber = ReactiveCommand.Create<string>(str =>
            {
                if (currentNumberStringRepresentation == "#ERROR")
                {
                    return;
                }

                if (currentOperationStringRepresentation == "=")
                {
                    CurrentNumberStringRepresentation = str;
                    StackRomanNumbers.Clear();
                    currentOperationStringRepresentation = string.Empty;
                }
                CurrentNumberStringRepresentation += str;
            });
            ResetCommand = ReactiveCommand.Create(() => {
                CurrentNumberStringRepresentation = string.Empty;
                StackRomanNumbers.Clear();
                currentOperationStringRepresentation = string.Empty;
            });
            PlusCommand = ReactiveCommand.Create(() => CalculateCommandByType("+"));
            SubCommand = ReactiveCommand.Create(() => CalculateCommandByType("-"));
            MulCommand = ReactiveCommand.Create(() => CalculateCommandByType("*"));
            DivCommand = ReactiveCommand.Create(() => CalculateCommandByType("/"));

            CalculateCommand = ReactiveCommand.Create(() =>
            {
                if (StackRomanNumbers.Count != 1 || currentNumberStringRepresentation == string.Empty || currentNumberStringRepresentation == "#ERROR")
                {
                    return;
                }

                try
                {
                    RomanNumberExtend newNumber = new(currentNumberStringRepresentation);
                    switch (currentOperationStringRepresentation)
                    {
                        case "+":
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() + newNumber);
                            break;
                        case "-":
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() - newNumber);
                            break;
                        case "*":
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() * newNumber);
                            break;
                        case "/":
                            StackRomanNumbers.Push(StackRomanNumbers.Pop() / newNumber);
                            break;
                        default:
                            break;
                    }
                    currentOperationStringRepresentation = "=";
                    CurrentNumberStringRepresentation = StackRomanNumbers.Peek().ToString();
                }
                catch (RomanNumberException exception)
                {
                    CurrentNumberStringRepresentation = exception.Message;
                }
            });
        }
    }
}