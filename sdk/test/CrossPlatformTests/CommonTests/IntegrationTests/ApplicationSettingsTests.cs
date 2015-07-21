using Amazon.Util.Internal.PlatformServices;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class ApplicationSettingsTests
    {
        [Test]
        public void TestApplicationSettings()
        {
            var applicationsettings = ServiceFactory.Instance.GetService<IApplicationSettings>();

            string testKey = "testkey";
            string testValue = "testValue";

            //insert scenario
            applicationsettings.SetValue(testKey, testValue, ApplicationSettingsMode.Local);
            Assert.AreEqual(testValue, applicationsettings.GetValue(testKey, ApplicationSettingsMode.Local));

            testValue = "newValue";

            //update scenario
            applicationsettings.SetValue(testKey, testValue, ApplicationSettingsMode.Local);
            Assert.AreEqual(testValue, applicationsettings.GetValue(testKey, ApplicationSettingsMode.Local));


            //delete scenario
            applicationsettings.RemoveValue(testKey, ApplicationSettingsMode.Local);
            Assert.IsTrue(string.IsNullOrEmpty(applicationsettings.GetValue(testKey, ApplicationSettingsMode.Local)));

        }
    }
}
