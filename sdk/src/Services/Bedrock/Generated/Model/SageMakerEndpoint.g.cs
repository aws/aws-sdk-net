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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Specifies the configuration for a Amazon SageMaker endpoint.
    /// </summary>
    public partial class SageMakerEndpoint
    {
        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The ARN of the IAM role that Amazon SageMaker can assume to access model artifacts
        /// and docker image for deployment on Amazon EC2 compute instances or for batch transform
        /// jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property InitialInstanceCount. 
        /// <para>
        /// The number of Amazon EC2 compute instances to deploy for initial endpoint creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? InitialInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InitialInstanceCount property is set.
        /// </summary>
        internal bool IsSetInitialInstanceCount() => this.InitialInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 compute instance type to deploy for hosting the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KmsEncryptionKey. 
        /// <para>
        /// The Amazon Web Services KMS key that Amazon SageMaker uses to encrypt data on the
        /// storage volume attached to the Amazon EC2 compute instance that hosts the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsEncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the KmsEncryptionKey property is set.
        /// </summary>
        internal bool IsSetKmsEncryptionKey() => this.KmsEncryptionKey != null;

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The VPC configuration for the endpoint.
        /// </para>
        /// </summary>
        public VpcConfig Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Vpc property is set.
        /// </summary>
        internal bool IsSetVpc() => this.Vpc != null;
    }
}
