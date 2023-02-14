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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The resource target configurations for receiving Amazon Chime SDK meeting and attendee
    /// event notifications. The Amazon Chime SDK supports resource targets located in the
    /// US East (N. Virginia) AWS Region (<code>us-east-1</code>).
    /// </summary>
    public partial class MeetingNotificationConfiguration
    {
        private string _snsTopicArn;
        private string _sqsQueueArn;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The SNS topic ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

        /// <summary>
        /// Gets and sets the property SqsQueueArn. 
        /// <para>
        /// The SQS queue ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1024)]
        public string SqsQueueArn
        {
            get { return this._sqsQueueArn; }
            set { this._sqsQueueArn = value; }
        }

        // Check to see if SqsQueueArn property is set
        internal bool IsSetSqsQueueArn()
        {
            return this._sqsQueueArn != null;
        }

    }
}