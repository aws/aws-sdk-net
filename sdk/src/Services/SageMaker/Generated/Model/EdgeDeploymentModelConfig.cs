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
    /// Contains information about the configuration of a model in a deployment.
    /// </summary>
    public partial class EdgeDeploymentModelConfig
    {
        private string _edgePackagingJobName;
        private string _modelHandle;

        /// <summary>
        /// Gets and sets the property EdgePackagingJobName. 
        /// <para>
        /// The edge packaging job associated with this deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgePackagingJobName
        {
            get { return this._edgePackagingJobName; }
            set { this._edgePackagingJobName = value; }
        }

        // Check to see if EdgePackagingJobName property is set
        internal bool IsSetEdgePackagingJobName()
        {
            return this._edgePackagingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelHandle. 
        /// <para>
        /// The name the device application uses to reference this model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelHandle
        {
            get { return this._modelHandle; }
            set { this._modelHandle = value; }
        }

        // Check to see if ModelHandle property is set
        internal bool IsSetModelHandle()
        {
            return this._modelHandle != null;
        }

    }
}