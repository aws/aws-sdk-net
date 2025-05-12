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
    /// The configurations and outcomes of an Amazon EMR step execution.
    /// </summary>
    public partial class EMRStepMetadata
    {
        private string _clusterId;
        private string _logFilePath;
        private string _stepId;
        private string _stepName;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier of the EMR cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property LogFilePath. 
        /// <para>
        /// The path to the log file where the cluster step's failure root cause is recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LogFilePath
        {
            get { return this._logFilePath; }
            set { this._logFilePath = value; }
        }

        // Check to see if LogFilePath property is set
        internal bool IsSetLogFilePath()
        {
            return this._logFilePath != null;
        }

        /// <summary>
        /// Gets and sets the property StepId. 
        /// <para>
        /// The identifier of the EMR cluster step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string StepId
        {
            get { return this._stepId; }
            set { this._stepId = value; }
        }

        // Check to see if StepId property is set
        internal bool IsSetStepId()
        {
            return this._stepId != null;
        }

        /// <summary>
        /// Gets and sets the property StepName. 
        /// <para>
        /// The name of the EMR cluster step.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string StepName
        {
            get { return this._stepName; }
            set { this._stepName = value; }
        }

        // Check to see if StepName property is set
        internal bool IsSetStepName()
        {
            return this._stepName != null;
        }

    }
}