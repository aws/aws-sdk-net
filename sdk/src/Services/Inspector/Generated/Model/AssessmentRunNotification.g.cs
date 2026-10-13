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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Used as one of the elements of the <a>AssessmentRun</a> data type.
    /// </summary>
    public partial class AssessmentRunNotification
    {
        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date of the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The Boolean value that specifies whether the notification represents an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error.HasValue;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The event for which a notification is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InspectorEvent Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message included in the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property SnsPublishStatusCode. 
        /// <para>
        /// The status code of the SNS notification.
        /// </para>
        /// </summary>
        public AssessmentRunNotificationSnsStatusCode SnsPublishStatusCode { get; set; }

        /// <summary>
        /// Checks to see if the SnsPublishStatusCode property is set.
        /// </summary>
        internal bool IsSetSnsPublishStatusCode() => this.SnsPublishStatusCode != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The SNS topic to which the SNS notification is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string SnsTopicArn { get; set; }

        /// <summary>
        /// Checks to see if the SnsTopicArn property is set.
        /// </summary>
        internal bool IsSetSnsTopicArn() => this.SnsTopicArn != null;
    }
}
