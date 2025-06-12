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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
    /// Container for the parameters to the CreateDistributionTenant operation.
    /// Creates a distribution tenant.
    /// </summary>
    public partial class CreateDistributionTenantRequest : AmazonCloudFrontRequest
    {
        private string _connectionGroupId;
        private Customizations _customizations;
        private string _distributionId;
        private List<DomainItem> _domains = AWSConfigs.InitializeCollections ? new List<DomainItem>() : null;
        private bool? _enabled;
        private ManagedCertificateRequest _managedCertificateRequest;
        private string _name;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private Tags _tags;

        /// <summary>
        /// Gets and sets the property ConnectionGroupId. 
        /// <para>
        /// The ID of the connection group to associate with the distribution tenant.
        /// </para>
        /// </summary>
        public string ConnectionGroupId
        {
            get { return this._connectionGroupId; }
            set { this._connectionGroupId = value; }
        }

        // Check to see if ConnectionGroupId property is set
        internal bool IsSetConnectionGroupId()
        {
            return this._connectionGroupId != null;
        }

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
        public Customizations Customizations
        {
            get { return this._customizations; }
            set { this._customizations = value; }
        }

        // Check to see if Customizations property is set
        internal bool IsSetCustomizations()
        {
            return this._customizations != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionId. 
        /// <para>
        /// The ID of the multi-tenant distribution to use for creating the distribution tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DistributionId
        {
            get { return this._distributionId; }
            set { this._distributionId = value; }
        }

        // Check to see if DistributionId property is set
        internal bool IsSetDistributionId()
        {
            return this._distributionId != null;
        }

        /// <summary>
        /// Gets and sets the property Domains. 
        /// <para>
        /// The domains associated with the distribution tenant. You must specify at least one
        /// domain in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DomainItem> Domains
        {
            get { return this._domains; }
            set { this._domains = value; }
        }

        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this._domains != null && (this._domains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the distribution tenant should be enabled when created. If the distribution
        /// tenant is disabled, the distribution tenant won't serve traffic.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedCertificateRequest. 
        /// <para>
        /// The configuration for the CloudFront managed ACM certificate request.
        /// </para>
        /// </summary>
        public ManagedCertificateRequest ManagedCertificateRequest
        {
            get { return this._managedCertificateRequest; }
            set { this._managedCertificateRequest = value; }
        }

        // Check to see if ManagedCertificateRequest property is set
        internal bool IsSetManagedCertificateRequest()
        {
            return this._managedCertificateRequest != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the distribution tenant. Enter a friendly identifier that is unique within
        /// your Amazon Web Services account. This name can't be updated after you create the
        /// distribution tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameter values to add to the resource. A parameter is specified as a key-value
        /// pair. A valid parameter value must exist for any parameter that is marked as required
        /// in the multi-tenant distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

    }
}