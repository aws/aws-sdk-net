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
    /// Container for the parameters to the ListAccessPolicies operation. Retrieves a paginated
    /// list of access policies for an identity (an IAM Identity Center user, an IAM Identity
    /// Center group, or an IAM user) or an IoT SiteWise Monitor resource (a portal or project).
    /// </summary>
    public partial class ListAccessPoliciesRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property IamArn. 
        /// <para>
        /// The ARN of the IAM user. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// ARNs</a> in the <i>IAM User Guide</i>. This parameter is required if you specify <c>IAM</c>
        /// for <c>identityType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string IamArn { get; set; }

        /// <summary>
        /// Checks to see if the IamArn property is set.
        /// </summary>
        internal bool IsSetIamArn() => this.IamArn != null;

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// The ID of the identity. This parameter is required if you specify <c>USER</c> or <c>GROUP</c>
        /// for <c>identityType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string IdentityId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityId property is set.
        /// </summary>
        internal bool IsSetIdentityId() => this.IdentityId != null;

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The type of identity (IAM Identity Center user, IAM Identity Center group, or IAM
        /// user). This parameter is required if you specify <c>identityId</c>.
        /// </para>
        /// </summary>
        public IdentityType IdentityType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityType property is set.
        /// </summary>
        internal bool IsSetIdentityType() => this.IdentityType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for each paginated request.
        /// </para>
        ///  
        /// <para>
        /// Default: 50
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource. This parameter is required if you specify <c>resourceType</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource (portal or project). This parameter is required if you specify
        /// <c>resourceId</c>.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
