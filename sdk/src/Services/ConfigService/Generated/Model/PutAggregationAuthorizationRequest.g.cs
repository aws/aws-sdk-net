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
    /// Container for the parameters to the PutAggregationAuthorization operation. Authorizes
    /// the aggregator account and region to collect data from the source account and region.
    /// <note> <para> <b>Tags are added at creation and cannot be updated with this operation</b>
    /// </para> <para> <c>PutAggregationAuthorization</c> is an idempotent API. Subsequent
    /// requests won’t create a duplicate resource if one was already created. If a following
    /// request has different <c>tags</c> values, Config will ignore these differences and
    /// treat it as an idempotent request of the previous. In this case, <c>tags</c> will
    /// not be updated, even if they are different. </para> <para> Use <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_TagResource.html">TagResource</a>
    /// and <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_UntagResource.html">UntagResource</a>
    /// to update tags after creation. </para> </note>
    /// </summary>
    public partial class PutAggregationAuthorizationRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AuthorizedAccountId. 
        /// <para>
        /// The 12-digit account ID of the account authorized to aggregate data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AuthorizedAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizedAccountId property is set.
        /// </summary>
        internal bool IsSetAuthorizedAccountId() => this.AuthorizedAccountId != null;

        /// <summary>
        /// Gets and sets the property AuthorizedAwsRegion. 
        /// <para>
        /// The region authorized to collect aggregated data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AuthorizedAwsRegion { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizedAwsRegion property is set.
        /// </summary>
        internal bool IsSetAuthorizedAwsRegion() => this.AuthorizedAwsRegion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of tag object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
