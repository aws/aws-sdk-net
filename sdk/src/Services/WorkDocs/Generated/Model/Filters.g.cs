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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Filters results based on entity metadata.
    /// </summary>
    public partial class Filters
    {
        /// <summary>
        /// Gets and sets the property AncestorIds. 
        /// <para>
        /// Filter based on resource’s path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> AncestorIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AncestorIds property is set.
        /// </summary>
        internal bool IsSetAncestorIds() => this.AncestorIds != null && (this.AncestorIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContentCategories. 
        /// <para>
        /// Filters by content category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 9)]
        public List<string> ContentCategories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContentCategories property is set.
        /// </summary>
        internal bool IsSetContentCategories() => this.ContentCategories != null && (this.ContentCategories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedRange. 
        /// <para>
        /// Filter based on resource’s creation timestamp.
        /// </para>
        /// </summary>
        public DateRangeType CreatedRange { get; set; }

        /// <summary>
        /// Checks to see if the CreatedRange property is set.
        /// </summary>
        internal bool IsSetCreatedRange() => this.CreatedRange != null;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Filter by labels using exact match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> Labels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null && (this.Labels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModifiedRange. 
        /// <para>
        /// Filter based on resource’s modified timestamp.
        /// </para>
        /// </summary>
        public DateRangeType ModifiedRange { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedRange property is set.
        /// </summary>
        internal bool IsSetModifiedRange() => this.ModifiedRange != null;

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// Filter based on UserIds or GroupIds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SearchPrincipalType> Principals { get; set; } = AWSConfigs.InitializeCollections ? new List<SearchPrincipalType>() : null;

        /// <summary>
        /// Checks to see if the Principals property is set.
        /// </summary>
        internal bool IsSetPrincipals() => this.Principals != null && (this.Principals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// Filters based on entity type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SearchCollectionTypes. 
        /// <para>
        /// Filter based on file groupings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> SearchCollectionTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SearchCollectionTypes property is set.
        /// </summary>
        internal bool IsSetSearchCollectionTypes() => this.SearchCollectionTypes != null && (this.SearchCollectionTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SizeRange. 
        /// <para>
        /// Filter based on size (in bytes).
        /// </para>
        /// </summary>
        public LongRangeType SizeRange { get; set; }

        /// <summary>
        /// Checks to see if the SizeRange property is set.
        /// </summary>
        internal bool IsSetSizeRange() => this.SizeRange != null;

        /// <summary>
        /// Gets and sets the property TextLocales. 
        /// <para>
        /// Filters by the locale of the content or comment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> TextLocales { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TextLocales property is set.
        /// </summary>
        internal bool IsSetTextLocales() => this.TextLocales != null && (this.TextLocales.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
