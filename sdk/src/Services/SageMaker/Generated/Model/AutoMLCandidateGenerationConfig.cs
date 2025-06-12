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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Stores the configuration information for how a candidate is generated (optional).
    /// </summary>
    public partial class AutoMLCandidateGenerationConfig
    {
        private List<AutoMLAlgorithmConfig> _algorithmsConfig = AWSConfigs.InitializeCollections ? new List<AutoMLAlgorithmConfig>() : null;
        private string _featureSpecificationS3Uri;

        /// <summary>
        /// Gets and sets the property AlgorithmsConfig. 
        /// <para>
        /// Stores the configuration information for the selection of algorithms trained on tabular
        /// data.
        /// </para>
        ///  
        /// <para>
        /// The list of available algorithms to choose from depends on the training mode set in
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TabularJobConfig.html">
        /// <c>TabularJobConfig.Mode</c> </a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AlgorithmsConfig</c> should not be set if the training mode is set on <c>AUTO</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>AlgorithmsConfig</c> is provided, one <c>AutoMLAlgorithms</c> attribute must
        /// be set and one only.
        /// </para>
        ///  
        /// <para>
        /// If the list of algorithms provided as values for <c>AutoMLAlgorithms</c> is empty,
        /// <c>CandidateGenerationConfig</c> uses the full set of algorithms for the given training
        /// mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>AlgorithmsConfig</c> is not provided, <c>CandidateGenerationConfig</c> uses
        /// the full set of algorithms for the given training mode.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For the list of all algorithms per problem type and training mode, see <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLAlgorithmConfig.html">
        /// AutoMLAlgorithmConfig</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information on each algorithm, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-algorithm-support">Algorithm
        /// support</a> section in Autopilot developer guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<AutoMLAlgorithmConfig> AlgorithmsConfig
        {
            get { return this._algorithmsConfig; }
            set { this._algorithmsConfig = value; }
        }

        // Check to see if AlgorithmsConfig property is set
        internal bool IsSetAlgorithmsConfig()
        {
            return this._algorithmsConfig != null && (this._algorithmsConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeatureSpecificationS3Uri. 
        /// <para>
        /// A URL to the Amazon S3 data source containing selected features from the input data
        /// source to run an Autopilot job. You can input <c>FeatureAttributeNames</c> (optional)
        /// in JSON format as shown below: 
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "FeatureAttributeNames":["col1", "col2", ...] }</c>.
        /// </para>
        ///  
        /// <para>
        /// You can also specify the data type of the feature (optional) in the format shown below:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "FeatureDataTypes":{"col1":"numeric", "col2":"categorical" ... } }</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// These column keys may not include the target column.
        /// </para>
        ///  </note> 
        /// <para>
        /// In ensembling mode, Autopilot only supports the following data types: <c>numeric</c>,
        /// <c>categorical</c>, <c>text</c>, and <c>datetime</c>. In HPO mode, Autopilot can support
        /// <c>numeric</c>, <c>categorical</c>, <c>text</c>, <c>datetime</c>, and <c>sequence</c>.
        /// </para>
        ///  
        /// <para>
        /// If only <c>FeatureDataTypes</c> is provided, the column keys (<c>col1</c>, <c>col2</c>,..)
        /// should be a subset of the column names in the input data. 
        /// </para>
        ///  
        /// <para>
        /// If both <c>FeatureDataTypes</c> and <c>FeatureAttributeNames</c> are provided, then
        /// the column keys should be a subset of the column names provided in <c>FeatureAttributeNames</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The key name <c>FeatureAttributeNames</c> is fixed. The values listed in <c>["col1",
        /// "col2", ...]</c> are case sensitive and should be a list of strings containing unique
        /// values that are a subset of the column names in the input data. The list of columns
        /// provided must not include the target column.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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