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
    /// A collection of data from an MQTT topic. Channels archive the raw, unprocessed messages
    /// before publishing the data to a pipeline.
    /// </summary>
    public partial class Channel
    {
        private string _arn;
        private DateTime? _creationTime;
        private DateTime? _lastMessageArrivalTime;
        private DateTime? _lastUpdateTime;
        private string _name;
        private RetentionPeriod _retentionPeriod;
        private ChannelStatus _status;
        private ChannelStorage _storage;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the channel.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the channel was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastMessageArrivalTime. 
        /// <para>
        /// The last time when a new message arrived in the channel.
        /// </para>
        ///  
        /// <para>
        /// IoT Analytics updates this value at most once per minute for one channel. Hence, the
        /// <c>lastMessageArrivalTime</c> value is an approximation.
        /// </para>
        ///  
        /// <para>
        /// This feature only applies to messages that arrived in the data store after October
        /// 23, 2020. 
        /// </para>
        /// </summary>
        public DateTime? LastMessageArrivalTime
        {
            get { return this._lastMessageArrivalTime; }
            set { this._lastMessageArrivalTime = value; }
        }

        // Check to see if LastMessageArrivalTime property is set
        internal bool IsSetLastMessageArrivalTime()
        {
            return this._lastMessageArrivalTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// When the channel was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// How long, in days, message data is kept for the channel.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the channel.
        /// </para>
        /// </summary>
        public ChannelStatus Status
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
        /// Gets and sets the property Storage. 
        /// <para>
        /// Where channel data is stored. You can choose one of <c>serviceManagedS3</c> or <c>customerManagedS3</c>
        /// storage. If not specified, the default is <c>serviceManagedS3</c>. You can't change
        /// this storage option after the channel is created.
        /// </para>
        /// </summary>
        public ChannelStorage Storage
        {
            get { return this._storage; }
            set { this._storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this._storage != null;
        }

    }
}