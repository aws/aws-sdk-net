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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the relationship between generic data models.
    /// </summary>
    public partial class CodegenGenericDataRelationshipType
    {
        /// <summary>
        /// Gets and sets the property AssociatedFields. 
        /// <para>
        /// The associated fields of the data relationship.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedFields property is set.
        /// </summary>
        internal bool IsSetAssociatedFields() => this.AssociatedFields != null && (this.AssociatedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BelongsToFieldOnRelatedModel. 
        /// <para>
        /// The value of the <c>belongsTo</c> field on the related data model. 
        /// </para>
        /// </summary>
        public string BelongsToFieldOnRelatedModel { get; set; }

        /// <summary>
        /// Checks to see if the BelongsToFieldOnRelatedModel property is set.
        /// </summary>
        internal bool IsSetBelongsToFieldOnRelatedModel() => this.BelongsToFieldOnRelatedModel != null;

        /// <summary>
        /// Gets and sets the property CanUnlinkAssociatedModel. 
        /// <para>
        /// Specifies whether the relationship can unlink the associated model.
        /// </para>
        /// </summary>
        public bool? CanUnlinkAssociatedModel { get; set; }

        /// <summary>
        /// Checks to see if the CanUnlinkAssociatedModel property is set.
        /// </summary>
        internal bool IsSetCanUnlinkAssociatedModel() => this.CanUnlinkAssociatedModel.HasValue;

        /// <summary>
        /// Gets and sets the property IsHasManyIndex. 
        /// <para>
        /// Specifies whether the <c>@index</c> directive is supported for a <c>hasMany</c> data
        /// relationship.
        /// </para>
        /// </summary>
        public bool? IsHasManyIndex { get; set; }

        /// <summary>
        /// Checks to see if the IsHasManyIndex property is set.
        /// </summary>
        internal bool IsSetIsHasManyIndex() => this.IsHasManyIndex.HasValue;

        /// <summary>
        /// Gets and sets the property RelatedJoinFieldName. 
        /// <para>
        /// The name of the related join field in the data relationship.
        /// </para>
        /// </summary>
        public string RelatedJoinFieldName { get; set; }

        /// <summary>
        /// Checks to see if the RelatedJoinFieldName property is set.
        /// </summary>
        internal bool IsSetRelatedJoinFieldName() => this.RelatedJoinFieldName != null;

        /// <summary>
        /// Gets and sets the property RelatedJoinTableName. 
        /// <para>
        /// The name of the related join table in the data relationship.
        /// </para>
        /// </summary>
        public string RelatedJoinTableName { get; set; }

        /// <summary>
        /// Checks to see if the RelatedJoinTableName property is set.
        /// </summary>
        internal bool IsSetRelatedJoinTableName() => this.RelatedJoinTableName != null;

        /// <summary>
        /// Gets and sets the property RelatedModelFields. 
        /// <para>
        /// The related model fields in the data relationship.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RelatedModelFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RelatedModelFields property is set.
        /// </summary>
        internal bool IsSetRelatedModelFields() => this.RelatedModelFields != null && (this.RelatedModelFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelatedModelName. 
        /// <para>
        /// The name of the related model in the data relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelatedModelName { get; set; }

        /// <summary>
        /// Checks to see if the RelatedModelName property is set.
        /// </summary>
        internal bool IsSetRelatedModelName() => this.RelatedModelName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data relationship type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GenericDataRelationshipType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
