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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Contains information about a delivery stream.
    /// </summary>
    public partial class DeliveryStreamDescription
    {
        private DateTime? _createTimestamp;
        private string _deliveryStreamARN;
        private string _deliveryStreamName;
        private DeliveryStreamStatus _deliveryStreamStatus;
        private List<DestinationDescription> _destinations = new List<DestinationDescription>();
        private bool? _hasMoreDestinations;
        private DateTime? _lastUpdateTimestamp;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time that the delivery stream was created.
        /// </para>
        /// </summary>
        public DateTime CreateTimestamp
        {
            get { return this._createTimestamp.GetValueOrDefault(); }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the delivery stream.
        /// </para>
        /// </summary>
        public string DeliveryStreamARN
        {
            get { return this._deliveryStreamARN; }
            set { this._deliveryStreamARN = value; }
        }

        // Check to see if DeliveryStreamARN property is set
        internal bool IsSetDeliveryStreamARN()
        {
            return this._deliveryStreamARN != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream.
        /// </para>
        /// </summary>
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamStatus. 
        /// <para>
        /// The status of the delivery stream.
        /// </para>
        /// </summary>
        public DeliveryStreamStatus DeliveryStreamStatus
        {
            get { return this._deliveryStreamStatus; }
            set { this._deliveryStreamStatus = value; }
        }

        // Check to see if DeliveryStreamStatus property is set
        internal bool IsSetDeliveryStreamStatus()
        {
            return this._deliveryStreamStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The destinations.
        /// </para>
        /// </summary>
        public List<DestinationDescription> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HasMoreDestinations. 
        /// <para>
        /// Indicates whether there are more destinations available to list.
        /// </para>
        /// </summary>
        public bool HasMoreDestinations
        {
            get { return this._hasMoreDestinations.GetValueOrDefault(); }
            set { this._hasMoreDestinations = value; }
        }

        // Check to see if HasMoreDestinations property is set
        internal bool IsSetHasMoreDestinations()
        {
            return this._hasMoreDestinations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The date and time that the delivery stream was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp.GetValueOrDefault(); }
            set { this._lastUpdateTimestamp = value; }
        }

        // Check to see if LastUpdateTimestamp property is set
        internal bool IsSetLastUpdateTimestamp()
        {
            return this._lastUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Used when calling the <a>UpdateDestination</a> operation. Each time the destination
        /// is updated for the delivery stream, the VersionId is changed, and the current VersionId
        /// is required when updating the destination. This is so that the service knows it is
        /// applying the changes to the correct version of the delivery stream.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}