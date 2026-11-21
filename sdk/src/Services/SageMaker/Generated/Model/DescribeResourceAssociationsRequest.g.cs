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
    /// Container for the parameters to the DescribeResourceAssociations operation. Returns
    /// the resources in your account that are associated with a SageMaker Capacity Reservation
    /// and the status of each association. Resources include SageMaker AI HyperPod clusters
    /// and SageMaker AI endpoints.
    /// </summary>
    public partial class DescribeResourceAssociationsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. If more results are available,
        /// the response includes a <c>NextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, the response includes a <c>NextToken</c> value.
        /// To retrieve the next set of results, use that token in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SMCapacityReservationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker Capacity Reservation. The ARN has
        /// the format <c>arn:aws:sagemaker:region:account-id:sm-capacity-reservation/smcr-id</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string SMCapacityReservationArn { get; set; }

        /// <summary>
        /// Checks to see if the SMCapacityReservationArn property is set.
        /// </summary>
        internal bool IsSetSMCapacityReservationArn() => this.SMCapacityReservationArn != null;
    }
}
