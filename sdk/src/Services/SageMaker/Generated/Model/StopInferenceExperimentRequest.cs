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
    /// Container for the parameters to the StopInferenceExperiment operation.
    /// Stops an inference experiment.
    /// </summary>
    public partial class StopInferenceExperimentRequest : AmazonSageMakerRequest
    {
        private List<ModelVariantConfig> _desiredModelVariants = new List<ModelVariantConfig>();
        private InferenceExperimentStopDesiredState _desiredState;
        private Dictionary<string, string> _modelVariantActions = new Dictionary<string, string>();
        private string _name;
        private string _reason;

        /// <summary>
        /// Gets and sets the property DesiredModelVariants. 
        /// <para>
        ///  Array of <code>ModelVariantConfig</code> objects. There is one for each variant that
        /// you want to deploy after the inference experiment stops. Each <code>ModelVariantConfig</code>
        /// describes the infrastructure configuration for deploying the corresponding variant.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<ModelVariantConfig> DesiredModelVariants
        {
            get { return this._desiredModelVariants; }
            set { this._desiredModelVariants = value; }
        }

        // Check to see if DesiredModelVariants property is set
        internal bool IsSetDesiredModelVariants()
        {
            return this._desiredModelVariants != null && this._desiredModelVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        ///  The desired state of the experiment after stopping. The possible states are the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Completed</code>: The experiment completed successfully
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Cancelled</code>: The experiment was canceled
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InferenceExperimentStopDesiredState DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVariantActions. 
        /// <para>
        ///  Array of key-value pairs, with names of variants mapped to actions. The possible
        /// actions are the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Promote</code> - Promote the shadow variant to a production variant
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Remove</code> - Delete the variant
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Retain</code> - Keep the variant as it is
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public Dictionary<string, string> ModelVariantActions
        {
            get { return this._modelVariantActions; }
            set { this._modelVariantActions = value; }
        }

        // Check to see if ModelVariantActions property is set
        internal bool IsSetModelVariantActions()
        {
            return this._modelVariantActions != null && this._modelVariantActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the inference experiment to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
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

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for stopping the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}