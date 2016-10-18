using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Runtime.Internal.Settings;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class PersistenceManagerTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestWritingSmallerSettingsFile()
        {
            const string SETTINGS_TYPE = "unit-test";
            var sc = PersistenceManager.Instance.GetSettings(SETTINGS_TYPE);
            var oc = sc["test-values"];
            oc["big-value1"] = "newvalue!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
            oc["big-value2"] = "newvalue!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
            PersistenceManager.Instance.SaveSettings(SETTINGS_TYPE, sc);

            sc = PersistenceManager.Instance.GetSettings(SETTINGS_TYPE);
            sc["test-values"]["big-value1"] = "old";
            PersistenceManager.Instance.SaveSettings(SETTINGS_TYPE, sc);

            sc = PersistenceManager.Instance.GetSettings(SETTINGS_TYPE);
            Assert.AreEqual("old", sc["test-values"]["big-value1"]);
            Assert.AreEqual("newvalue!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", sc["test-values"]["big-value2"]);
        }
    }
}
