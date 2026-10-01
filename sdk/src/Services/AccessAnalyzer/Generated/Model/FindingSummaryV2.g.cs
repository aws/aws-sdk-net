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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about a finding.
    /// </summary>
    public partial class FindingSummaryV2
    {
        /// <summary>
        /// Gets and sets the property AnalyzedAt. 
        /// <para>
        /// The time at which the resource-based policy or IAM entity that generated the finding
        /// was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AnalyzedAt { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzedAt property is set.
        /// </summary>
        internal bool IsSetAnalyzedAt() => this.AnalyzedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the finding was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error that resulted in an Error finding.
        /// </para>
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The type of the access finding. For external access analyzers, the type is <c>ExternalAccess</c>.
        /// For unused access analyzers, the type can be <c>UnusedIAMRole</c>, <c>UnusedIAMUserAccessKey</c>,
        /// <c>UnusedIAMUserPassword</c>, or <c>UnusedPermission</c>. For internal access analyzers,
        /// the type is <c>InternalAccess</c>.
        /// </para>
        /// </summary>
        public FindingType FindingType { get; set; }

        /// <summary>
        /// Checks to see if the FindingType property is set.
        /// </summary>
        internal bool IsSetFindingType() => this.FindingType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource that the external principal has access to.
        /// </para>
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccount. 
        /// <para>
        /// The Amazon Web Services account ID that owns the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerAccount property is set.
        /// </summary>
        internal bool IsSetResourceOwnerAccount() => this.ResourceOwnerAccount != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource that the external principal has access to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the finding was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
