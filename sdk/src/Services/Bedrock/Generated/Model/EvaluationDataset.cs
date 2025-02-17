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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Used to specify the name of a built-in prompt dataset and optionally, the Amazon S3
    /// bucket where a custom prompt dataset is saved.
    /// </summary>
    public partial class EvaluationDataset
    {
        private EvaluationDatasetLocation _datasetLocation;
        private string _name;

        /// <summary>
        /// Gets and sets the property DatasetLocation. 
        /// <para>
        /// For custom prompt datasets, you must specify the location in Amazon S3 where the prompt
        /// dataset is saved.
        /// </para>
        /// </summary>
        public EvaluationDatasetLocation DatasetLocation
        {
            get { return this._datasetLocation; }
            set { this._datasetLocation = value; }
        }

        // Check to see if DatasetLocation property is set
        internal bool IsSetDatasetLocation()
        {
            return this._datasetLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Used to specify supported built-in prompt datasets. Valid values are <c>Builtin.Bold</c>,
        /// <c>Builtin.BoolQ</c>, <c>Builtin.NaturalQuestions</c>, <c>Builtin.Gigaword</c>, <c>Builtin.RealToxicityPrompts</c>,
        /// <c>Builtin.TriviaQA</c>, <c>Builtin.T-Rex</c>, <c>Builtin.WomensEcommerceClothingReviews</c>
        /// and <c>Builtin.Wikitext2</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}