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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the ListShareInvitations operation. List the share
    /// invitations. <para> <c>WorkloadNamePrefix</c>, <c>LensNamePrefix</c>, <c>ProfileNamePrefix</c>,
    /// and <c>TemplateNamePrefix</c> are mutually exclusive. Use the parameter that matches
    /// your <c>ShareResourceType</c>. </para>
    /// </summary>
    public partial class ListShareInvitationsRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property LensNamePrefix. 
        /// <para>
        /// An optional string added to the beginning of each lens name returned in the results.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string LensNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the LensNamePrefix property is set.
        /// </summary>
        internal bool IsSetLensNamePrefix() => this.LensNamePrefix != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return for this request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProfileNamePrefix. 
        /// <para>
        /// An optional string added to the beginning of each profile name returned in the results.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string ProfileNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the ProfileNamePrefix property is set.
        /// </summary>
        internal bool IsSetProfileNamePrefix() => this.ProfileNamePrefix != null;

        /// <summary>
        /// Gets and sets the property ShareResourceType. 
        /// <para>
        /// The type of share invitations to be returned.
        /// </para>
        /// </summary>
        public ShareResourceType ShareResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ShareResourceType property is set.
        /// </summary>
        internal bool IsSetShareResourceType() => this.ShareResourceType != null;

        /// <summary>
        /// Gets and sets the property TemplateNamePrefix. 
        /// <para>
        /// An optional string added to the beginning of each review template name returned in
        /// the results.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public string TemplateNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the TemplateNamePrefix property is set.
        /// </summary>
        internal bool IsSetTemplateNamePrefix() => this.TemplateNamePrefix != null;

        /// <summary>
        /// Gets and sets the property WorkloadNamePrefix.
        /// </summary>
        [AWSProperty(Max = 100)]
        public string WorkloadNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadNamePrefix property is set.
        /// </summary>
        internal bool IsSetWorkloadNamePrefix() => this.WorkloadNamePrefix != null;
    }
}
