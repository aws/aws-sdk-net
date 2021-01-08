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
    /// This is the response object from the CreateProduct operation.
    /// </summary>
    public partial class CreateProductResponse : AmazonWebServiceResponse
    {
        private ProductViewDetail _productViewDetail;
        private ProvisioningArtifactDetail _provisioningArtifactDetail;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ProductViewDetail. 
        /// <para>
        /// Information about the product view.
        /// </para>
        /// </summary>
        public ProductViewDetail ProductViewDetail
        {
            get { return this._productViewDetail; }
            set { this._productViewDetail = value; }
        }

        // Check to see if ProductViewDetail property is set
        internal bool IsSetProductViewDetail()
        {
            return this._productViewDetail != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactDetail. 
        /// <para>
        /// Information about the provisioning artifact. 
        /// </para>
        /// </summary>
        public ProvisioningArtifactDetail ProvisioningArtifactDetail
        {
            get { return this._provisioningArtifactDetail; }
            set { this._provisioningArtifactDetail = value; }
        }

        // Check to see if ProvisioningArtifactDetail property is set
        internal bool IsSetProvisioningArtifactDetail()
        {
            return this._provisioningArtifactDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Information about the tags associated with the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}