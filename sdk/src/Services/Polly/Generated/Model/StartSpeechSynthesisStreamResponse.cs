/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Polly.Model
{
    /// <summary>
    /// This is the response object from the StartSpeechSynthesisStream operation.
    /// </summary>
    public partial class StartSpeechSynthesisStreamResponse : AmazonWebServiceResponse, Amazon.Runtime.EventStreams.IEventInputStreamContextOwner, IDisposable
    {
        private StartSpeechSynthesisStreamEventStream _eventStream;

        /// <summary>
        /// Gets and sets the property EventStream. 
        /// <para>
        /// The output event stream that contains synthesized audio events and stream status events.
        /// </para>
        /// </summary>
        public StartSpeechSynthesisStreamEventStream EventStream
        {
            get { return this._eventStream; }
            set { this._eventStream = value; }
        }

        // Check to see if EventStream property is set
        internal bool IsSetEventStream()
        {
            return this._eventStream != null;
        }

#pragma warning disable CA1033

        Amazon.Runtime.EventStreams.EventInputStreamContext _eventInputStreamContext;
        void Amazon.Runtime.EventStreams.IEventInputStreamContextOwner.SetEventInputStreamContext(Amazon.Runtime.EventStreams.EventInputStreamContext eventInputStreamContext)
        {
            this._eventInputStreamContext = eventInputStreamContext;
        }
#pragma warning restore CA1033
        #region Dispose Pattern

        private bool _disposed;

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                this._eventInputStreamContext?.Dispose();
                this._eventInputStreamContext = null;
                this._eventStream?.Dispose();
                this._eventStream = null;
            }

            this._disposed = true;
         }

         #endregion
    }
}