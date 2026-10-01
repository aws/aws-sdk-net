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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// A list of items that represent RelatedItems.
    /// </summary>
    public partial class SearchRelatedItemsResponseItem
    {
        /// <summary>
        /// Gets and sets the property AssociationTime. 
        /// <para>
        /// Time at which a related item was associated with a case.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AssociationTime { get; set; }

        /// <summary>
        /// Checks to see if the AssociationTime property is set.
        /// </summary>
        internal bool IsSetAssociationTime() => this.AssociationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Represents the content of a particular type of related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelatedItemContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property PerformedBy. 
        /// <para>
        /// Represents the creator of the related item.
        /// </para>
        /// </summary>
        public UserUnion PerformedBy { get; set; }

        /// <summary>
        /// Checks to see if the PerformedBy property is set.
        /// </summary>
        internal bool IsSetPerformedBy() => this.PerformedBy != null;

        /// <summary>
        /// Gets and sets the property RelatedItemId. 
        /// <para>
        /// Unique identifier of a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string RelatedItemId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedItemId property is set.
        /// </summary>
        internal bool IsSetRelatedItemId() => this.RelatedItemId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of of key-value pairs that represent tags on a resource. Tags are used to organize,
        /// track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of a related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelatedItemType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
