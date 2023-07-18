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

namespace Amazon.ComprehendMedical.Model
{
    /// <summary>
    /// The extracted attributes that relate to this entity. The attributes recognized by
    /// InferRxNorm are <code>DOSAGE</code>, <code>DURATION</code>, <code>FORM</code>, <code>FREQUENCY</code>,
    /// <code>RATE</code>, <code>ROUTE_OR_MODE</code>.
    /// </summary>
    public partial class RxNormAttribute
    {
        private int? _beginOffset;
        private int? _endOffset;
        private int? _id;
        private float? _relationshipScore;
        private float? _score;
        private string _text;
        private List<RxNormTrait> _traits = new List<RxNormTrait>();
        private RxNormAttributeType _type;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The 0-based character offset in the input text that shows where the attribute begins.
        /// The offset returns the UTF-8 code point in the string.
        /// </para>
        /// </summary>
        public int BeginOffset
        {
            get { return this._beginOffset.GetValueOrDefault(); }
            set { this._beginOffset = value; }
        }

        // Check to see if BeginOffset property is set
        internal bool IsSetBeginOffset()
        {
            return this._beginOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The 0-based character offset in the input text that shows where the attribute ends.
        /// The offset returns the UTF-8 code point in the string.
        /// </para>
        /// </summary>
        public int EndOffset
        {
            get { return this._endOffset.GetValueOrDefault(); }
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
        /// The numeric identifier for this attribute. This is a monotonically increasing id unique
        /// within this response rather than a global unique identifier.
        /// </para>
        /// </summary>
        public int Id
        {
            get { return this._id.GetValueOrDefault(); }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelationshipScore. 
        /// <para>
        /// The level of confidence that Amazon Comprehend Medical has that the attribute is accurately
        /// linked to an entity.
        /// </para>
        /// </summary>
        public float RelationshipScore
        {
            get { return this._relationshipScore.GetValueOrDefault(); }
            set { this._relationshipScore = value; }
        }

        // Check to see if RelationshipScore property is set
        internal bool IsSetRelationshipScore()
        {
            return this._relationshipScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The level of confidence that Amazon Comprehend Medical has that the segment of text
        /// is correctly recognized as an attribute.
        /// </para>
        /// </summary>
        public float Score
        {
            get { return this._score.GetValueOrDefault(); }
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
        /// The segment of input text which corresponds to the detected attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Contextual information for the attribute. InferRxNorm recognizes the trait <code>NEGATION</code>
        /// for attributes, i.e. that the patient is not taking a specific dose or form of a medication.
        /// </para>
        /// </summary>
        public List<RxNormTrait> Traits
        {
            get { return this._traits; }
            set { this._traits = value; }
        }

        // Check to see if Traits property is set
        internal bool IsSetTraits()
        {
            return this._traits != null && this._traits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of attribute. The types of attributes recognized by InferRxNorm are <code>BRAND_NAME</code>
        /// and <code>GENERIC_NAME</code>.
        /// </para>
        /// </summary>
        public RxNormAttributeType Type
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