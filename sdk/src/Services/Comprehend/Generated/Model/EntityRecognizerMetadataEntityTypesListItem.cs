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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Individual item from the list of entity types in the metadata of an entity recognizer.
    /// </summary>
    public partial class EntityRecognizerMetadataEntityTypesListItem
    {
        private EntityTypesEvaluationMetrics _evaluationMetrics;
        private int? _numberOfTrainMentions;
        private string _type;

        /// <summary>
        /// Gets and sets the property EvaluationMetrics. 
        /// <para>
        /// Detailed information about the accuracy of the entity recognizer for a specific item
        /// on the list of entity types. 
        /// </para>
        /// </summary>
        public EntityTypesEvaluationMetrics EvaluationMetrics
        {
            get { return this._evaluationMetrics; }
            set { this._evaluationMetrics = value; }
        }

        // Check to see if EvaluationMetrics property is set
        internal bool IsSetEvaluationMetrics()
        {
            return this._evaluationMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfTrainMentions. 
        /// <para>
        /// Indicates the number of times the given entity type was seen in the training data.
        /// 
        /// </para>
        /// </summary>
        public int? NumberOfTrainMentions
        {
            get { return this._numberOfTrainMentions; }
            set { this._numberOfTrainMentions = value; }
        }

        // Check to see if NumberOfTrainMentions property is set
        internal bool IsSetNumberOfTrainMentions()
        {
            return this._numberOfTrainMentions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of entity from the list of entity types in the metadata of an entity recognizer.
        /// 
        /// </para>
        /// </summary>
        public string Type
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