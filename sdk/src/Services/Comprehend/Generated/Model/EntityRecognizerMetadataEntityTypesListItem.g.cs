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
    /// Individual item from the list of entity types in the metadata of an entity recognizer.
    /// </summary>
    public partial class EntityRecognizerMetadataEntityTypesListItem
    {
        /// <summary>
        /// Gets and sets the property EvaluationMetrics. 
        /// <para>
        /// Detailed information about the accuracy of the entity recognizer for a specific item
        /// on the list of entity types. 
        /// </para>
        /// </summary>
        public EntityTypesEvaluationMetrics EvaluationMetrics { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationMetrics property is set.
        /// </summary>
        internal bool IsSetEvaluationMetrics() => this.EvaluationMetrics != null;

        /// <summary>
        /// Gets and sets the property NumberOfTrainMentions. 
        /// <para>
        /// Indicates the number of times the given entity type was seen in the training data.
        /// 
        /// </para>
        /// </summary>
        public int? NumberOfTrainMentions { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfTrainMentions property is set.
        /// </summary>
        internal bool IsSetNumberOfTrainMentions() => this.NumberOfTrainMentions.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of entity from the list of entity types in the metadata of an entity recognizer.
        /// 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
