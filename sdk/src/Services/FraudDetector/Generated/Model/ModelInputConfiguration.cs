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
    /// The Amazon SageMaker model input configuration.
    /// </summary>
    public partial class ModelInputConfiguration
    {
        private string _csvInputTemplate;
        private string _eventTypeName;
        private ModelInputDataFormat _format;
        private string _jsonInputTemplate;
        private bool? _useEventVariables;

        /// <summary>
        /// Gets and sets the property CsvInputTemplate. 
        /// <para>
        ///  Template for constructing the CSV input-data sent to SageMaker. At event-evaluation,
        /// the placeholders for variable-names in the template will be replaced with the variable
        /// values before being sent to SageMaker. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The event type name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EventTypeName
        {
            get { return this._eventTypeName; }
            set { this._eventTypeName = value; }
        }

        // Check to see if EventTypeName property is set
        internal bool IsSetEventTypeName()
        {
            return this._eventTypeName != null;
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
        /// Gets and sets the property JsonInputTemplate. 
        /// <para>
        ///  Template for constructing the JSON input-data sent to SageMaker. At event-evaluation,
        /// the placeholders for variable names in the template will be replaced with the variable
        /// values before being sent to SageMaker. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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

        /// <summary>
        /// Gets and sets the property UseEventVariables. 
        /// <para>
        /// The event variables.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? UseEventVariables
        {
            get { return this._useEventVariables; }
            set { this._useEventVariables = value; }
        }

        // Check to see if UseEventVariables property is set
        internal bool IsSetUseEventVariables()
        {
            return this._useEventVariables.HasValue; 
        }

    }
}