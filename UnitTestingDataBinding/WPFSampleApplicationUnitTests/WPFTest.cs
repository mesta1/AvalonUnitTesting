using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using WPFSampleApplication;
using AvalonUnitTesting;

namespace WPFSampleApplicationUnitTests
{
    /// <summary>
    /// This class test some method on  STA thread and some on non STA
    /// </summary>
    [TestFixture]
    public class WPFTest
    {
        /// <summary>
        /// Test running in a non STA thread
        /// </summary>
        [Test]
        public void TestSum()
        {
            Assert.AreEqual(10, new Calculations().Sum(5, 5));
        }

        /// <summary>
        /// Test running on an STA Thread
        /// </summary>
        [Test]
        public void TestMainWindow()
        {
            AvalonTestRunner.RunInSTA(
                delegate
                {
                    MainWindow window = new MainWindow();
                    Assert.AreEqual(300, window.Height);
                });
        }
    }
}
