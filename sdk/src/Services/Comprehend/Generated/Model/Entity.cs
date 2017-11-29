/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        private int? _endOffset;
        private float? _score;
        private string _text;
        private EntityType _type;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// A character offset in the input text that shows where the entity begins (the first
        /// character is at position 0). The offset returns the position of each UTF-8 code point
        /// in the string. A <i>code point</i> is the abstract character from a particular graphical
        /// representation. For example, a multi-byte UTF-8 character maps to a single code point.
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
        /// A character offset in the input text that shows where the entity ends. The offset
        /// returns the position of each UTF-8 code point in the string. A <i>code point</i> is
        /// the abstract character from a particular graphical representation. For example, a
        /// multi-byte UTF-8 character maps to a single code point. 
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
        /// The entity's type.
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