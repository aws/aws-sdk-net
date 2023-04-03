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
    /// Container for the parameters to the DescribeProvisioningArtifact operation.
    /// Gets information about the specified provisioning artifact (also known as a version)
    /// for the specified product.
    /// </summary>
    public partial class DescribeProvisioningArtifactRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private string _productId;
        private string _productName;
        private string _provisioningArtifactId;
        private string _provisioningArtifactName;
        private bool? _verbose;

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
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The product name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactName. 
        /// <para>
        /// The provisioning artifact name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string ProvisioningArtifactName
        {
            get { return this._provisioningArtifactName; }
            set { this._provisioningArtifactName = value; }
        }

        // Check to see if ProvisioningArtifactName property is set
        internal bool IsSetProvisioningArtifactName()
        {
            return this._provisioningArtifactName != null;
        }

        /// <summary>
        /// Gets and sets the property Verbose. 
        /// <para>
        /// Indicates whether a verbose level of detail is enabled.
        /// </para>
        /// </summary>
        public bool Verbose
        {
            get { return this._verbose.GetValueOrDefault(); }
            set { this._verbose = value; }
        }

        // Check to see if Verbose property is set
        internal bool IsSetVerbose()
        {
            return this._verbose.HasValue; 
        }

    }
}