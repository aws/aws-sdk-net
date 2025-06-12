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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Provides the Amazon Sagemaker model output configuration.
    /// </summary>
    public partial class ModelOutputConfiguration
    {
        private Dictionary<string, string> _csvIndexToVariableMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ModelOutputDataFormat _format;
        private Dictionary<string, string> _jsonKeyToVariableMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CsvIndexToVariableMap. 
        /// <para>
        /// A map of CSV index values in the SageMaker response to the Amazon Fraud Detector variables.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> CsvIndexToVariableMap
        {
            get { return this._csvIndexToVariableMap; }
            set { this._csvIndexToVariableMap = value; }
        }

        // Check to see if CsvIndexToVariableMap property is set
        internal bool IsSetCsvIndexToVariableMap()
        {
            return this._csvIndexToVariableMap != null && (this._csvIndexToVariableMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the model output configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelOutputDataFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property JsonKeyToVariableMap. 
        /// <para>
        /// A map of JSON keys in response from SageMaker to the Amazon Fraud Detector variables.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> JsonKeyToVariableMap
        {
            get { return this._jsonKeyToVariableMap; }
            set { this._jsonKeyToVariableMap = value; }
        }

        // Check to see if JsonKeyToVariableMap property is set
        internal bool IsSetJsonKeyToVariableMap()
        {
            return this._jsonKeyToVariableMap != null && (this._jsonKeyToVariableMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}