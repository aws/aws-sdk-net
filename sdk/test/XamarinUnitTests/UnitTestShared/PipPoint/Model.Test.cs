using Amazon;
using Amazon.MobileAnalytics.MobileAnalyticsManager;
using Amazon.MobileAnalytics.MobileAnalyticsManager.Internal;
using Amazon.MobileAnalytics.Model;
using Amazon.Runtime;
using Moq;
using NUnit.Framework;
using NUnit.Tests.DLL.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ThirdParty.Json.LitJson;
using Session = Amazon.MobileAnalytics.Model.Session;

namespace NUnit.Tests.DLL
{
    [TestFixture]
    public class ModelTest
    {
        [Test]
        public void TestEvent()
        {
            Event e = new Event();
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            attributes["name"] = "value";
            e.Attributes = attributes;
            Assert.AreSame(e.Attributes, attributes);
            Assert.IsTrue(e.IsSetAttributes());
            e.EventType = "eventtype";
            Assert.AreEqual(e.EventType, "eventtype");
            Assert.IsTrue(e.IsSetEventType());
            Dictionary<string, double> metrics = new Dictionary<string, double>();
            metrics["name"] = 0;
            e.Metrics = metrics;
            Assert.AreEqual(e.Metrics,metrics);
            Assert.IsTrue(e.IsSetMetrics());
            Session session = new Session();
            e.Session = session;
            Assert.AreEqual(e.Session,session);
            Assert.IsTrue(e.IsSetSession());
            DateTime timestamp =  new DateTime(2000,1,1);
  
            e.Timestamp = timestamp;
            Assert.AreEqual(e.Timestamp,timestamp);
            Assert.IsTrue(e.IsSetTimestamp());
 
            e.Version = "1.0.0.0";
            Assert.AreEqual(e.Version, "1.0.0.0");
            Assert.IsTrue((e.IsSetVersion()));
            string strEvent = e.MarshallToJson();
            const string eventstring ="{\"attributes\":{\"name\":\"value\"},\"eventType\":\"eventtype\",\"metrics\":{\"name\":0.0},\"session\":{},\"timestamp\":\"2000-01-01T00:00:00.000Z\",\"version\":\"1.0.0.0\"}";

            Assert.AreEqual(eventstring, strEvent);
            Event newEvent = Event.UnmarshallFromJson(strEvent);
            newEvent.Timestamp = newEvent.Timestamp.ToUniversalTime();
            Assert.AreEqual(e.Timestamp,newEvent.Timestamp);
            Assert.AreEqual(e.Attributes, newEvent.Attributes);
            Assert.AreEqual(e.EventType, newEvent.EventType);
            Assert.AreEqual(e.Metrics, newEvent.Metrics);
            //var ee = e.Session.Equals(newEvent.Session);
            //Assert.AreEqual(e.Version, newEvent.Version);
            //Assert.AreEqual(e,newEvent);

        }

        [Test]
        public void TestTime()
        {
            string  strtime = "2000-01-01T01:00:00"; //.000Z
            DateTime dt = new DateTime(2000,1,1);
            string st= dt.ToString(Amazon.Util.AWSSDKUtils.ISO8601DateFormat, System.Globalization.CultureInfo.InvariantCulture);
            DateTime dtst = DateTime.Parse(st, System.Globalization.CultureInfo.InvariantCulture);
            
                     

            DateTime dateTime = DateTime.Parse(strtime);
            DateTime nowTime = System.DateTime.Now;
            string now = nowTime.ToString(Amazon.Util.AWSSDKUtils.ISO8601DateFormat, System.Globalization.CultureInfo.InvariantCulture);
            DateTime atime = DateTime.Parse(now, System.Globalization.CultureInfo.InvariantCulture);


        }


    }
}
