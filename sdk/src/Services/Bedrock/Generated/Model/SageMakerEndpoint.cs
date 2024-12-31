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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private string _executionRole;
        private int? _initialInstanceCount;
        private string _instanceType;
        private string _kmsEncryptionKey;
        private VpcConfig _vpc;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The ARN of the IAM role that Amazon SageMaker can assume to access model artifacts
        /// and docker image for deployment on Amazon EC2 compute instances or for batch transform
        /// jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property InitialInstanceCount. 
        /// <para>
        /// The number of Amazon EC2 compute instances to deploy for initial endpoint creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? InitialInstanceCount
        {
            get { return this._initialInstanceCount; }
            set { this._initialInstanceCount = value; }
        }

        // Check to see if InitialInstanceCount property is set
        internal bool IsSetInitialInstanceCount()
        {
            return this._initialInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 compute instance type to deploy for hosting the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsEncryptionKey. 
        /// <para>
        /// The Amazon Web Services KMS key that Amazon SageMaker uses to encrypt data on the
        /// storage volume attached to the Amazon EC2 compute instance that hosts the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsEncryptionKey
        {
            get { return this._kmsEncryptionKey; }
            set { this._kmsEncryptionKey = value; }
        }

        // Check to see if KmsEncryptionKey property is set
        internal bool IsSetKmsEncryptionKey()
        {
            return this._kmsEncryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The VPC configuration for the endpoint.
        /// </para>
        /// </summary>
        public VpcConfig Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}