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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
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
    /// The collection of medical entities extracted from the input text and their associated
    /// information. For each entity, the response provides the entity text, the entity category,
    /// where the entity text begins and ends, and the level of confidence that Amazon Comprehend
    /// Medical has in the detection and analysis. Attributes and traits of the entity are
    /// also returned.
    /// </summary>
    public partial class ICD10CMEntity
    {
        private List<ICD10CMAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<ICD10CMAttribute>() : null;
        private int? _beginOffset;
        private ICD10CMEntityCategory _category;
        private int? _endOffset;
        private List<ICD10CMConcept> _icd10cmConcepts = AWSConfigs.InitializeCollections ? new List<ICD10CMConcept>() : null;
        private int? _id;
        private float? _score;
        private string _text;
        private List<ICD10CMTrait> _traits = AWSConfigs.InitializeCollections ? new List<ICD10CMTrait>() : null;
        private ICD10CMEntityType _type;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The detected attributes that relate to the entity. An extracted segment of the text
        /// that is an attribute of an entity, or otherwise related to an entity, such as the
        /// nature of a medical condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ICD10CMAttribute> Attributes
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
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The 0-based character offset in the input text that shows where the entity begins.
        /// The offset returns the UTF-8 code point in the string.
        /// </para>
        /// </summary>
        public int? BeginOffset
        {
            get { return this._beginOffset; }
            set { this._beginOffset = value; }
        }

        // Check to see if BeginOffset property is set
        internal bool IsSetBeginOffset()
        {
            return this._beginOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        ///  The category of the entity. InferICD10CM detects entities in the <c>MEDICAL_CONDITION</c>
        /// category. 
        /// </para>
        /// </summary>
        public ICD10CMEntityCategory Category
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
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The 0-based character offset in the input text that shows where the entity ends. The
        /// offset returns the UTF-8 code point in the string.
        /// </para>
        /// </summary>
        public int? EndOffset
        {
            get { return this._endOffset; }
            set { this._endOffset = value; }
        }

        // Check to see if EndOffset property is set
        internal bool IsSetEndOffset()
        {
            return this._endOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ICD10CMConcepts. 
        /// <para>
        /// The ICD-10-CM concepts that the entity could refer to, along with a score indicating
        /// the likelihood of the match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ICD10CMConcept> ICD10CMConcepts
        {
            get { return this._icd10cmConcepts; }
            set { this._icd10cmConcepts = value; }
        }

        // Check to see if ICD10CMConcepts property is set
        internal bool IsSetICD10CMConcepts()
        {
            return this._icd10cmConcepts != null && (this._icd10cmConcepts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The numeric identifier for the entity. This is a monotonically increasing id unique
        /// within this response rather than a global unique identifier.
        /// </para>
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The level of confidence that Amazon Comprehend Medical has in the accuracy of the
        /// detection.
        /// </para>
        /// </summary>
        public float? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The segment of input text that is matched to the detected entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property Traits. 
        /// <para>
        /// Provides Contextual information for the entity. The traits recognized by InferICD10CM
        /// are <c>DIAGNOSIS</c>, <c>SIGN</c>, <c>SYMPTOM</c>, and <c>NEGATION.</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ICD10CMTrait> Traits
        {
            get { return this._traits; }
            set { this._traits = value; }
        }

        // Check to see if Traits property is set
        internal bool IsSetTraits()
        {
            return this._traits != null && (this._traits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Describes the specific type of entity with category of entities. InferICD10CM detects
        /// entities of the type <c>DX_NAME</c> and <c>TIME_EXPRESSION</c>.
        /// </para>
        /// </summary>
        public ICD10CMEntityType Type
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