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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedDBInstancesOffering operation.
    /// Purchases a reserved DB instance offering.
    /// </summary>
    public partial class PurchaseReservedDBInstancesOfferingRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public PurchaseReservedDBInstancesOfferingRequest() { }

        /// <summary>
        /// Instantiates PurchaseReservedDBInstancesOfferingRequest with the parameterized properties
        /// </summary>
        /// <param name="reservedDBInstancesOfferingId">The ID of the Reserved DB instance offering to purchase. Example: 438012d3-4052-4cc7-b2e3-8d3372e0e706</param>
        public PurchaseReservedDBInstancesOfferingRequest(string reservedDBInstancesOfferingId)
        {
            this.ReservedDBInstancesOfferingId = reservedDBInstancesOfferingId;
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
        public int? DBInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceCount property is set.
        /// </summary>
        internal bool IsSetDBInstanceCount() => this.DBInstanceCount.HasValue;

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
        public string ReservedDBInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedDBInstanceId property is set.
        /// </summary>
        internal bool IsSetReservedDBInstanceId() => this.ReservedDBInstanceId != null;

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
        [AWSProperty(Required = true)]
        public string ReservedDBInstancesOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedDBInstancesOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedDBInstancesOfferingId() => this.ReservedDBInstancesOfferingId != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
