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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Stores the configuration information for how a candidate is generated (optional).
    /// </summary>
    public partial class AutoMLCandidateGenerationConfig
    {
        private List<AutoMLAlgorithmConfig> _algorithmsConfig = new List<AutoMLAlgorithmConfig>();
        private string _featureSpecificationS3Uri;

        /// <summary>
        /// Gets and sets the property AlgorithmsConfig. 
        /// <para>
        /// Stores the configuration information for the selection of algorithms used to train
        /// the model candidates.
        /// </para>
        ///  
        /// <para>
        /// The list of available algorithms to choose from depends on the training mode set in
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLJobConfig.html">
        /// <code>AutoMLJobConfig.Mode</code> </a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmsConfig</code> should not be set in <code>AUTO</code> training mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <code>AlgorithmsConfig</code> is provided, one <code>AutoMLAlgorithms</code>
        /// attribute must be set and one only.
        /// </para>
        ///  
        /// <para>
        /// If the list of algorithms provided as values for <code>AutoMLAlgorithms</code> is
        /// empty, <code>AutoMLCandidateGenerationConfig</code> uses the full set of algorithms
        /// for the given training mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <code>AlgorithmsConfig</code> is not provided, <code>AutoMLCandidateGenerationConfig</code>
        /// uses the full set of algorithms for the given training mode.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the list of all algorithms per training mode, see .
        /// </para>
        ///  
        /// <para>
        /// For more information on each algorithm, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-algorithm-support">Algorithm
        /// support</a> section in Autopilot developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<AutoMLAlgorithmConfig> AlgorithmsConfig
        {
            get { return this._algorithmsConfig; }
            set { this._algorithmsConfig = value; }
        }

        // Check to see if AlgorithmsConfig property is set
        internal bool IsSetAlgorithmsConfig()
        {
            return this._algorithmsConfig != null && this._algorithmsConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FeatureSpecificationS3Uri. 
        /// <para>
        /// A URL to the Amazon S3 data source containing selected features from the input data
        /// source to run an Autopilot job. You can input <code>FeatureAttributeNames</code> (optional)
        /// in JSON format as shown below: 
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "FeatureAttributeNames":["col1", "col2", ...] }</code>.
        /// </para>
        ///  
        /// <para>
        /// You can also specify the data type of the feature (optional) in the format shown below:
        /// </para>
        ///  
        /// <para>
        ///  <code>{ "FeatureDataTypes":{"col1":"numeric", "col2":"categorical" ... } }</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// These column keys may not include the target column.
        /// </para>
        ///  </note> 
        /// <para>
        /// In ensembling mode, Autopilot only supports the following data types: <code>numeric</code>,
        /// <code>categorical</code>, <code>text</code>, and <code>datetime</code>. In HPO mode,
        /// Autopilot can support <code>numeric</code>, <code>categorical</code>, <code>text</code>,
        /// <code>datetime</code>, and <code>sequence</code>.
        /// </para>
        ///  
        /// <para>
        /// If only <code>FeatureDataTypes</code> is provided, the column keys (<code>col1</code>,
        /// <code>col2</code>,..) should be a subset of the column names in the input data. 
        /// </para>
        ///  
        /// <para>
        /// If both <code>FeatureDataTypes</code> and <code>FeatureAttributeNames</code> are provided,
        /// then the column keys should be a subset of the column names provided in <code>FeatureAttributeNames</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The key name <code>FeatureAttributeNames</code> is fixed. The values listed in <code>["col1",
        /// "col2", ...]</code> are case sensitive and should be a list of strings containing
        /// unique values that are a subset of the column names in the input data. The list of
        /// columns provided must not include the target column.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string FeatureSpecificationS3Uri
        {
            get { return this._featureSpecificationS3Uri; }
            set { this._featureSpecificationS3Uri = value; }
        }

        // Check to see if FeatureSpecificationS3Uri property is set
        internal bool IsSetFeatureSpecificationS3Uri()
        {
            return this._featureSpecificationS3Uri != null;
        }

    }
}