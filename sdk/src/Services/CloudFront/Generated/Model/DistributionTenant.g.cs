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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The distribution tenant.
    /// </summary>
    public partial class DistributionTenant
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution tenant.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConnectionGroupId. 
        /// <para>
        /// The ID of the connection group for the distribution tenant. If you don't specify a
        /// connection group, CloudFront uses the default connection group.
        /// </para>
        /// </summary>
        public string ConnectionGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionGroupId property is set.
        /// </summary>
        internal bool IsSetConnectionGroupId() => this.ConnectionGroupId != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time when the distribution tenant was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Customizations. 
        /// <para>
        /// Customizations for the distribution tenant. For each distribution tenant, you can
        /// specify the geographic restrictions, and the Amazon Resource Names (ARNs) for the
        /// ACM certificate and WAF web ACL. These are specific values that you can override or
        /// disable from the multi-tenant distribution that was used to create the distribution
        /// tenant.
        /// </para>
        /// </summary>
        public Customizations Customizations { get; set; }

        /// <summary>
        /// Checks to see if the Customizations property is set.
        /// </summary>
        internal bool IsSetCustomizations() => this.Customizations != null;

        /// <summary>
        /// Gets and sets the property DistributionId. 
        /// <para>
        /// The ID of the multi-tenant distribution.
        /// </para>
        /// </summary>
        public string DistributionId { get; set; }

        /// <summary>
        /// Checks to see if the DistributionId property is set.
        /// </summary>
        internal bool IsSetDistributionId() => this.DistributionId != null;

        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// The domains associated with the distribution tenant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainResult> Domains { get; set; } = AWSConfigs.InitializeCollections ? new List<DomainResult>() : null;

        /// <summary>
        /// Checks to see if the Domains property is set.
        /// </summary>
        internal bool IsSetDomains() => this.Domains != null && (this.Domains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the distribution tenant is in an enabled state. If disabled, the
        /// distribution tenant won't serve traffic.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the distribution tenant.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time when the distribution tenant was updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the distribution tenant.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameter values to add to the resource. A parameter is specified as a key-value
        /// pair. A valid parameter value must exist for any parameter that is marked as required
        /// in the multi-tenant distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the distribution tenant.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;
    }
}
