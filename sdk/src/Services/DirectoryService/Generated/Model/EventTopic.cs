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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Information about SNS topic and AWS Directory Service directory associations.
    /// </summary>
    public partial class EventTopic
    {
        private DateTime? _createdDateTime;
        private string _directoryId;
        private TopicStatus _status;
        private string _topicArn;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property CreatedDateTime. 
        /// <para>
        /// The date and time of when you associated your directory with the SNS topic.
        /// </para>
        /// </summary>
        public DateTime CreatedDateTime
        {
            get { return this._createdDateTime.GetValueOrDefault(); }
            set { this._createdDateTime = value; }
        }

        // Check to see if CreatedDateTime property is set
        internal bool IsSetCreatedDateTime()
        {
            return this._createdDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Directory ID of an AWS Directory Service directory that will publish status messages
        /// to an SNS topic.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The topic registration status.
        /// </para>
        /// </summary>
        public TopicStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The SNS topic ARN (Amazon Resource Name).
        /// </para>
        /// </summary>
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The name of an AWS SNS topic the receives status messages from the directory.
        /// </para>
        /// </summary>
        public string TopicName
        {
            get { return this._topicName; }
            set { this._topicName = value; }
        }

        // Check to see if TopicName property is set
        internal bool IsSetTopicName()
        {
            return this._topicName != null;
        }

    }
}