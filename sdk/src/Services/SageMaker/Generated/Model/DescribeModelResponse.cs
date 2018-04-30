/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeModel operation.
    /// </summary>
    public partial class DescribeModelResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _executionRoleArn;
        private string _modelArn;
        private string _modelName;
        private ContainerDefinition _primaryContainer;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the model was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that you specified for the model.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model.
        /// </para>
        /// </summary>
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// Name of the Amazon SageMaker model.
        /// </para>
        /// </summary>
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryContainer. 
        /// <para>
        /// The location of the primary inference code, associated artifacts, and custom environment
        /// map that the inference code uses when it is deployed in production. 
        /// </para>
        /// </summary>
        public ContainerDefinition PrimaryContainer
        {
            get { return this._primaryContainer; }
            set { this._primaryContainer = value; }
        }

        // Check to see if PrimaryContainer property is set
        internal bool IsSetPrimaryContainer()
        {
            return this._primaryContainer != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// A object that specifies the VPC that this model has access to. For more information,
        /// see <a>host-vpc</a> 
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}