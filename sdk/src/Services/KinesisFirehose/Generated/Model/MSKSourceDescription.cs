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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Details about the Amazon MSK cluster used as the source for a Firehose stream.
    /// </summary>
    public partial class MSKSourceDescription
    {
        private AuthenticationConfiguration _authenticationConfiguration;
        private DateTime? _deliveryStartTimestamp;
        private string _mskClusterARN;
        private DateTime? _readFromTimestamp;
        private string _topicName;

        /// <summary>
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication configuration of the Amazon MSK cluster.
        /// </para>
        /// </summary>
        public AuthenticationConfiguration AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStartTimestamp. 
        /// <para>
        /// Firehose starts retrieving records from the topic within the Amazon MSK cluster starting
        /// with this timestamp.
        /// </para>
        /// </summary>
        public DateTime? DeliveryStartTimestamp
        {
            get { return this._deliveryStartTimestamp; }
            set { this._deliveryStartTimestamp = value; }
        }

        // Check to see if DeliveryStartTimestamp property is set
        internal bool IsSetDeliveryStartTimestamp()
        {
            return this._deliveryStartTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MSKClusterARN. 
        /// <para>
        /// The ARN of the Amazon MSK cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string MSKClusterARN
        {
            get { return this._mskClusterARN; }
            set { this._mskClusterARN = value; }
        }

        // Check to see if MSKClusterARN property is set
        internal bool IsSetMSKClusterARN()
        {
            return this._mskClusterARN != null;
        }

        /// <summary>
        /// Gets and sets the property ReadFromTimestamp. 
        /// <para>
        /// The start date and time in UTC for the offset position within your MSK topic from
        /// where Firehose begins to read. By default, this is set to timestamp when Firehose
        /// becomes Active. 
        /// </para>
        ///  
        /// <para>
        /// If you want to create a Firehose stream with Earliest start position from SDK or CLI,
        /// you need to set the <c>ReadFromTimestampUTC</c> parameter to Epoch (1970-01-01T00:00:00Z).
        /// 
        /// </para>
        /// </summary>
        public DateTime? ReadFromTimestamp
        {
            get { return this._readFromTimestamp; }
            set { this._readFromTimestamp = value; }
        }

        // Check to see if ReadFromTimestamp property is set
        internal bool IsSetReadFromTimestamp()
        {
            return this._readFromTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopicName. 
        /// <para>
        /// The topic name within the Amazon MSK cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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