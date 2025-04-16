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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// A container for specifying the configuration for publication of messages to an Amazon
    /// Simple Notification Service (Amazon SNS) topic when Amazon S3 detects specified events.
    /// </summary>
    public partial class TopicConfiguration
    {
        private List<string> _events = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NotificationConfigurationFilter _filter;
        private string _id;
        private string _topicArn;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The Amazon S3 bucket event about which to send notifications. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Supported
        /// Event Types</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public NotificationConfigurationFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which Amazon S3 publishes
        /// a message when it detects events of the specified type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}