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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListActions operation. Retrieves a paginated list
    /// of actions for a specific target resource.
    /// </summary>
    public partial class ListActionsRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResolveToResourceId. 
        /// <para>
        /// The ID of the resolved resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ResolveToResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResolveToResourceId property is set.
        /// </summary>
        internal bool IsSetResolveToResourceId() => this.ResolveToResourceId != null;

        /// <summary>
        /// Gets and sets the property ResolveToResourceType. 
        /// <para>
        /// The type of the resolved resource.
        /// </para>
        /// </summary>
        public ResolveToResourceType ResolveToResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResolveToResourceType property is set.
        /// </summary>
        internal bool IsSetResolveToResourceType() => this.ResolveToResourceType != null;

        /// <summary>
        /// Gets and sets the property TargetResourceId. 
        /// <para>
        /// The ID of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceId property is set.
        /// </summary>
        internal bool IsSetTargetResourceId() => this.TargetResourceId != null;

        /// <summary>
        /// Gets and sets the property TargetResourceType. 
        /// <para>
        /// The type of resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetResourceType TargetResourceType { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceType property is set.
        /// </summary>
        internal bool IsSetTargetResourceType() => this.TargetResourceType != null;
    }
}
