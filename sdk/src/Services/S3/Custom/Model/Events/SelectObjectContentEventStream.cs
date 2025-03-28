// /*******************************************************************************
//  *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The contract for the SelectObjectContentEventStream.
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1710", Justification = "ISelectObjectContentEventStreamCollection is not descriptive.")]
    public interface ISelectObjectContentEventStream : IEnumerableEventOutputStream<IS3Event, S3EventStreamException>
    {
        /// <summary>
        /// Event that encompasses all IS3Events.
        /// </summary>
        new event EventHandler<EventStreamEventReceivedArgs<IS3Event>> EventReceived;

        /// <summary>
        /// Event that encompasses S3EventStreamExceptions.
        /// </summary>
        new event EventHandler<EventStreamExceptionReceivedArgs<S3EventStreamException>> ExceptionReceived;

        /// <summary>
        /// Reaised when a Records event is received.
        /// </summary>
        event EventHandler<EventStreamEventReceivedArgs<RecordsEvent>> RecordsEventReceived;

        /// <summary>
        /// Reaised when a Stats event is received.
        /// </summary>
        event EventHandler<EventStreamEventReceivedArgs<StatsEvent>> StatsEventReceived;

        /// <summary>
        /// Reaised when a Progress event is received.
        /// </summary>
        event EventHandler<EventStreamEventReceivedArgs<ProgressEvent>> ProgressEventReceived;

        /// <summary>
        /// Reaised when a Continuation event is received.
        /// </summary>
        event EventHandler<EventStreamEventReceivedArgs<ContinuationEvent>> ContinuationEventReceived;

        /// <summary>
        /// Reaised when an End event is received.
        /// </summary>
        event EventHandler<EventStreamEventReceivedArgs<EndEvent>> EndEventReceived;
    }

    /// <summary>
    /// A Stream of Events returned by the SelectObjectContent operation. Events can be retrieved from this stream by either
    /// <list type="bullet">
    ///   <item><description>attaching handlers to listen events, and then call StartProcessing <i>or</i></description></item>
    ///   <item><description>enumerating over the events.</description></item>
    /// </list>
    /// <para></para>
    /// These options should be treaded as mutually exclusive.
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1710", Justification = "SelectObjectContentEventStreamCollection is not descriptive.")]
    [SuppressMessage("Microsoft.Design", "CA1063", Justification = "IDisposable is a transient interface from IEventStream. Users need to be able to call Dispose.")]
    public sealed class SelectObjectContentEventStream : EnumerableEventOutputStream<IS3Event, S3EventStreamException>,
        ISelectObjectContentEventStream
    {
        /// <summary>
        /// The mapping of event message to a generator function to construct the matching Event Stream event.
        /// </summary>
        protected override IDictionary<string, Func<IEventStreamMessage, IS3Event>> EventMapping { get; } =
            new Dictionary<string, Func<IEventStreamMessage, IS3Event>>
            {
                {UnknownEventKey, payload => new UnknownEventStreamEvent(payload)},
                {"Records", payload => new RecordsEvent(payload)},
                {"Stats", payload => new StatsEvent(payload)},
                {"Progress", payload => new ProgressEvent(payload)},
                {"Cont", payload => new ContinuationEvent(payload)},
                {"End", payload => new EndEvent(payload)}
            };

        /// <summary>
        /// The mapping of event message to a generator function to construct the matching Event Stream exception.
        /// </summary>
        protected override IDictionary<string, Func<IEventStreamMessage, S3EventStreamException>> ExceptionMapping { get;} =
            new Dictionary<string, Func<IEventStreamMessage, S3EventStreamException>>
            {
            };

        // Backing by a volatile bool. The flag only changes one way, so no need for a lock.
        // This is located in the subclass to be CLS compliant.
        private volatile bool _isProcessing;

        /// <summary>
        /// Whether the backround processing loop is running.
        /// </summary>
        protected override bool IsProcessing
        {
            get { return _isProcessing; }
            set { _isProcessing = value; }
        }


        /// <summary>
        /// Event that encompasses all IS3Events.
        /// </summary>
        public override event EventHandler<EventStreamEventReceivedArgs<IS3Event>> EventReceived;

        /// <summary>
        /// Event that encompasses S3EventStreamExceptions.
        /// </summary>
        public override event EventHandler<EventStreamExceptionReceivedArgs<S3EventStreamException>> ExceptionReceived;

        /// <summary>
        /// Reaised when a Records event is received.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<RecordsEvent>> RecordsEventReceived;

        /// <summary>
        /// Reaised when a Stats event is received.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<StatsEvent>> StatsEventReceived;

        /// <summary>
        /// Reaised when a Progress event is received.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<ProgressEvent>> ProgressEventReceived;

        /// <summary>
        /// Reaised when a Continuation event is received.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<ContinuationEvent>> ContinuationEventReceived;

        /// <summary>
        /// Reaised when an End event is received.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<EndEvent>> EndEventReceived;

        /// <summary>
        /// Event Stream returned by SelectObjectContentStream.
        /// <para></para>
        /// Events can be retrieved from this stream by either
        /// <list type="bullet">
        ///   <item><description>attaching handlers to listen events, and then call StartProcessing <i>or</i></description></item>
        ///   <item><description>enumerating over the events.</description></item>
        /// </list>
        /// <para></para>
        /// These options should be treated as mutually exclusive.
        /// </summary>
        /// <param name="selectObjectStream">The network stream which events will be parsed from.</param>
        public SelectObjectContentEventStream(Stream selectObjectStream) : this(selectObjectStream, null)
        {
        }

        /// <summary>
        /// Event Stream returned by SelectObjectContentStream.
        /// <para></para>
        /// Events can be retrieved from this stream by either
        /// <list type="bullet">
        ///   <item><description>attaching handlers to listen events, and then call StartProcessing <i>or</i></description></item>
        ///   <item><description>enumerating over the events.</description></item>
        /// </list>
        /// <para></para>
        /// These options should be treaded as mutually exclusive.
        /// </summary>
        /// <param name="selectObjectStream">The network stream which events will be parsed from.</param>
        /// <param name="eventStreamDecoder">The decoder responsible for parsing events.</param>
        public SelectObjectContentEventStream(Stream selectObjectStream, IEventStreamDecoder eventStreamDecoder)
            : base(selectObjectStream, eventStreamDecoder)
        {
            // C# doesn't do event inheritance right. They are effectively treated as new, but not quite.
            //
            // In this case, EventStream has an event handler reference, and SelectObjectContentEventStream has an event handler reference (like new).
            // But it also overrides the accessors, so references will be polymorphically directed (like override).
            //
            // So when we attach event handlers, they are attached to the SelectObjectContentEventStream.
            // But when the EventStream code raises an event, those are raised on the EventStream handler reference.
            //
            // As a result, we get no events! 
            //
            // Here, we are attaching a handler to raise our event when a subclass event/exception is raised.
            // Currently, all 'events' are raised in the subclass, so this is only needed for exceptions. Stubbed for generator use.
            base.EventReceived += (sender, args) => EventReceived?.Invoke(this, args);
            base.ExceptionReceived += (sender, args) => ExceptionReceived?.Invoke(this, args);

            // Mapping the generic event to more specific events.
            Decoder.MessageReceived += (sender, args) =>
            {
                IS3Event ev;
                try
                {
                    ev = ConvertMessageToEvent(args.Message);
                }
                catch (UnknownEventStreamMessageTypeException)
                {
                    // Silence to ensure backwards-compatability with future EventStream specification.
                    return;
                }

                EventReceived?.Invoke(this, new EventStreamEventReceivedArgs<IS3Event>(ev));

                // Call RaiseEvent until it returns true or all calls complete. This way, only a subset of casts is preformed,
                // and we can avoid a cascade of nested if/else statements. The result is thrown away.
                var _ = RaiseEvent(RecordsEventReceived, ev) ||
                        RaiseEvent(StatsEventReceived, ev) ||
                        RaiseEvent(ProgressEventReceived, ev) ||
                        RaiseEvent(ContinuationEventReceived, ev) ||
                        RaiseEvent(EndEventReceived, ev);
            };
        }

        private bool RaiseEvent<T>(EventHandler<EventStreamEventReceivedArgs<T>> eventHandler, IS3Event ev) where T : class, IS3Event
        {
            var convertedEvent = ev as T;
            if (convertedEvent != null)
            {
                eventHandler?.Invoke(this, new EventStreamEventReceivedArgs<T>(convertedEvent));
                return true;
            }

            return false;
        }
    }
}