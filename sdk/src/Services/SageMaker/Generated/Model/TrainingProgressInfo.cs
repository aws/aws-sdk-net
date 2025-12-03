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
    /// The serverless training job progress information.
    /// </summary>
    public partial class TrainingProgressInfo
    {
        private long? _currentEpoch;
        private long? _currentStep;
        private long? _maxEpoch;
        private long? _totalStepCountPerEpoch;

        /// <summary>
        /// Gets and sets the property CurrentEpoch. 
        /// <para>
        ///  The current epoch number. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CurrentEpoch
        {
            get { return this._currentEpoch.GetValueOrDefault(); }
            set { this._currentEpoch = value; }
        }

        // Check to see if CurrentEpoch property is set
        internal bool IsSetCurrentEpoch()
        {
            return this._currentEpoch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentStep. 
        /// <para>
        ///  The current step number. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CurrentStep
        {
            get { return this._currentStep.GetValueOrDefault(); }
            set { this._currentStep = value; }
        }

        // Check to see if CurrentStep property is set
        internal bool IsSetCurrentStep()
        {
            return this._currentStep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxEpoch. 
        /// <para>
        ///  The maximum number of epochs for this job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long MaxEpoch
        {
            get { return this._maxEpoch.GetValueOrDefault(); }
            set { this._maxEpoch = value; }
        }

        // Check to see if MaxEpoch property is set
        internal bool IsSetMaxEpoch()
        {
            return this._maxEpoch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalStepCountPerEpoch. 
        /// <para>
        ///  The total step count per epoch. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long TotalStepCountPerEpoch
        {
            get { return this._totalStepCountPerEpoch.GetValueOrDefault(); }
            set { this._totalStepCountPerEpoch = value; }
        }

        // Check to see if TotalStepCountPerEpoch property is set
        internal bool IsSetTotalStepCountPerEpoch()
        {
            return this._totalStepCountPerEpoch.HasValue; 
        }

    }
}