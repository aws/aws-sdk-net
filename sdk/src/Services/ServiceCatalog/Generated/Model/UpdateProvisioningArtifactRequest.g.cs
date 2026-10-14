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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProvisioningArtifact operation. Updates
    /// the specified provisioning artifact (also known as a version) for the specified product.
    /// <para> You cannot update a provisioning artifact for a product that was shared with
    /// you. </para>
    /// </summary>
    public partial class UpdateProvisioningArtifactRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>jp</c> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zh</c> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// Checks to see if the AcceptLanguage property is set.
        /// </summary>
        internal bool IsSetAcceptLanguage() => this.AcceptLanguage != null;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Indicates whether the product version is active.
        /// </para>
        ///  
        /// <para>
        /// Inactive provisioning artifacts are invisible to end users. End users cannot launch
        /// or update a provisioned product from an inactive provisioning artifact.
        /// </para>
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Checks to see if the Active property is set.
        /// </summary>
        internal bool IsSetActive() => this.Active.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Guidance. 
        /// <para>
        /// Information set by the administrator to provide guidance to end users about which
        /// provisioning artifacts to use.
        /// </para>
        ///  
        /// <para>
        /// The <c>DEFAULT</c> value indicates that the product version is active.
        /// </para>
        ///  
        /// <para>
        /// The administrator can set the guidance to <c>DEPRECATED</c> to inform users that the
        /// product version is deprecated. Users are able to make updates to a provisioned product
        /// of a deprecated version but cannot launch new provisioned products using a deprecated
        /// version.
        /// </para>
        /// </summary>
        public ProvisioningArtifactGuidance Guidance { get; set; }

        /// <summary>
        /// Checks to see if the Guidance property is set.
        /// </summary>
        internal bool IsSetGuidance() => this.Guidance != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ProvisioningArtifactId { get; set; }

        /// <summary>
        /// Checks to see if the ProvisioningArtifactId property is set.
        /// </summary>
        internal bool IsSetProvisioningArtifactId() => this.ProvisioningArtifactId != null;
    }
}
