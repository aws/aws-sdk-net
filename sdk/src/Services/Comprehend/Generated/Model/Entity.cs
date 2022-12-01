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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Provides information about an entity. 
    /// 
    ///  
    /// <para>
    ///  
    /// </para>
    /// </summary>
    public partial class Entity
    {
        private int? _beginOffset;
        private List<BlockReference> _blockReferences = new List<BlockReference>();
        private int? _endOffset;
        private float? _score;
        private string _text;
        private EntityType _type;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The zero-based offset from the beginning of the source text to the first character
        /// in the entity.
        /// </para>
        ///  
        /// <para>
        /// This field is empty for non-text input.
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
        /// Gets and sets the property BlockReferences. 
        /// <para>
        /// A reference to each block for this entity. This field is empty for plain-text input.
        /// </para>
        /// </summary>
        public List<BlockReference> BlockReferences
        {
            get { return this._blockReferences; }
            set { this._blockReferences = value; }
        }

        // Check to see if BlockReferences property is set
        internal bool IsSetBlockReferences()
        {
            return this._blockReferences != null && this._blockReferences.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The zero-based offset from the beginning of the source text to the last character
        /// in the entity.
        /// </para>
        ///  
        /// <para>
        /// This field is empty for non-text input.
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
        /// Gets and sets the property Score. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of the detection.
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
        /// The text of the entity.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The entity type. For entity detection using the built-in model, this field contains
        /// one of the standard entity types listed below.
        /// </para>
        ///  
        /// <para>
        /// For custom entity detection, this field contains one of the entity types that you
        /// specified when you trained your custom model.
        /// </para>
        /// </summary>
        public EntityType Type
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