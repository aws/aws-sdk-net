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
    /// Container for the parameters to the UpdateProduct operation.
    /// Updates the specified product.
    /// </summary>
    public partial class UpdateProductRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private List<Tag> _addTags = new List<Tag>();
        private string _description;
        private string _distributor;
        private string _id;
        private string _name;
        private string _owner;
        private List<string> _removeTags = new List<string>();
        private SourceConnection _sourceConnection;
        private string _supportDescription;
        private string _supportEmail;
        private string _supportUrl;

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
        /// Gets and sets the property AddTags. 
        /// <para>
        /// The tags to add to the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<Tag> AddTags
        {
            get { return this._addTags; }
            set { this._addTags = value; }
        }

        // Check to see if AddTags property is set
        internal bool IsSetAddTags()
        {
            return this._addTags != null && this._addTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
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
        /// Gets and sets the property Distributor. 
        /// <para>
        /// The updated distributor of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string Distributor
        {
            get { return this._distributor; }
            set { this._distributor = value; }
        }

        // Check to see if Distributor property is set
        internal bool IsSetDistributor()
        {
            return this._distributor != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated product name.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The updated owner of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveTags. 
        /// <para>
        /// The tags to remove from the product.
        /// </para>
        /// </summary>
        public List<string> RemoveTags
        {
            get { return this._removeTags; }
            set { this._removeTags = value; }
        }

        // Check to see if RemoveTags property is set
        internal bool IsSetRemoveTags()
        {
            return this._removeTags != null && this._removeTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceConnection. 
        /// <para>
        /// Specifies connection details for the updated product and syncs the product to the
        /// connection source artifact. This automatically manages the product's artifacts based
        /// on changes to the source. The <code>SourceConnection</code> parameter consists of
        /// the following sub-fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Type</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ConnectionParamters</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SourceConnection SourceConnection
        {
            get { return this._sourceConnection; }
            set { this._sourceConnection = value; }
        }

        // Check to see if SourceConnection property is set
        internal bool IsSetSourceConnection()
        {
            return this._sourceConnection != null;
        }

        /// <summary>
        /// Gets and sets the property SupportDescription. 
        /// <para>
        /// The updated support description for the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string SupportDescription
        {
            get { return this._supportDescription; }
            set { this._supportDescription = value; }
        }

        // Check to see if SupportDescription property is set
        internal bool IsSetSupportDescription()
        {
            return this._supportDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SupportEmail. 
        /// <para>
        /// The updated support email for the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=254)]
        public string SupportEmail
        {
            get { return this._supportEmail; }
            set { this._supportEmail = value; }
        }

        // Check to see if SupportEmail property is set
        internal bool IsSetSupportEmail()
        {
            return this._supportEmail != null;
        }

        /// <summary>
        /// Gets and sets the property SupportUrl. 
        /// <para>
        /// The updated support URL for the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2083)]
        public string SupportUrl
        {
            get { return this._supportUrl; }
            set { this._supportUrl = value; }
        }

        // Check to see if SupportUrl property is set
        internal bool IsSetSupportUrl()
        {
            return this._supportUrl != null;
        }

    }
}