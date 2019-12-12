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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The model input configuration.
    /// </summary>
    public partial class ModelInputConfiguration
    {
        private string _csvInputTemplate;
        private ModelInputDataFormat _format;
        private bool? _isOpaque;
        private string _jsonInputTemplate;

        /// <summary>
        /// Gets and sets the property CsvInputTemplate. 
        /// <para>
        ///  Template for constructing the CSV input-data sent to SageMaker. At event-evaluation,
        /// the placeholders for variable-names in the template will be replaced with the variable
        /// values before being sent to SageMaker. 
        /// </para>
        /// </summary>
        public string CsvInputTemplate
        {
            get { return this._csvInputTemplate; }
            set { this._csvInputTemplate = value; }
        }

        // Check to see if CsvInputTemplate property is set
        internal bool IsSetCsvInputTemplate()
        {
            return this._csvInputTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        ///  The format of the model input configuration. The format differs depending on if it
        /// is passed through to SageMaker or constructed by Amazon Fraud Detector.
        /// </para>
        /// </summary>
        public ModelInputDataFormat Format
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
        /// Gets and sets the property IsOpaque. 
        /// <para>
        ///  For an opaque-model, the input to the model will be a ByteBuffer blob provided in
        /// the getPrediction request, and will be passed to SageMaker as-is. For non-opaque models,
        /// the input will be constructed by Amazon Fraud Detector based on the model-configuration.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool IsOpaque
        {
            get { return this._isOpaque.GetValueOrDefault(); }
            set { this._isOpaque = value; }
        }

        // Check to see if IsOpaque property is set
        internal bool IsSetIsOpaque()
        {
            return this._isOpaque.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JsonInputTemplate. 
        /// <para>
        ///  Template for constructing the JSON input-data sent to SageMaker. At event-evaluation,
        /// the placeholders for variable names in the template will be replaced with the variable
        /// values before being sent to SageMaker. 
        /// </para>
        /// </summary>
        public string JsonInputTemplate
        {
            get { return this._jsonInputTemplate; }
            set { this._jsonInputTemplate = value; }
        }

        // Check to see if JsonInputTemplate property is set
        internal bool IsSetJsonInputTemplate()
        {
            return this._jsonInputTemplate != null;
        }

    }
}