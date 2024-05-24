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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChannel operation.
    /// Used to update the settings of a channel.
    /// </summary>
    public partial class UpdateChannelRequest : AmazonIoTAnalyticsRequest
    {
        private string _channelName;
        private ChannelStorage _channelStorage;
        private RetentionPeriod _retentionPeriod;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelStorage. 
        /// <para>
        /// Where channel data is stored. You can choose one of <c>serviceManagedS3</c> or <c>customerManagedS3</c>
        /// storage. If not specified, the default is <c>serviceManagedS3</c>. You can't change
        /// this storage option after the channel is created.
        /// </para>
        /// </summary>
        public ChannelStorage ChannelStorage
        {
            get { return this._channelStorage; }
            set { this._channelStorage = value; }
        }

        // Check to see if ChannelStorage property is set
        internal bool IsSetChannelStorage()
        {
            return this._channelStorage != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// How long, in days, message data is kept for the channel. The retention period can't
        /// be updated if the channel's Amazon S3 storage is customer-managed.
        /// </para>
        /// </summary>
        public RetentionPeriod RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod != null;
        }

    }
}