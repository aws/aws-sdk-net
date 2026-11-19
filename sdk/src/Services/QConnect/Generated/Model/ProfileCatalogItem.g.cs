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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Contains information about a catalog item, including its identifier, name, price,
    /// and other attributes that are used in recommendations.
    /// </summary>
    public partial class ProfileCatalogItem
    {
        /// <summary>
        /// Gets and sets the property AdditionalInformation. 
        /// <para>
        /// Additional information about the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalInformation property is set.
        /// </summary>
        internal bool IsSetAdditionalInformation() => this.AdditionalInformation != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The custom attributes of the catalog item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the catalog item was created.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ImageLink. 
        /// <para>
        /// The URL of the image of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string ImageLink { get; set; }

        /// <summary>
        /// Checks to see if the ImageLink property is set.
        /// </summary>
        internal bool IsSetImageLink() => this.ImageLink != null;

        /// <summary>
        /// Gets and sets the property Link. 
        /// <para>
        /// The URL of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Link { get; set; }

        /// <summary>
        /// Checks to see if the Link property is set.
        /// </summary>
        internal bool IsSetLink() => this.Link != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Price. 
        /// <para>
        /// The price of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Price { get; set; }

        /// <summary>
        /// Checks to see if the Price property is set.
        /// </summary>
        internal bool IsSetPrice() => this.Price != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the catalog item.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the catalog item was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 32767)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt != null;
    }
}
