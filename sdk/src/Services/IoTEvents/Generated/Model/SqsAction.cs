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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Sends information about the detector model instance and the event that triggered the
    /// action to an Amazon SQS queue.
    /// </summary>
    public partial class SqsAction
    {
        private Payload _payload;
        private string _queueUrl;
        private bool? _useBase64;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// You can configure the action payload when you send a message to an Amazon SQS queue.
        /// </para>
        /// </summary>
        public Payload Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the SQS queue where the data is written.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueUrl
        {
            get { return this._queueUrl; }
            set { this._queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this._queueUrl != null;
        }

        /// <summary>
        /// Gets and sets the property UseBase64. 
        /// <para>
        /// Set this to TRUE if you want the data to be base-64 encoded before it is written to
        /// the queue. Otherwise, set this to FALSE.
        /// </para>
        /// </summary>
        public bool? UseBase64
        {
            get { return this._useBase64; }
            set { this._useBase64 = value; }
        }

        // Check to see if UseBase64 property is set
        internal bool IsSetUseBase64()
        {
            return this._useBase64.HasValue; 
        }

    }
}