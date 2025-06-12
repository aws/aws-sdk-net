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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedDBInstancesOffering operation.
    /// Purchases a reserved DB instance offering.
    /// </summary>
    public partial class PurchaseReservedDBInstancesOfferingRequest : AmazonRDSRequest
    {
        private int? _dbInstanceCount;
        private string _reservedDBInstanceId;
        private string _reservedDBInstancesOfferingId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PurchaseReservedDBInstancesOfferingRequest() { }

        /// <summary>
        /// Instantiates PurchaseReservedDBInstancesOfferingRequest with the parameterized properties
        /// </summary>
        /// <param name="reservedDBInstancesOfferingId">The ID of the Reserved DB instance offering to purchase. Example: 438012d3-4052-4cc7-b2e3-8d3372e0e706</param>
        public PurchaseReservedDBInstancesOfferingRequest(string reservedDBInstancesOfferingId)
        {
            _reservedDBInstancesOfferingId = reservedDBInstancesOfferingId;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceCount. 
        /// <para>
        /// The number of instances to reserve.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1</c> 
        /// </para>
        /// </summary>
        public int? DBInstanceCount
        {
            get { return this._dbInstanceCount; }
            set { this._dbInstanceCount = value; }
        }

        // Check to see if DBInstanceCount property is set
        internal bool IsSetDBInstanceCount()
        {
            return this._dbInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedDBInstanceId. 
        /// <para>
        /// Customer-specified identifier to track this reservation.
        /// </para>
        ///  
        /// <para>
        /// Example: myreservationID
        /// </para>
        /// </summary>
        public string ReservedDBInstanceId
        {
            get { return this._reservedDBInstanceId; }
            set { this._reservedDBInstanceId = value; }
        }

        // Check to see if ReservedDBInstanceId property is set
        internal bool IsSetReservedDBInstanceId()
        {
            return this._reservedDBInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedDBInstancesOfferingId. 
        /// <para>
        /// The ID of the Reserved DB instance offering to purchase.
        /// </para>
        ///  
        /// <para>
        /// Example: 438012d3-4052-4cc7-b2e3-8d3372e0e706
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReservedDBInstancesOfferingId
        {
            get { return this._reservedDBInstancesOfferingId; }
            set { this._reservedDBInstancesOfferingId = value; }
        }

        // Check to see if ReservedDBInstancesOfferingId property is set
        internal bool IsSetReservedDBInstancesOfferingId()
        {
            return this._reservedDBInstancesOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}