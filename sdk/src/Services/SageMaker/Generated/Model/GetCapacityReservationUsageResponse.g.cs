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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the GetCapacityReservationUsage operation.
    /// </summary>
    public partial class GetCapacityReservationUsageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances in the SageMaker Capacity Reservation that are not in use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? AvailableInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableInstanceCount() => this.AvailableInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceUsageSet. 
        /// <para>
        /// The instance usage for each account that uses instances from the SageMaker Capacity
        /// Reservation, sorted by account ID. Each account appears at most once across all pages.
        /// The list is empty when no instances are in use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CapacityReservationInstanceUsage> InstanceUsageSet { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityReservationInstanceUsage>() : null;

        /// <summary>
        /// Checks to see if the InstanceUsageSet property is set.
        /// </summary>
        internal bool IsSetInstanceUsageSet() => this.InstanceUsageSet != null && (this.InstanceUsageSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastRefreshTime. 
        /// <para>
        /// The time when SageMaker AI last refreshed the usage counts in this response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastRefreshTime { get; set; }

        /// <summary>
        /// Checks to see if the LastRefreshTime property is set.
        /// </summary>
        internal bool IsSetLastRefreshTime() => this.LastRefreshTime.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, SageMaker AI returns this token. To retrieve the next
        /// set of results, use this token in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SMCapacityReservationId. 
        /// <para>
        /// The ID of the SageMaker Capacity Reservation. The ID is the last part of the ARN and
        /// starts with <c>smcr-</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SMCapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the SMCapacityReservationId property is set.
        /// </summary>
        internal bool IsSetSMCapacityReservationId() => this.SMCapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The number of instances in the SageMaker Capacity Reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? TotalInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalInstanceCount property is set.
        /// </summary>
        internal bool IsSetTotalInstanceCount() => this.TotalInstanceCount.HasValue;
    }
}
