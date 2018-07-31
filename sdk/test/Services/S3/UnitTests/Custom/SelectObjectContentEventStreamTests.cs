using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Ploeh.AutoFixture.Kernel;
using UnknownEventStreamEvent = Amazon.S3.Model.UnknownEventStreamEvent;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SelectObjectContentEventStreamTests
    {
        // We don't want to lock on unit tests.
        private static readonly TimeSpan SpinTimeout = TimeSpan.FromSeconds(5);

        private readonly IFixture _fixture;
        private readonly Mock<IEventStreamDecoder> _eventStreamDecoderMock;
        private readonly Mock<Stream> _streamMock;
        private readonly ISelectObjectContentEventStream _sut;

        public SelectObjectContentEventStreamTests()
        {
            _fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            _eventStreamDecoderMock = _fixture.Freeze<Mock<IEventStreamDecoder>>();
            _streamMock = _fixture.Freeze<Mock<Stream>>();

            _fixture.Customize<SelectObjectContentEventStream>(c => c.FromFactory(
                new MethodInvoker(
                    new GreedyConstructorQuery())));

            _sut = _fixture.Create<SelectObjectContentEventStream>();
        }

        #region Enumeration Tests

        [TestMethod]
        public void TestEnumeration()
        {
            CommonStreamMockSetup(3);

            var ev1 = CreateEventStreamMessageEvent(EventType.Cont);
            var ev2 = CreateEventStreamMessageEvent(EventType.Cont);
            var ev3 = CreateEventStreamMessageEvent(EventType.End);

            var testList = new List<Type>()
            {
                typeof(ContinuationEvent),
                typeof(ContinuationEvent),
                typeof(EndEvent)
            };

            CommonDecoderMockSetup(ev1, ev2, ev3);

            var verifyEventTypes = new List<Type>();
            foreach (var ev in _sut)
            {
                verifyEventTypes.Add(ev.GetType());
            }

            Assert.IsTrue(testList.SequenceEqual(verifyEventTypes));
        }


        [TestMethod]
        [ExpectedException(typeof(S3EventStreamException))]
        public void TestEnumerationException()
        {
            CommonStreamMockSetup(1);

            _eventStreamDecoderMock.Setup(esd => esd.ProcessData(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>()))
                .Throws(new Exception("What?"));

            foreach (var ev in _sut)
            {
                //Exception!
            }
        }

        #endregion

        #region Event Handler Tests

        [TestMethod]
        public void TestRecordsEvent()
        {
            CommonStreamMockSetup(1);

            var data = _fixture.Create<string>();
            var recordsEvent = CreateEventStreamMessageEvent(EventType.Records, data);

            CommonDecoderMockSetup(recordsEvent);

            Type verifyEventType = null;
            Stream verifyData = null;
            using (_sut)
            {
                _sut.RecordsEventReceived += (sender, args) =>
                {
                    var ev = args.EventStreamEvent;
                    verifyEventType = ev.GetType();
                    verifyData = ev.Payload;
                };
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyEventType != null, SpinTimeout);
            }

            Assert.AreEqual(typeof(RecordsEvent), verifyEventType);
            using (var streamReader = new StreamReader(verifyData))
            {
                var streamData = streamReader.ReadToEnd();
                Assert.AreEqual(data, streamData);
            }
        }

        [TestMethod]
        public void TestStatsEvent()
        {
            CommonStreamMockSetup(1);

            var stats = _fixture.Create<Stats>();
            var statsXml = ConvertToStatsXml(stats);

            var statsEvent = CreateEventStreamMessageEvent(EventType.Stats, statsXml);

            CommonDecoderMockSetup(statsEvent);

            Type verifyEventType = null;
            Stats verifyStats = null;
            using (_sut)
            {
                _sut.StatsEventReceived += (sender, args) =>
                {
                    var ev = args.EventStreamEvent;
                    verifyEventType = ev.GetType();
                    verifyStats = ev.Details;
                };
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyEventType != null, SpinTimeout);
            }

            Assert.AreEqual(typeof(StatsEvent), verifyEventType);
            Assert.AreEqual(stats.BytesProcessed, verifyStats.BytesProcessed);
            Assert.AreEqual(stats.BytesScanned, verifyStats.BytesScanned);
            Assert.AreEqual(stats.BytesReturned, verifyStats.BytesReturned);
        }

        [TestMethod]
        public void TestProgressEvent()
        {
            CommonStreamMockSetup(1);

            var progress = _fixture.Create<Progress>();
            var progressXml = ConvertToProgressXml(progress);

            var progressEvent = CreateEventStreamMessageEvent(EventType.Progress, progressXml);

            CommonDecoderMockSetup(progressEvent);

            Type verifyEventType = null;
            Progress verifyProgress = null;
            using (_sut)
            {
                _sut.ProgressEventReceived += (sender, args) =>
                {
                    var ev = args.EventStreamEvent;
                    verifyEventType = ev.GetType();
                    verifyProgress = ev.Details;
                };
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyEventType != null, SpinTimeout);
            }

            Assert.AreEqual(typeof(ProgressEvent), verifyEventType);
            Assert.AreEqual(progress.BytesProcessed, verifyProgress.BytesProcessed);
            Assert.AreEqual(progress.BytesScanned, verifyProgress.BytesScanned);
            Assert.AreEqual(progress.BytesReturned, verifyProgress.BytesReturned);
        }

        [TestMethod]
        public void TestContinuationEvent()
        {
            CommonStreamMockSetup(1);

            var continuationEvent = CreateEventStreamMessageEvent(EventType.Cont);

            CommonDecoderMockSetup(continuationEvent);

            Type verifyEventType = null;
            using (_sut)
            {
                _sut.ContinuationEventReceived += (sender, args) => verifyEventType = args.EventStreamEvent.GetType();
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyEventType != null, SpinTimeout);
            }

            Assert.AreEqual(typeof(ContinuationEvent), verifyEventType);
        }

        [TestMethod]
        public void TestEndEvent()
        {
            CommonStreamMockSetup(1);

            var endEvent = CreateEventStreamMessageEvent(EventType.End);

            CommonDecoderMockSetup(endEvent);

            Type verifyEventType = null;
            using (_sut)
            {
                _sut.EndEventReceived += (sender, args) => verifyEventType = args.EventStreamEvent.GetType();
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyEventType != null, SpinTimeout);
            }

            Assert.AreEqual(typeof(EndEvent), verifyEventType);
        }

        [TestMethod]
        public void TestEvent()
        {
            CommonStreamMockSetup(3);

            var ev1 = CreateEventStreamMessageEvent(EventType.Cont);
            var ev2 = CreateEventStreamMessageEvent(EventType.Cont);
            var ev3 = CreateEventStreamMessageEvent(EventType.End);

            var testList = new List<Type>()
            {
                typeof(ContinuationEvent),
                typeof(ContinuationEvent),
                typeof(EndEvent)
            };

            CommonDecoderMockSetup(ev1, ev2, ev3);

            var verifyEventTypes = new List<Type>();
            using (_sut)
            {
                _sut.EventReceived += (sender, args) => verifyEventTypes.Add(args.EventStreamEvent.GetType());
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyEventTypes.Count >= 3, SpinTimeout);
            }


            Assert.IsTrue(testList.SequenceEqual(verifyEventTypes));
        }

        #endregion

        #region Exception And Error Messages

        [TestMethod]
        public void ExceptionRecieved()
        {
            // There are no exceptions defined at this time. Leaving this test method stub as a placeholder.
        }

        [TestMethod]
        public void ErrorRecieved()
        {
            var testMessage = "Test";

            CommonStreamMockSetup(1);

            var missingErrorCode = CreateEventStreamMessageEvent(EventType.Unknown, messageType: MessageType.Error, data: testMessage);

            CommonDecoderMockSetup(missingErrorCode);

            Exception verifyException = null;
            using (_sut)
            {
                _sut.ExceptionReceived += (sender, args) => verifyException = args.EventStreamException;
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyException != null, SpinTimeout);
            }

            Assert.IsInstanceOfType(verifyException, typeof(S3EventStreamException));

            var innerException = verifyException.InnerException;

            Assert.IsInstanceOfType(innerException, typeof(EventStreamErrorCodeException));

            var castInnerException = (EventStreamErrorCodeException) innerException;

            Assert.AreEqual(testMessage, castInnerException?.Message);
            Assert.AreEqual(ErrorCode, castInnerException?.ErrorCode);
        }

        [TestMethod]
        public void ErrorRecievedErrorMessageMissing()
        {
            CommonStreamMockSetup(1);

            var missingErrorCode = CreateEventStreamMessageEvent(EventType.Unknown, messageType: MessageType.Error);

            CommonDecoderMockSetup(missingErrorCode);

            Exception verifyException = null;
            using (_sut)
            {
                _sut.ExceptionReceived += (sender, args) => verifyException = args.EventStreamException;
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyException != null, SpinTimeout);
            }

            Assert.IsInstanceOfType(verifyException, typeof(S3EventStreamException));

            var innerException = verifyException.InnerException;

            Assert.IsInstanceOfType(innerException, typeof(EventStreamErrorCodeException));

            var castInnerException = (EventStreamErrorCodeException)innerException;

            Assert.AreEqual(string.Empty, castInnerException?.Message);
            Assert.AreEqual(ErrorCode, castInnerException?.ErrorCode);
        }

        #endregion

        #region Edge Cases

        [TestMethod]
        [ExpectedException(typeof(XmlException))]
        public void StatsInvalidXml()
        {
            var notXml = _fixture.Create<string>();
            var statsMessage = CreateEventStreamMessage(EventType.Stats, notXml);
            new StatsEvent(statsMessage);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void StatsNull()
        {
            var statsMessage = CreateEventStreamMessage(EventType.Stats);
            new StatsEvent(statsMessage);
        }

        [TestMethod]
        [ExpectedException(typeof(XmlException))]
        public void ProgressInvalidXml()
        {
            var notXml = _fixture.Create<string>();
            var progressMessage = CreateEventStreamMessage(EventType.Progress, notXml);
            new ProgressEvent(progressMessage);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ProgressNull()
        {
            var progressMessage = CreateEventStreamMessage(EventType.Progress);
            new ProgressEvent(progressMessage);
        }

        [TestMethod]
        public void DecoderExceptionThrown()
        {
            var exceptionMessage = "Expected";
            CommonStreamMockSetup(1);

            _eventStreamDecoderMock.Setup(esd => esd.ProcessData(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>()))
                .Throws(new Exception(exceptionMessage));

            TestExceptionCommon(exceptionMessage, false);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AlreadyProcessingThroughEventsExceptionThrown()
        {
            _sut.StartProcessing();
            foreach (var ev in _sut)
            {
                // Exception
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AlreadyProcessingThroughEnumerationExceptionThrown()
        {
            CommonStreamMockSetup(1);

            var endEvent = CreateEventStreamMessageEvent(EventType.End);

            CommonDecoderMockSetup(endEvent);

            foreach (var ev in _sut)
            {
                _sut.StartProcessing();
                // Exception
            }
        }

        [TestMethod]
        public void UnknownEvent()
        {
            CommonStreamMockSetup(1);

            var unknownEvent = CreateEventStreamMessageEvent(EventType.Unknown);

            CommonDecoderMockSetup(unknownEvent);

            Type verifyEventType = null;
            using (_sut)
            {
                _sut.EventReceived += (sender, args) =>
                {
                    var ev = args.EventStreamEvent;
                    verifyEventType = ev.GetType();
                };
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyEventType != null, SpinTimeout);
            }

            Assert.AreEqual(typeof(UnknownEventStreamEvent), verifyEventType);
        }

        [TestMethod]
        public void EventTypeMissing()
        {
            CommonStreamMockSetup(1);

            var unknownEvent = CreateEventStreamMessageEvent(EventType.Unknown, hasType: false);

            CommonDecoderMockSetup(unknownEvent);

            TestExceptionCommon("Event Type not defined for event.");
        }

        [TestMethod]
        public void UnknownMessageType()
        {
            CommonStreamMockSetup(2);

            var unknownMessage = CreateEventStreamMessageEvent(EventType.Unknown, messageType: MessageType.Unknown, hasType: false);
            var endEvent = CreateEventStreamMessageEvent(EventType.End);

            CommonDecoderMockSetup(unknownMessage, endEvent);

            var checkList = new List<IS3Event>();

            using (_sut)
            {
                checkList.AddRange(_sut);
            }

            Assert.IsTrue(checkList.Count == 1);
            Assert.AreEqual(checkList[0].GetType(), typeof(EndEvent));
        }

        [TestMethod]
        public void MessageTypeMissing()
        {
            CommonStreamMockSetup(1);

            var missingMessage = CreateEventStreamMessageEvent(EventType.Unknown, messageType: MessageType.None, hasType: false);

            CommonDecoderMockSetup(missingMessage);

            TestExceptionCommon("Message type missing from event stream message.");
        }

        [TestMethod]
        public void UnknownExceptionType()
        {
            CommonStreamMockSetup(1);

            var unknownException = CreateEventStreamMessageEvent(EventType.Unknown, messageType: MessageType.Exception);

            CommonDecoderMockSetup(unknownException);

            Exception verifyException = null;
            using (_sut)
            {
                _sut.ExceptionReceived += (sender, args) =>
                {
                    verifyException = args.EventStreamException;
                };
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyException != null, SpinTimeout);
            }

            Assert.IsInstanceOfType(verifyException, typeof(S3EventStreamException));

            var innerException = verifyException.InnerException;

            Assert.IsInstanceOfType(innerException, typeof(UnknownEventStreamException));

            var castInnerException = (UnknownEventStreamException)innerException;

            Assert.AreEqual(_exceptionTypeMapping[ExceptionType.Test], castInnerException?.ExceptionType);
        }

        [TestMethod]
        public void ExceptionRecievedExceptionTypeMissing()
        {
            CommonStreamMockSetup(1);

            var missingErrorCode = CreateEventStreamMessageEvent(EventType.Unknown, messageType: MessageType.Exception, hasType: false);

            CommonDecoderMockSetup(missingErrorCode);

            TestExceptionCommon("Exception Type not defined for exception.");
        }

        [TestMethod]
        public void ErrorRecievedErrorCodeMissing()
        {
            CommonStreamMockSetup(1);

            var missingErrorCode = CreateEventStreamMessageEvent(EventType.Unknown, messageType: MessageType.Error, hasType: false);

            CommonDecoderMockSetup(missingErrorCode);

            TestExceptionCommon("Error Code not defined for error.");
        }

        #endregion

        #region Test Utilities

        public class TestS3EventStreamException : S3EventStreamException
        {
            public TestS3EventStreamException()
            {

            }
        }
        private enum MessageType
        {
            None,
            Event,
            Exception,
            Error,
            Unknown
        }

        private enum EventType
        {
            Records,
            Stats,
            Progress,
            Cont,
            End,
            Unknown
        }

        private readonly IDictionary<EventType, string> _eventTypeMapping = new Dictionary<EventType, string>()
        {
            {EventType.Records, "Records"},
            {EventType.Stats, "Stats"},
            {EventType.Progress, "Progress"},
            {EventType.Cont, "Cont"},
            {EventType.End, "End"},
            {EventType.Unknown, "Unknown" }
        };

        private enum ExceptionType
        {
            Test
        }

        private readonly IDictionary<ExceptionType, string> _exceptionTypeMapping = new Dictionary<ExceptionType, string>()
        {
            {ExceptionType.Test, "Test"}
        };

        private const int ErrorCode = 500;

        private EventStreamMessageReceivedEventArgs CreateEventStreamMessageEvent(EventType eventType, string data = null, MessageType messageType = MessageType.Event, bool hasType = true, ExceptionType exceptionType = ExceptionType.Test)
        {
            return new EventStreamMessageReceivedEventArgs(CreateEventStreamMessage(eventType, data, messageType, hasType, exceptionType));
        }

        private EventStreamMessage CreateEventStreamMessage(EventType eventType, string data = null, MessageType messageType = MessageType.Event, bool hasType = true, ExceptionType exceptionType = ExceptionType.Test)
        {
            var payload = data != null ? Encoding.UTF8.GetBytes(data) : null;

            var headers = new List<IEventStreamHeader>();

            if (messageType != MessageType.None)
            {
                var eventStreamMessageTypeHeaderMock = _fixture.Create<Mock<IEventStreamHeader>>();
                eventStreamMessageTypeHeaderMock.Setup(esh => esh.Name).Returns(":message-type");
                eventStreamMessageTypeHeaderMock.Setup(esh => esh.AsString()).Returns(() =>
                {
                    switch (messageType)
                    {
                        case MessageType.Event:
                            return "event";
                        case MessageType.Exception:
                            return "exception";
                        case MessageType.Error:
                            return "error";
                        case MessageType.Unknown:
                            return "unknown";
                        default:
                            throw new InvalidOperationException($"Message Type is of a value not defined by the {nameof(MessageType)} enum.");
                    }
                });
                headers.Add(eventStreamMessageTypeHeaderMock.Object);

                if (hasType)
                {
                    var eventStreamEventTypeHeaderMock = _fixture.Create<Mock<IEventStreamHeader>>();
                    (string, object) typeAndValue;
                    switch (messageType)
                    {
                        case MessageType.Event:
                            typeAndValue = (":event-type", _eventTypeMapping[eventType]);
                            break;
                        case MessageType.Exception:
                            typeAndValue = (":exception-type", _exceptionTypeMapping[exceptionType]);

                            break;
                        case MessageType.Error:
                            typeAndValue = (":error-code", ErrorCode);
                            eventStreamEventTypeHeaderMock.Setup(esh => esh.AsInt32()).Returns(ErrorCode);
                            break;
                        default:
                            throw new InvalidOperationException(
                                $"Message Type is of a value not defined by the {nameof(MessageType)} enum.");
                    }
                    eventStreamEventTypeHeaderMock.Setup(esh => esh.Name).Returns(typeAndValue.Item1);
                    eventStreamEventTypeHeaderMock.Setup(esh => esh.AsString()).Returns(typeAndValue.Item2.ToString());

                    headers.Add(eventStreamEventTypeHeaderMock.Object);
                }
            }

            if (messageType == MessageType.Error && data != null)
            {
                var eventStreamMessageErrorMessageHeaderMock = _fixture.Create<Mock<IEventStreamHeader>>();
                eventStreamMessageErrorMessageHeaderMock.Setup(esh => esh.Name).Returns(":error-message");
                eventStreamMessageErrorMessageHeaderMock.Setup(esh => esh.AsString()).Returns(data);
                headers.Add(eventStreamMessageErrorMessageHeaderMock.Object);
            }

            return new EventStreamMessage(headers, payload);
        }

        private void CommonStreamMockSetup(int timesReturn)
        {
            var times = 0;
            _streamMock.Setup(st => st.CanRead).Returns(() => times++ < timesReturn);
            _streamMock.Setup(st => st.Read(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>())).Returns(1);
        }

        private void CommonDecoderMockSetup(params EventStreamMessageReceivedEventArgs[] events)
        {
            var location = 0;
            _eventStreamDecoderMock.Setup(esd => esd.ProcessData(It.IsAny<byte[]>(), It.IsAny<int>(), It.IsAny<int>()))
                .Raises(esd => esd.MessageReceived += null, () => events[location++]);
        }

        private string ConvertToStatsXml(Stats stats)
        {
            return new XElement("Stats",
                    new XElement("BytesScanned", stats.BytesScanned),
                    new XElement("BytesProcessed", stats.BytesProcessed),
                    new XElement("BytesReturned", stats.BytesReturned))
                .ToString();
        }

        private string ConvertToProgressXml(Progress progress)
        {
            return new XElement("Progress",
                    new XElement("BytesScanned", progress.BytesScanned),
                    new XElement("BytesProcessed", progress.BytesProcessed),
                    new XElement("BytesReturned", progress.BytesReturned))
                .ToString();
        }

        public void TestExceptionCommon(string validationMessage, bool isValidationException = true)
        {
            Exception verifyException = null;
            using (_sut)
            {
                _sut.ExceptionReceived += (sender, args) => verifyException = args.EventStreamException;
                _sut.StartProcessing();

                SpinWait.SpinUntil(() => verifyException != null, SpinTimeout);
            }

            Assert.IsInstanceOfType(verifyException, typeof(S3EventStreamException));
            Assert.AreEqual(validationMessage, verifyException.InnerException?.Message);
            if (isValidationException)
            {
                Assert.IsInstanceOfType(verifyException.InnerException, typeof(EventStreamValidationException));
            }
        }

        #endregion
    }
}
