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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides comprehensive details about a resource.
    /// </summary>
    public partial class RemediationResource
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account that recorded the resource data in Security Hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud provider where the resource exists.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c> specifies that the resource exists in Amazon Web Services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Azure</c> specifies that the resource exists in Microsoft Azure.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public CloudProviderName CloudProvider { get; set; }

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region in which Security Hub recorded the resource data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceGuid. 
        /// <para>
        /// The global identifier used to identify a resource.
        /// </para>
        /// </summary>
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGuid property is set.
        /// </summary>
        internal bool IsSetResourceGuid() => this.ResourceGuid != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccountId. 
        /// <para>
        /// The identifier of the cloud account that owns the resource. For Amazon Web Services
        /// resources, this is the Amazon Web Services account ID. For Azure resources, this is
        /// the Azure subscription ID.
        /// </para>
        /// </summary>
        public string ResourceOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerAccountId() => this.ResourceOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerOrgId. 
        /// <para>
        /// The identifier of the cloud organization that owns the resource. For Amazon Web Services
        /// resources, this is the Organizations ID. For Azure resources, this is the Azure tenant
        /// ID.
        /// </para>
        /// </summary>
        public string ResourceOwnerOrgId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerOrgId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerOrgId() => this.ResourceOwnerOrgId != null;

        /// <summary>
        /// Gets and sets the property ResourceRegion. 
        /// <para>
        /// The native cloud region where the resource is located. For Amazon Web Services, this
        /// is an Amazon Web Services Region (for example, <c>us-east-1</c>). For Azure resources,
        /// this is the Azure region (for example, <c>westus2</c>). This field is always included.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the ResourceRegion property is set.
        /// </summary>
        internal bool IsSetResourceRegion() => this.ResourceRegion != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
