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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Represents an item in the catalog with its complete set of attributes and metadata.
    /// </summary>
    public partial class CatalogItem
    {
        private string _additionalInformation;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _category;
        private string _code;
        private DateTime? _createdAt;
        private string _description;
        private string _id;
        private string _imageLink;
        private string _link;
        private string _name;
        private string _price;
        private string _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AdditionalInformation. 
        /// <para>
        /// Supplementary information about the catalog item beyond the basic description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string AdditionalInformation
        {
            get { return this._additionalInformation; }
            set { this._additionalInformation = value; }
        }

        // Check to see if AdditionalInformation property is set
        internal bool IsSetAdditionalInformation()
        {
            return this._additionalInformation != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Additional attributes or properties associated with the catalog item stored as key-value
        /// pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category to which the catalog item belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The product code or SKU of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the catalog item was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property ImageLink. 
        /// <para>
        /// The URL link to the item's image.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string ImageLink
        {
            get { return this._imageLink; }
            set { this._imageLink = value; }
        }

        // Check to see if ImageLink property is set
        internal bool IsSetImageLink()
        {
            return this._imageLink != null;
        }

        /// <summary>
        /// Gets and sets the property Link. 
        /// <para>
        /// The URL link to the item's detailed page or external resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public string Link
        {
            get { return this._link; }
            set { this._link = value; }
        }

        // Check to see if Link property is set
        internal bool IsSetLink()
        {
            return this._link != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property Price. 
        /// <para>
        /// The price of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

        // Check to see if Price property is set
        internal bool IsSetPrice()
        {
            return this._price != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type classification of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the catalog item was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}