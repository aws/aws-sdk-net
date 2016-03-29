/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used as one of the elements of the <a>AssessmentRun</a> data type.
    /// </summary>
    public partial class AssessmentRunNotification
    {
        private DateTime? _date;
        private bool? _error;
        private Event _event;
        private string _message;
        private AssessmentRunNotificationSnsStatusCode _snsPublishStatusCode;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date of the notification.
        /// </para>
        /// </summary>
        public DateTime Date
        {
            get { return this._date.GetValueOrDefault(); }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The Boolean value that specifies whether the notification represents an error.
        /// </para>
        /// </summary>
        public bool Error
        {
            get { return this._error.GetValueOrDefault(); }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The event for which a notification is sent.
        /// </para>
        /// </summary>
        public Event Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property Message.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property SnsPublishStatusCode. 
        /// <para>
        /// The status code of the SNS notification.
        /// </para>
        /// </summary>
        public AssessmentRunNotificationSnsStatusCode SnsPublishStatusCode
        {
            get { return this._snsPublishStatusCode; }
            set { this._snsPublishStatusCode = value; }
        }

        // Check to see if SnsPublishStatusCode property is set
        internal bool IsSetSnsPublishStatusCode()
        {
            return this._snsPublishStatusCode != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The SNS topic to which the SNS notification is sent.
        /// </para>
        /// </summary>
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

    }
}