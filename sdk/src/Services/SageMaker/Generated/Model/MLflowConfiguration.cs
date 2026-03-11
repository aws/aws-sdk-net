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
    /// The MLflow configuration.
    /// </summary>
    public partial class MLflowConfiguration
    {
        private string _mlflowExperimentName;
        private string _mlflowResourceArn;

        /// <summary>
        /// Gets and sets the property MlflowExperimentName. 
        /// <para>
        ///  The name of the MLflow configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string MlflowExperimentName
        {
            get { return this._mlflowExperimentName; }
            set { this._mlflowExperimentName = value; }
        }

        // Check to see if MlflowExperimentName property is set
        internal bool IsSetMlflowExperimentName()
        {
            return this._mlflowExperimentName != null;
        }

        /// <summary>
        /// Gets and sets the property MlflowResourceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of MLflow configuration resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string MlflowResourceArn
        {
            get { return this._mlflowResourceArn; }
            set { this._mlflowResourceArn = value; }
        }

        // Check to see if MlflowResourceArn property is set
        internal bool IsSetMlflowResourceArn()
        {
            return this._mlflowResourceArn != null;
        }

    }
}