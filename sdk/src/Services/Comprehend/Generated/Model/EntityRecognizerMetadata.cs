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
    /// Detailed information about an entity recognizer.
    /// </summary>
    public partial class EntityRecognizerMetadata
    {
        private List<EntityRecognizerMetadataEntityTypesListItem> _entityTypes = new List<EntityRecognizerMetadataEntityTypesListItem>();
        private EntityRecognizerEvaluationMetrics _evaluationMetrics;
        private int? _numberOfTestDocuments;
        private int? _numberOfTrainedDocuments;

        /// <summary>
        /// Gets and sets the property EntityTypes. 
        /// <para>
        /// Entity types from the metadata of an entity recognizer.
        /// </para>
        /// </summary>
        public List<EntityRecognizerMetadataEntityTypesListItem> EntityTypes
        {
            get { return this._entityTypes; }
            set { this._entityTypes = value; }
        }

        // Check to see if EntityTypes property is set
        internal bool IsSetEntityTypes()
        {
            return this._entityTypes != null && this._entityTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationMetrics. 
        /// <para>
        ///  Detailed information about the accuracy of an entity recognizer.
        /// </para>
        /// </summary>
        public EntityRecognizerEvaluationMetrics EvaluationMetrics
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
        /// Gets and sets the property NumberOfTestDocuments. 
        /// <para>
        ///  The number of documents in the input data that were used to test the entity recognizer.
        /// Typically this is 10 to 20 percent of the input documents.
        /// </para>
        /// </summary>
        public int NumberOfTestDocuments
        {
            get { return this._numberOfTestDocuments.GetValueOrDefault(); }
            set { this._numberOfTestDocuments = value; }
        }

        // Check to see if NumberOfTestDocuments property is set
        internal bool IsSetNumberOfTestDocuments()
        {
            return this._numberOfTestDocuments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfTrainedDocuments. 
        /// <para>
        ///  The number of documents in the input data that were used to train the entity recognizer.
        /// Typically this is 80 to 90 percent of the input documents.
        /// </para>
        /// </summary>
        public int NumberOfTrainedDocuments
        {
            get { return this._numberOfTrainedDocuments.GetValueOrDefault(); }
            set { this._numberOfTrainedDocuments = value; }
        }

        // Check to see if NumberOfTrainedDocuments property is set
        internal bool IsSetNumberOfTrainedDocuments()
        {
            return this._numberOfTrainedDocuments.HasValue; 
        }

    }
}