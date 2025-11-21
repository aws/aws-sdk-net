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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// This is the response object from the CreatePortalProduct operation.
    /// </summary>
    public partial class CreatePortalProductResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _displayName;
        private DisplayOrder _displayOrder;
        private DateTime? _lastModified;
        private string _portalProductArn;
        private string _portalProductId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the portal product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name for the portal product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayOrder. 
        /// <para>
        /// The visual ordering of the product pages and product REST endpoint pages in a published
        /// portal.
        /// </para>
        /// </summary>
        public DisplayOrder DisplayOrder
        {
            get { return this._displayOrder; }
            set { this._displayOrder = value; }
        }

        // Check to see if DisplayOrder property is set
        internal bool IsSetDisplayOrder()
        {
            return this._displayOrder != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The timestamp when the portal product was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PortalProductArn. 
        /// <para>
        /// The ARN of the portal product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PortalProductArn
        {
            get { return this._portalProductArn; }
            set { this._portalProductArn = value; }
        }

        // Check to see if PortalProductArn property is set
        internal bool IsSetPortalProductArn()
        {
            return this._portalProductArn != null;
        }

        /// <summary>
        /// Gets and sets the property PortalProductId. 
        /// <para>
        /// The portal product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=30)]
        public string PortalProductId
        {
            get { return this._portalProductId; }
            set { this._portalProductId = value; }
        }

        // Check to see if PortalProductId property is set
        internal bool IsSetPortalProductId()
        {
            return this._portalProductId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}