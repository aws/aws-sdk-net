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
    /// The fraud prediction scores from Amazon SageMaker model.
    /// </summary>
    public partial class ExternalModelOutputs
    {
        private ExternalModelSummary _externalModel;
        private Dictionary<string, string> _outputs = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ExternalModel. 
        /// <para>
        /// The Amazon SageMaker model.
        /// </para>
        /// </summary>
        public ExternalModelSummary ExternalModel
        {
            get { return this._externalModel; }
            set { this._externalModel = value; }
        }

        // Check to see if ExternalModel property is set
        internal bool IsSetExternalModel()
        {
            return this._externalModel != null;
        }

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The fraud prediction scores from Amazon SageMaker model.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}