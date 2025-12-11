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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Configuration settings for synthetic data generation, including the parameters that
    /// control data synthesis and the evaluation scores that measure the quality and privacy
    /// characteristics of the generated synthetic data.
    /// </summary>
    public partial class SyntheticDataConfiguration
    {
        private SyntheticDataEvaluationScores _syntheticDataEvaluationScores;
        private MLSyntheticDataParameters _syntheticDataParameters;

        /// <summary>
        /// Gets and sets the property SyntheticDataEvaluationScores. 
        /// <para>
        /// Evaluation scores that assess the quality and privacy characteristics of the generated
        /// synthetic data, providing metrics on data utility and privacy preservation.
        /// </para>
        /// </summary>
        public SyntheticDataEvaluationScores SyntheticDataEvaluationScores
        {
            get { return this._syntheticDataEvaluationScores; }
            set { this._syntheticDataEvaluationScores = value; }
        }

        // Check to see if SyntheticDataEvaluationScores property is set
        internal bool IsSetSyntheticDataEvaluationScores()
        {
            return this._syntheticDataEvaluationScores != null;
        }

        /// <summary>
        /// Gets and sets the property SyntheticDataParameters. 
        /// <para>
        /// The parameters that control how synthetic data is generated, including privacy settings,
        /// column classifications, and other configuration options that affect the data synthesis
        /// process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MLSyntheticDataParameters SyntheticDataParameters
        {
            get { return this._syntheticDataParameters; }
            set { this._syntheticDataParameters = value; }
        }

        // Check to see if SyntheticDataParameters property is set
        internal bool IsSetSyntheticDataParameters()
        {
            return this._syntheticDataParameters != null;
        }

    }
}