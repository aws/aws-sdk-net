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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the relationship between generic data models.
    /// </summary>
    public partial class CodegenGenericDataRelationshipType
    {
        private List<string> _associatedFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _belongsToFieldOnRelatedModel;
        private bool? _canUnlinkAssociatedModel;
        private bool? _isHasManyIndex;
        private string _relatedJoinFieldName;
        private string _relatedJoinTableName;
        private List<string> _relatedModelFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _relatedModelName;
        private GenericDataRelationshipType _type;

        /// <summary>
        /// Gets and sets the property AssociatedFields. 
        /// <para>
        /// The associated fields of the data relationship.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedFields
        {
            get { return this._associatedFields; }
            set { this._associatedFields = value; }
        }

        // Check to see if AssociatedFields property is set
        internal bool IsSetAssociatedFields()
        {
            return this._associatedFields != null && (this._associatedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BelongsToFieldOnRelatedModel. 
        /// <para>
        /// The value of the <c>belongsTo</c> field on the related data model. 
        /// </para>
        /// </summary>
        public string BelongsToFieldOnRelatedModel
        {
            get { return this._belongsToFieldOnRelatedModel; }
            set { this._belongsToFieldOnRelatedModel = value; }
        }

        // Check to see if BelongsToFieldOnRelatedModel property is set
        internal bool IsSetBelongsToFieldOnRelatedModel()
        {
            return this._belongsToFieldOnRelatedModel != null;
        }

        /// <summary>
        /// Gets and sets the property CanUnlinkAssociatedModel. 
        /// <para>
        /// Specifies whether the relationship can unlink the associated model.
        /// </para>
        /// </summary>
        public bool? CanUnlinkAssociatedModel
        {
            get { return this._canUnlinkAssociatedModel; }
            set { this._canUnlinkAssociatedModel = value; }
        }

        // Check to see if CanUnlinkAssociatedModel property is set
        internal bool IsSetCanUnlinkAssociatedModel()
        {
            return this._canUnlinkAssociatedModel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsHasManyIndex. 
        /// <para>
        /// Specifies whether the <c>@index</c> directive is supported for a <c>hasMany</c> data
        /// relationship.
        /// </para>
        /// </summary>
        public bool? IsHasManyIndex
        {
            get { return this._isHasManyIndex; }
            set { this._isHasManyIndex = value; }
        }

        // Check to see if IsHasManyIndex property is set
        internal bool IsSetIsHasManyIndex()
        {
            return this._isHasManyIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelatedJoinFieldName. 
        /// <para>
        /// The name of the related join field in the data relationship.
        /// </para>
        /// </summary>
        public string RelatedJoinFieldName
        {
            get { return this._relatedJoinFieldName; }
            set { this._relatedJoinFieldName = value; }
        }

        // Check to see if RelatedJoinFieldName property is set
        internal bool IsSetRelatedJoinFieldName()
        {
            return this._relatedJoinFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedJoinTableName. 
        /// <para>
        /// The name of the related join table in the data relationship.
        /// </para>
        /// </summary>
        public string RelatedJoinTableName
        {
            get { return this._relatedJoinTableName; }
            set { this._relatedJoinTableName = value; }
        }

        // Check to see if RelatedJoinTableName property is set
        internal bool IsSetRelatedJoinTableName()
        {
            return this._relatedJoinTableName != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedModelFields. 
        /// <para>
        /// The related model fields in the data relationship.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RelatedModelFields
        {
            get { return this._relatedModelFields; }
            set { this._relatedModelFields = value; }
        }

        // Check to see if RelatedModelFields property is set
        internal bool IsSetRelatedModelFields()
        {
            return this._relatedModelFields != null && (this._relatedModelFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RelatedModelName. 
        /// <para>
        /// The name of the related model in the data relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelatedModelName
        {
            get { return this._relatedModelName; }
            set { this._relatedModelName = value; }
        }

        // Check to see if RelatedModelName property is set
        internal bool IsSetRelatedModelName()
        {
            return this._relatedModelName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data relationship type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GenericDataRelationshipType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}