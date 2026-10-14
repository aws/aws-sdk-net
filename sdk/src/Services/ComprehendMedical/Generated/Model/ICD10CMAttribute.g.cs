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

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// The detected attributes that relate to an entity. This includes an extracted segment
    /// of the text that is an attribute of an entity, or otherwise related to an entity.
    /// InferICD10CM detects the following attributes: <c>Direction</c>, <c>System, Organ
    /// or Site</c>, and <c>Acuity</c>.
    /// </summary>
    public partial class ICD10CMAttribute
    {
        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The 0-based character offset in the input text that shows where the attribute begins.
        /// The offset returns the UTF-8 code point in the string.
        /// </para>
        /// </summary>
        public int? BeginOffset { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffset property is set.
        /// </summary>
        internal bool IsSetBeginOffset() => this.BeginOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of attribute. Can be either of <c>DX_NAME</c> or <c>TIME_EXPRESSION</c>.
        /// </para>
        /// </summary>
        public ICD10CMEntityType Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The 0-based character offset in the input text that shows where the attribute ends.
        /// The offset returns the UTF-8 code point in the string.
        /// </para>
        /// </summary>
        public int? EndOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndOffset property is set.
        /// </summary>
        internal bool IsSetEndOffset() => this.EndOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The numeric identifier for this attribute. This is a monotonically increasing id unique
        /// within this response rather than a global unique identifier.
        /// </para>
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id.HasValue;

        /// <summary>
        /// Gets and sets the property RelationshipScore. 
        /// <para>
        /// The level of confidence that Amazon Comprehend Medical has that this attribute is
        /// correctly related to this entity.
        /// </para>
        /// </summary>
        public float? RelationshipScore { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipScore property is set.
        /// </summary>
        internal bool IsSetRelationshipScore() => this.RelationshipScore.HasValue;

        /// <summary>
        /// Gets and sets the property RelationshipType. 
        /// <para>
        /// The type of relationship between the entity and attribute. Type for the relationship
        /// can be either of <c>OVERLAP</c> or <c>SYSTEM_ORGAN_SITE</c>.
        /// </para>
        /// </summary>
        public ICD10CMRelationshipType RelationshipType { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipType property is set.
        /// </summary>
        internal bool IsSetRelationshipType() => this.RelationshipType != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The level of confidence that Amazon Comprehend Medical has that the segment of text
        /// is correctly recognized as an attribute.
        /// </para>
        /// </summary>
        public float? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The segment of input text which contains the detected attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property Traits. 
        /// <para>
        /// The contextual information for the attribute. The traits recognized by InferICD10CM
        /// are <c>DIAGNOSIS</c>, <c>SIGN</c>, <c>SYMPTOM</c>, and <c>NEGATION</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ICD10CMTrait> Traits { get; set; } = AWSConfigs.InitializeCollections ? new List<ICD10CMTrait>() : null;

        /// <summary>
        /// Checks to see if the Traits property is set.
        /// </summary>
        internal bool IsSetTraits() => this.Traits != null && (this.Traits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of attribute. InferICD10CM detects entities of the type <c>DX_NAME</c>. 
        /// </para>
        /// </summary>
        public ICD10CMAttributeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
