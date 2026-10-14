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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The MLflow tracking configuration for logging metrics and parameters to a SageMaker
    /// managed MLflow tracking server.
    /// </summary>
    public partial class AIMlflowConfig
    {
        /// <summary>
        /// Gets and sets the property MlflowExperimentName. 
        /// <para>
        /// The MLflow experiment name used for tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MlflowExperimentName { get; set; }

        /// <summary>
        /// Checks to see if the MlflowExperimentName property is set.
        /// </summary>
        internal bool IsSetMlflowExperimentName() => this.MlflowExperimentName != null;

        /// <summary>
        /// Gets and sets the property MlflowResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker managed MLflow resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string MlflowResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the MlflowResourceArn property is set.
        /// </summary>
        internal bool IsSetMlflowResourceArn() => this.MlflowResourceArn != null;

        /// <summary>
        /// Gets and sets the property MlflowRunName. 
        /// <para>
        /// The MLflow run name used for tracking.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MlflowRunName { get; set; }

        /// <summary>
        /// Checks to see if the MlflowRunName property is set.
        /// </summary>
        internal bool IsSetMlflowRunName() => this.MlflowRunName != null;
    }
}
