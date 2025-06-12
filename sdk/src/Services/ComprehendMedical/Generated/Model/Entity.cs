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
    /// Provides information about an extracted medical entity.
    /// </summary>
    public partial class Entity
    {
        private List<Attribute> _attributes = AWSConfigs.InitializeCollections ? new List<Attribute>() : null;
        private int? _beginOffset;
        private EntityType _category;
        private int? _endOffset;
        private int? _id;
        private float? _score;
        private string _text;
        private List<Trait> _traits = AWSConfigs.InitializeCollections ? new List<Trait>() : null;
        private EntitySubType _type;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        ///  The extracted attributes that relate to this entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Attribute> Attributes
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
        ///  The category of the entity.
        /// </para>
        /// </summary>
        public EntityType Category
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
        ///  The segment of input text extracted as this entity.
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
        /// Contextual information for the entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Trait> Traits
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
        ///  Describes the specific type of entity with category of entities.
        /// </para>
        /// </summary>
        public EntitySubType Type
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