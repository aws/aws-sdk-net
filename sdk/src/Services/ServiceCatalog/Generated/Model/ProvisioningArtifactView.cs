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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// An object that contains summary information about a product view and a provisioning
    /// artifact.
    /// </summary>
    public partial class ProvisioningArtifactView
    {
        private ProductViewSummary _productViewSummary;
        private ProvisioningArtifact _provisioningArtifact;

        /// <summary>
        /// Gets and sets the property ProductViewSummary. 
        /// <para>
        /// Summary information about a product view.
        /// </para>
        /// </summary>
        public ProductViewSummary ProductViewSummary
        {
            get { return this._productViewSummary; }
            set { this._productViewSummary = value; }
        }

        // Check to see if ProductViewSummary property is set
        internal bool IsSetProductViewSummary()
        {
            return this._productViewSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifact. 
        /// <para>
        /// Information about a provisioning artifact. A provisioning artifact is also known as
        /// a product version.
        /// </para>
        /// </summary>
        public ProvisioningArtifact ProvisioningArtifact
        {
            get { return this._provisioningArtifact; }
            set { this._provisioningArtifact = value; }
        }

        // Check to see if ProvisioningArtifact property is set
        internal bool IsSetProvisioningArtifact()
        {
            return this._provisioningArtifact != null;
        }

    }
}