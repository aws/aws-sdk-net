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
    public partial class SNOMEDCTEntity
    {
        private List<SNOMEDCTAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<SNOMEDCTAttribute>() : null;
        private int? _beginOffset;
        private SNOMEDCTEntityCategory _category;
        private int? _endOffset;
        private int? _id;
        private float? _score;
        private List<SNOMEDCTConcept> _snomedctConcepts = AWSConfigs.InitializeCollections ? new List<SNOMEDCTConcept>() : null;
        private string _text;
        private List<SNOMEDCTTrait> _traits = AWSConfigs.InitializeCollections ? new List<SNOMEDCTTrait>() : null;
        private SNOMEDCTEntityType _type;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  An extracted segment of the text that is an attribute of an entity, or otherwise
        /// related to an entity, such as the dosage of a medication taken. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SNOMEDCTAttribute> Attributes
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
        ///  The 0-based character offset in the input text that shows where the entity begins.
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
        ///  The category of the detected entity. Possible categories are MEDICAL_CONDITION, ANATOMY,
        /// or TEST_TREATMENT_PROCEDURE. 
        /// </para>
        /// </summary>
        public SNOMEDCTEntityCategory Category
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
        ///  The 0-based character offset in the input text that shows where the entity ends.
        /// The offset returns the UTF-8 code point in the string. 
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
        /// Gets and sets the property Id. 
        /// <para>
        ///  The numeric identifier for the entity. This is a monotonically increasing id unique
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
        ///  The level of confidence that Amazon Comprehend Medical has in the accuracy of the
        /// detected entity. 
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
        /// Gets and sets the property SNOMEDCTConcepts. 
        /// <para>
        ///  The SNOMED concepts that the entity could refer to, along with a score indicating
        /// the likelihood of the match. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SNOMEDCTConcept> SNOMEDCTConcepts
        {
            get { return this._snomedctConcepts; }
            set { this._snomedctConcepts = value; }
        }

        // Check to see if SNOMEDCTConcepts property is set
        internal bool IsSetSNOMEDCTConcepts()
        {
            return this._snomedctConcepts != null && (this._snomedctConcepts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        ///  The segment of input text extracted as this entity. 
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
        ///  Contextual information for the entity. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SNOMEDCTTrait> Traits
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
        ///  Describes the specific type of entity with category of entities. Possible types include
        /// DX_NAME, ACUITY, DIRECTION, SYSTEM_ORGAN_SITE, TEST_NAME, TEST_VALUE, TEST_UNIT, PROCEDURE_NAME,
        /// or TREATMENT_NAME. 
        /// </para>
        /// </summary>
        public SNOMEDCTEntityType Type
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