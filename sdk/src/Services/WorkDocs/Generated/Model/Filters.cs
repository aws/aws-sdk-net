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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
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
        private List<string> _ancestorIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _contentCategories = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateRangeType _createdRange;
        private List<string> _labels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateRangeType _modifiedRange;
        private List<SearchPrincipalType> _principals = AWSConfigs.InitializeCollections ? new List<SearchPrincipalType>() : null;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _searchCollectionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private LongRangeType _sizeRange;
        private List<string> _textLocales = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AncestorIds. 
        /// <para>
        /// Filter based on resource’s path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<string> AncestorIds
        {
            get { return this._ancestorIds; }
            set { this._ancestorIds = value; }
        }

        // Check to see if AncestorIds property is set
        internal bool IsSetAncestorIds()
        {
            return this._ancestorIds != null && (this._ancestorIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ContentCategories. 
        /// <para>
        /// Filters by content category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=9)]
        public List<string> ContentCategories
        {
            get { return this._contentCategories; }
            set { this._contentCategories = value; }
        }

        // Check to see if ContentCategories property is set
        internal bool IsSetContentCategories()
        {
            return this._contentCategories != null && (this._contentCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedRange. 
        /// <para>
        /// Filter based on resource’s creation timestamp.
        /// </para>
        /// </summary>
        public DateRangeType CreatedRange
        {
            get { return this._createdRange; }
            set { this._createdRange = value; }
        }

        // Check to see if CreatedRange property is set
        internal bool IsSetCreatedRange()
        {
            return this._createdRange != null;
        }

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// Filter by labels using exact match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModifiedRange. 
        /// <para>
        /// Filter based on resource’s modified timestamp.
        /// </para>
        /// </summary>
        public DateRangeType ModifiedRange
        {
            get { return this._modifiedRange; }
            set { this._modifiedRange = value; }
        }

        // Check to see if ModifiedRange property is set
        internal bool IsSetModifiedRange()
        {
            return this._modifiedRange != null;
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// Filter based on UserIds or GroupIds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<SearchPrincipalType> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && (this._principals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// Filters based on entity type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=4)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SearchCollectionTypes. 
        /// <para>
        /// Filter based on file groupings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> SearchCollectionTypes
        {
            get { return this._searchCollectionTypes; }
            set { this._searchCollectionTypes = value; }
        }

        // Check to see if SearchCollectionTypes property is set
        internal bool IsSetSearchCollectionTypes()
        {
            return this._searchCollectionTypes != null && (this._searchCollectionTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SizeRange. 
        /// <para>
        /// Filter based on size (in bytes).
        /// </para>
        /// </summary>
        public LongRangeType SizeRange
        {
            get { return this._sizeRange; }
            set { this._sizeRange = value; }
        }

        // Check to see if SizeRange property is set
        internal bool IsSetSizeRange()
        {
            return this._sizeRange != null;
        }

        /// <summary>
        /// Gets and sets the property TextLocales. 
        /// <para>
        /// Filters by the locale of the content or comment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<string> TextLocales
        {
            get { return this._textLocales; }
            set { this._textLocales = value; }
        }

        // Check to see if TextLocales property is set
        internal bool IsSetTextLocales()
        {
            return this._textLocales != null && (this._textLocales.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}