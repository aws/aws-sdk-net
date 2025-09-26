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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains summary information about a routing profile manual assignment queue.
    /// </summary>
    public partial class RoutingProfileManualAssignmentQueueConfigSummary
    {
        private Channel _channel;
        private string _queueArn;
        private string _queueId;
        private string _queueName;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channels this queue supports. Valid Values: CHAT | TASK | EMAIL 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property QueueArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueArn
        {
            get { return this._queueArn; }
            set { this._queueArn = value; }
        }

        // Check to see if QueueArn property is set
        internal bool IsSetQueueArn()
        {
            return this._queueArn != null;
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The identifier for the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property QueueName. 
        /// <para>
        /// The name of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this._queueName != null;
        }

    }
}