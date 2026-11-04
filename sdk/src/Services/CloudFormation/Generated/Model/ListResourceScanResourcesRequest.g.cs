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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceScanResources operation. Lists the
    /// resources from a resource scan. The results can be filtered by resource identifier,
    /// resource type prefix, tag key, and tag value. Only resources that match all specified
    /// filters are returned. The response indicates whether each returned resource is already
    /// managed by CloudFormation.
    /// </summary>
    public partial class ListResourceScanResourcesRequest : AmazonCloudFormationRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// If the number of available results exceeds this maximum, the response includes a <c>NextToken</c>
        /// value that you can use for the <c>NextToken</c> parameter to get the next set of results.
        /// By default the <c>ListResourceScanResources</c> API action will return at most 100
        /// results in each response. The maximum value is 100.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// If specified, the returned resources will have the specified resource identifier (or
        /// one of them in the case where the resource has multiple identifiers).
        /// </para>
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceScanId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceScanId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceScanId property is set.
        /// </summary>
        internal bool IsSetResourceScanId() => this.ResourceScanId != null;

        /// <summary>
        /// Gets and sets the property ResourceTypePrefix. 
        /// <para>
        /// If specified, the returned resources will be of any of the resource types with the
        /// specified prefix.
        /// </para>
        /// </summary>
        public string ResourceTypePrefix { get; set; }

        /// <summary>
        /// Checks to see if the ResourceTypePrefix property is set.
        /// </summary>
        internal bool IsSetResourceTypePrefix() => this.ResourceTypePrefix != null;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// If specified, the returned resources will have a matching tag key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// If specified, the returned resources will have a matching tag value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TagValue { get; set; }

        /// <summary>
        /// Checks to see if the TagValue property is set.
        /// </summary>
        internal bool IsSetTagValue() => this.TagValue != null;
    }
}
