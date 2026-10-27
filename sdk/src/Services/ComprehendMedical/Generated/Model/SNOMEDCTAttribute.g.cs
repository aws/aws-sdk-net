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
    /// The extracted attributes that relate to an entity. An extracted segment of the text
    /// that is an attribute of an entity, or otherwise related to an entity, such as the
    /// dosage of a medication taken.
    /// </summary>
    public partial class SNOMEDCTAttribute
    {
        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        ///  The 0-based character offset in the input text that shows where the attribute begins.
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
        ///  The category of the detected attribute. Possible categories include MEDICAL_CONDITION,
        /// ANATOMY, and TEST_TREATMENT_PROCEDURE. 
        /// </para>
        /// </summary>
        public SNOMEDCTEntityCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        ///  The 0-based character offset in the input text that shows where the attribute ends.
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
        ///  The numeric identifier for this attribute. This is a monotonically increasing id
        /// unique within this response rather than a global unique identifier. 
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
        ///  The level of confidence that Amazon Comprehend Medical has that this attribute is
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
        ///  The type of relationship that exists between the entity and the related attribute.
        /// 
        /// </para>
        /// </summary>
        public SNOMEDCTRelationshipType RelationshipType { get; set; }

        /// <summary>
        /// Checks to see if the RelationshipType property is set.
        /// </summary>
        internal bool IsSetRelationshipType() => this.RelationshipType != null;

        /// <summary>
        /// Gets and sets the property SNOMEDCTConcepts. 
        /// <para>
        ///  The SNOMED-CT concepts specific to an attribute, along with a score indicating the
        /// likelihood of the match. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SNOMEDCTConcept> SNOMEDCTConcepts { get; set; } = AWSConfigs.InitializeCollections ? new List<SNOMEDCTConcept>() : null;

        /// <summary>
        /// Checks to see if the SNOMEDCTConcepts property is set.
        /// </summary>
        internal bool IsSetSNOMEDCTConcepts() => this.SNOMEDCTConcepts != null && (this.SNOMEDCTConcepts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        ///  The level of confidence that Amazon Comprehend Medical has that the segment of text
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
        ///  The segment of input text extracted as this attribute. 
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
        ///  Contextual information for an attribute. Examples include signs, symptoms, diagnosis,
        /// and negation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SNOMEDCTTrait> Traits { get; set; } = AWSConfigs.InitializeCollections ? new List<SNOMEDCTTrait>() : null;

        /// <summary>
        /// Checks to see if the Traits property is set.
        /// </summary>
        internal bool IsSetTraits() => this.Traits != null && (this.Traits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of attribute. Possible types include DX_NAME, ACUITY, DIRECTION, SYSTEM_ORGAN_SITE,TEST_NAME,
        /// TEST_VALUE, TEST_UNIT, PROCEDURE_NAME, and TREATMENT_NAME. 
        /// </para>
        /// </summary>
        public SNOMEDCTAttributeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
