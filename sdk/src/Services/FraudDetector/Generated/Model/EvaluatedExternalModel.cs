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
    /// The details of the external (Amazon Sagemaker) model evaluated for generating predictions.
    /// </summary>
    public partial class EvaluatedExternalModel
    {
        private Dictionary<string, string> _inputVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _modelEndpoint;
        private Dictionary<string, string> _outputVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _useEventVariables;

        /// <summary>
        /// Gets and sets the property InputVariables. 
        /// <para>
        ///  Input variables use for generating predictions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> InputVariables
        {
            get { return this._inputVariables; }
            set { this._inputVariables = value; }
        }

        // Check to see if InputVariables property is set
        internal bool IsSetInputVariables()
        {
            return this._inputVariables != null && (this._inputVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelEndpoint. 
        /// <para>
        ///  The endpoint of the external (Amazon Sagemaker) model. 
        /// </para>
        /// </summary>
        public string ModelEndpoint
        {
            get { return this._modelEndpoint; }
            set { this._modelEndpoint = value; }
        }

        // Check to see if ModelEndpoint property is set
        internal bool IsSetModelEndpoint()
        {
            return this._modelEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property OutputVariables. 
        /// <para>
        ///  Output variables. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> OutputVariables
        {
            get { return this._outputVariables; }
            set { this._outputVariables = value; }
        }

        // Check to see if OutputVariables property is set
        internal bool IsSetOutputVariables()
        {
            return this._outputVariables != null && (this._outputVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UseEventVariables. 
        /// <para>
        ///  Indicates whether event variables were used to generate predictions. 
        /// </para>
        /// </summary>
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