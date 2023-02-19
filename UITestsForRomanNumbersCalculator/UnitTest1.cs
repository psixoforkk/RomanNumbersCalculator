using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTest
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "II";
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonL");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "D";
            buttonL.Command.Execute(buttonL.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test3()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonDiv = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonDiv");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "C";
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonDiv.Command.Execute(buttonDiv.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test4()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonDiv = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonDiv");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "LXXXIX";
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonDiv.Command.Execute(buttonDiv.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test5()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "CMXCVII";
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test6()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "#ERROR";
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test7()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "#ERROR";
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test8()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "#ERROR";
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test9()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "";
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            Assert.True(result.Equals(expected));
        }
        [Fact]
        public async void Test10()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(100);
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonPlus = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonRes = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var textResult = mainWindow.GetVisualDescendants().OfType<TextBlock>().First();
            var expected = "MMIV";
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            buttonPlus.Command.Execute(buttonPlus.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonRes.Command.Execute(buttonRes.CommandParameter);
            await Task.Delay(50);
            var result = textResult.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(result.Equals(expected));
        }
    }
}