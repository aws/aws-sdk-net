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
    /// The MLflow details of this job.
    /// </summary>
    public partial class MlflowDetails
    {
        private string _mlflowExperimentId;
        private string _mlflowRunId;

        /// <summary>
        /// Gets and sets the property MlflowExperimentId. 
        /// <para>
        ///  The MLflow experiment ID used for this job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MlflowExperimentId
        {
            get { return this._mlflowExperimentId; }
            set { this._mlflowExperimentId = value; }
        }

        // Check to see if MlflowExperimentId property is set
        internal bool IsSetMlflowExperimentId()
        {
            return this._mlflowExperimentId != null;
        }

        /// <summary>
        /// Gets and sets the property MlflowRunId. 
        /// <para>
        ///  The MLflow run ID used for this job. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MlflowRunId
        {
            get { return this._mlflowRunId; }
            set { this._mlflowRunId = value; }
        }

        // Check to see if MlflowRunId property is set
        internal bool IsSetMlflowRunId()
        {
            return this._mlflowRunId != null;
        }

    }
}