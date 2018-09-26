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
using System.Security.Cryptography;
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
            //can remove this code after datetime marshall issue is addressed
            newEvent.Timestamp = newEvent.Timestamp.ToUniversalTime();
            ValidateEqualEvent(e, newEvent);

        }

        void ValidateEqualSession(Session s1, Session s2)
        {
            Assert.AreEqual(s1.Duration, s2.Duration);
            Assert.AreEqual(s1.Id, s2.Id);
            Assert.AreEqual(s1.StartTimestamp, s2.StartTimestamp);
            Assert.AreEqual(s1.StopTimestamp, s2.StopTimestamp);
        }
        void ValidateEqualEvent(Event e1, Event e2)
        {
            Assert.AreEqual(e1.Timestamp, e2.Timestamp);
            Assert.AreEqual(e1.Attributes, e2.Attributes);
            Assert.AreEqual(e1.EventType, e2.EventType);
            ValidateEqualSession(e1.Session, e2.Session);

        }
    }
}
