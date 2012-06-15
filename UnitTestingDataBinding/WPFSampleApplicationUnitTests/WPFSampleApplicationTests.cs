using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AvalonUnitTesting;
using WPFSampleApplication;

namespace WPFSampleApplicationUnitTests
{
    /// <summary>
    /// Unit Tests wpf data binding
    /// </summary>
    [TestFixture]
    public class WPFSampleApplicationTests
    {
        [Test]
        public void TestDataBindingForControls()
        {
            AvalonTestRunner.RunInSTA(delegate
            {
                //test the main window XAML.
                //This will assert all data binding errors
                AvalonTestRunner.RunDataBindingTests(new MainWindow());

                //runs the test for a specific user control
                AvalonTestRunner.RunDataBindingTests(new UserControlTests());
            });
        }
    }
}
