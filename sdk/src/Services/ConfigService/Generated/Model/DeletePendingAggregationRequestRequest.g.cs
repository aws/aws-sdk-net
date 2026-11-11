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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeletePendingAggregationRequest operation. Deletes
    /// pending authorization requests for a specified aggregator account in a specified region.
    /// </summary>
    public partial class DeletePendingAggregationRequestRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property RequesterAccountId. 
        /// <para>
        /// The 12-digit account ID of the account requesting to aggregate data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RequesterAccountId { get; set; }

        /// <summary>
        /// Checks to see if the RequesterAccountId property is set.
        /// </summary>
        internal bool IsSetRequesterAccountId() => this.RequesterAccountId != null;

        /// <summary>
        /// Gets and sets the property RequesterAwsRegion. 
        /// <para>
        /// The region requesting to aggregate data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RequesterAwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the RequesterAwsRegion property is set.
        /// </summary>
        internal bool IsSetRequesterAwsRegion() => this.RequesterAwsRegion != null;
    }
}
