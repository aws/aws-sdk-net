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

namespace Amazon.PartnerCentralRevenueMeasurement.Model
{
    /// <summary>
    /// This is the response object from the GetRevenueAttributionAllocation operation.
    /// </summary>
    public partial class GetRevenueAttributionAllocationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// When the allocation was first created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerAwsAccountId. 
        /// <para>
        /// The customer AWS account ID for this associated deal entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 12, Max = 12)]
        public string CustomerAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAwsAccountId property is set.
        /// </summary>
        internal bool IsSetCustomerAwsAccountId() => this.CustomerAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// First day of the effective month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string EffectiveFrom { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveFrom property is set.
        /// </summary>
        internal bool IsSetEffectiveFrom() => this.EffectiveFrom != null;

        /// <summary>
        /// Gets and sets the property EffectiveUntil. 
        /// <para>
        /// Last day of the effective month.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string EffectiveUntil { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveUntil property is set.
        /// </summary>
        internal bool IsSetEffectiveUntil() => this.EffectiveUntil != null;

        /// <summary>
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// The unique identifier of the associated deal entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EntityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EntityIdentifier property is set.
        /// </summary>
        internal bool IsSetEntityIdentifier() => this.EntityIdentifier != null;

        /// <summary>
        /// Gets and sets the property EntityName. 
        /// <para>
        /// The display name of the associated deal entity.
        /// </para>
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// Checks to see if the EntityName property is set.
        /// </summary>
        internal bool IsSetEntityName() => this.EntityName != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the associated deal entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// When the allocation was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property RevenueAttributionAllocationId. 
        /// <para>
        /// Unique allocation identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string RevenueAttributionAllocationId { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionAllocationId property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionAllocationId() => this.RevenueAttributionAllocationId != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionIdentifier. 
        /// <para>
        /// The revenue attribution identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 1011)]
        public string RevenueAttributionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionIdentifier property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionIdentifier() => this.RevenueAttributionIdentifier != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionLatestRevision. 
        /// <para>
        /// The latest committed revision.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 19)]
        public string RevenueAttributionLatestRevision { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionLatestRevision property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionLatestRevision() => this.RevenueAttributionLatestRevision != null;

        /// <summary>
        /// Gets and sets the property RevenueAttributionRevision. 
        /// <para>
        /// The revision of this allocation version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 19)]
        public string RevenueAttributionRevision { get; set; }

        /// <summary>
        /// Checks to see if the RevenueAttributionRevision property is set.
        /// </summary>
        internal bool IsSetRevenueAttributionRevision() => this.RevenueAttributionRevision != null;

        /// <summary>
        /// Gets and sets the property RevenueSharePercent. 
        /// <para>
        /// Revenue share percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 6)]
        public string RevenueSharePercent { get; set; }

        /// <summary>
        /// Checks to see if the RevenueSharePercent property is set.
        /// </summary>
        internal bool IsSetRevenueSharePercent() => this.RevenueSharePercent != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current allocation status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllocationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
