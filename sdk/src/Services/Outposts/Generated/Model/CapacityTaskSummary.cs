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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// The summary of the capacity task.
    /// </summary>
    public partial class CapacityTaskSummary
    {
        private string _assetId;
        private string _capacityTaskId;
        private CapacityTaskStatus _capacityTaskStatus;
        private DateTime? _completionDate;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private string _orderId;
        private string _outpostId;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset. An Outpost asset can be a single server within an Outposts rack
        /// or an Outposts server configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityTaskId. 
        /// <para>
        /// The ID of the specified capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string CapacityTaskId
        {
            get { return this._capacityTaskId; }
            set { this._capacityTaskId = value; }
        }

        // Check to see if CapacityTaskId property is set
        internal bool IsSetCapacityTaskId()
        {
            return this._capacityTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityTaskStatus. 
        /// <para>
        /// The status of the capacity task.
        /// </para>
        /// </summary>
        public CapacityTaskStatus CapacityTaskStatus
        {
            get { return this._capacityTaskStatus; }
            set { this._capacityTaskStatus = value; }
        }

        // Check to see if CapacityTaskStatus property is set
        internal bool IsSetCapacityTaskStatus()
        {
            return this._capacityTaskStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date that the specified capacity task successfully ran.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate
        {
            get { return this._completionDate; }
            set { this._completionDate = value; }
        }

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this._completionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date that the specified capacity task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date that the specified capacity was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrderId. 
        /// <para>
        /// The ID of the Amazon Web Services Outposts order of the host associated with the capacity
        /// task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string OrderId
        {
            get { return this._orderId; }
            set { this._orderId = value; }
        }

        // Check to see if OrderId property is set
        internal bool IsSetOrderId()
        {
            return this._orderId != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The ID of the Outpost associated with the specified capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

    }
}