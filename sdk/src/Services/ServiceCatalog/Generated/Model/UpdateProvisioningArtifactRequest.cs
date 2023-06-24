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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProvisioningArtifact operation.
    /// Updates the specified provisioning artifact (also known as a version) for the specified
    /// product.
    /// 
    ///  
    /// <para>
    /// You cannot update a provisioning artifact for a product that was shared with you.
    /// </para>
    /// </summary>
    public partial class UpdateProvisioningArtifactRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private bool? _active;
        private string _description;
        private ProvisioningArtifactGuidance _guidance;
        private string _name;
        private string _productId;
        private string _provisioningArtifactId;

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

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
        public bool Active
        {
            get { return this._active.GetValueOrDefault(); }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Guidance. 
        /// <para>
        /// Information set by the administrator to provide guidance to end users about which
        /// provisioning artifacts to use.
        /// </para>
        ///  
        /// <para>
        /// The <code>DEFAULT</code> value indicates that the product version is active.
        /// </para>
        ///  
        /// <para>
        /// The administrator can set the guidance to <code>DEPRECATED</code> to inform users
        /// that the product version is deprecated. Users are able to make updates to a provisioned
        /// product of a deprecated version but cannot launch new provisioned products using a
        /// deprecated version.
        /// </para>
        /// </summary>
        public ProvisioningArtifactGuidance Guidance
        {
            get { return this._guidance; }
            set { this._guidance = value; }
        }

        // Check to see if Guidance property is set
        internal bool IsSetGuidance()
        {
            return this._guidance != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ProvisioningArtifactId
        {
            get { return this._provisioningArtifactId; }
            set { this._provisioningArtifactId = value; }
        }

        // Check to see if ProvisioningArtifactId property is set
        internal bool IsSetProvisioningArtifactId()
        {
            return this._provisioningArtifactId != null;
        }

    }
}