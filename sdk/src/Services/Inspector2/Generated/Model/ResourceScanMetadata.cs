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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that contains details about the metadata for an Amazon ECR resource.
    /// </summary>
    public partial class ResourceScanMetadata
    {
        private CodeRepositoryMetadata _codeRepository;
        private ContainerImageMetadata _containerImage;
        private ContainerRegistryMetadata _containerRegistry;
        private ContainerRepositoryMetadata _containerRepository;
        private Ec2Metadata _ec2;
        private EcrContainerImageMetadata _ecrImage;
        private EcrRepositoryMetadata _ecrRepository;
        private LambdaFunctionMetadata _lambdaFunction;
        private ServerlessFunctionMetadata _serverlessFunction;
        private VmInstanceMetadata _vmInstance;

        /// <summary>
        /// Gets and sets the property CodeRepository. 
        /// <para>
        /// Contains metadata about scan coverage for a code repository resource.
        /// </para>
        /// </summary>
        public CodeRepositoryMetadata CodeRepository
        {
            get { return this._codeRepository; }
            set { this._codeRepository = value; }
        }

        // Check to see if CodeRepository property is set
        internal bool IsSetCodeRepository()
        {
            return this._codeRepository != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerImage. 
        /// <para>
        /// The container image metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public ContainerImageMetadata ContainerImage
        {
            get { return this._containerImage; }
            set { this._containerImage = value; }
        }

        // Check to see if ContainerImage property is set
        internal bool IsSetContainerImage()
        {
            return this._containerImage != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerRegistry. 
        /// <para>
        /// The container registry metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public ContainerRegistryMetadata ContainerRegistry
        {
            get { return this._containerRegistry; }
            set { this._containerRegistry = value; }
        }

        // Check to see if ContainerRegistry property is set
        internal bool IsSetContainerRegistry()
        {
            return this._containerRegistry != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerRepository. 
        /// <para>
        /// The container repository metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public ContainerRepositoryMetadata ContainerRepository
        {
            get { return this._containerRepository; }
            set { this._containerRepository = value; }
        }

        // Check to see if ContainerRepository property is set
        internal bool IsSetContainerRepository()
        {
            return this._containerRepository != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2. 
        /// <para>
        /// An object that contains metadata details for an Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2Metadata Ec2
        {
            get { return this._ec2; }
            set { this._ec2 = value; }
        }

        // Check to see if Ec2 property is set
        internal bool IsSetEc2()
        {
            return this._ec2 != null;
        }

        /// <summary>
        /// Gets and sets the property EcrImage. 
        /// <para>
        /// An object that contains details about the container metadata for an Amazon ECR image.
        /// </para>
        /// </summary>
        public EcrContainerImageMetadata EcrImage
        {
            get { return this._ecrImage; }
            set { this._ecrImage = value; }
        }

        // Check to see if EcrImage property is set
        internal bool IsSetEcrImage()
        {
            return this._ecrImage != null;
        }

        /// <summary>
        /// Gets and sets the property EcrRepository. 
        /// <para>
        /// An object that contains details about the repository an Amazon ECR image resides in.
        /// </para>
        /// </summary>
        public EcrRepositoryMetadata EcrRepository
        {
            get { return this._ecrRepository; }
            set { this._ecrRepository = value; }
        }

        // Check to see if EcrRepository property is set
        internal bool IsSetEcrRepository()
        {
            return this._ecrRepository != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// An object that contains metadata details for an Amazon Web Services Lambda function.
        /// </para>
        /// </summary>
        public LambdaFunctionMetadata LambdaFunction
        {
            get { return this._lambdaFunction; }
            set { this._lambdaFunction = value; }
        }

        // Check to see if LambdaFunction property is set
        internal bool IsSetLambdaFunction()
        {
            return this._lambdaFunction != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessFunction. 
        /// <para>
        /// The serverless function metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public ServerlessFunctionMetadata ServerlessFunction
        {
            get { return this._serverlessFunction; }
            set { this._serverlessFunction = value; }
        }

        // Check to see if ServerlessFunction property is set
        internal bool IsSetServerlessFunction()
        {
            return this._serverlessFunction != null;
        }

        /// <summary>
        /// Gets and sets the property VmInstance. 
        /// <para>
        /// The VM instance metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public VmInstanceMetadata VmInstance
        {
            get { return this._vmInstance; }
            set { this._vmInstance = value; }
        }

        // Check to see if VmInstance property is set
        internal bool IsSetVmInstance()
        {
            return this._vmInstance != null;
        }

    }
}