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
        public int? BeginOffset { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffset property is set.
        /// </summary>
        internal bool IsSetBeginOffset() => this.BeginOffset.HasValue;

        /// <summary>
        /// Gets and sets the property BlockReferences. 
        /// <para>
        /// A reference to each block for this entity. This field is empty for plain-text input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockReference> BlockReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<BlockReference>() : null;

        /// <summary>
        /// Checks to see if the BlockReferences property is set.
        /// </summary>
        internal bool IsSetBlockReferences() => this.BlockReferences != null && (this.BlockReferences.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public int? EndOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndOffset property is set.
        /// </summary>
        internal bool IsSetEndOffset() => this.EndOffset.HasValue;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The level of confidence that Amazon Comprehend has in the accuracy of the detection.
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
        /// The text of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

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
        public EntityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
