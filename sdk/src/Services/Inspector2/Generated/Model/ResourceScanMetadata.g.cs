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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that contains details about the metadata for an Amazon ECR resource.
    /// </summary>
    public partial class ResourceScanMetadata
    {
        /// <summary>
        /// Gets and sets the property CodeRepository. 
        /// <para>
        /// Contains metadata about scan coverage for a code repository resource.
        /// </para>
        /// </summary>
        public CodeRepositoryMetadata CodeRepository { get; set; }

        /// <summary>
        /// Checks to see if the CodeRepository property is set.
        /// </summary>
        internal bool IsSetCodeRepository() => this.CodeRepository != null;

        /// <summary>
        /// Gets and sets the property ContainerImage. 
        /// <para>
        /// The container image metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public ContainerImageMetadata ContainerImage { get; set; }

        /// <summary>
        /// Checks to see if the ContainerImage property is set.
        /// </summary>
        internal bool IsSetContainerImage() => this.ContainerImage != null;

        /// <summary>
        /// Gets and sets the property ContainerRegistry. 
        /// <para>
        /// The container registry metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public ContainerRegistryMetadata ContainerRegistry { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRegistry property is set.
        /// </summary>
        internal bool IsSetContainerRegistry() => this.ContainerRegistry != null;

        /// <summary>
        /// Gets and sets the property ContainerRepository. 
        /// <para>
        /// The container repository metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public ContainerRepositoryMetadata ContainerRepository { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRepository property is set.
        /// </summary>
        internal bool IsSetContainerRepository() => this.ContainerRepository != null;

        /// <summary>
        /// Gets and sets the property Ec2. 
        /// <para>
        /// An object that contains metadata details for an Amazon EC2 instance.
        /// </para>
        /// </summary>
        public Ec2Metadata Ec2 { get; set; }

        /// <summary>
        /// Checks to see if the Ec2 property is set.
        /// </summary>
        internal bool IsSetEc2() => this.Ec2 != null;

        /// <summary>
        /// Gets and sets the property EcrImage. 
        /// <para>
        /// An object that contains details about the container metadata for an Amazon ECR image.
        /// </para>
        /// </summary>
        public EcrContainerImageMetadata EcrImage { get; set; }

        /// <summary>
        /// Checks to see if the EcrImage property is set.
        /// </summary>
        internal bool IsSetEcrImage() => this.EcrImage != null;

        /// <summary>
        /// Gets and sets the property EcrRepository. 
        /// <para>
        /// An object that contains details about the repository an Amazon ECR image resides in.
        /// </para>
        /// </summary>
        public EcrRepositoryMetadata EcrRepository { get; set; }

        /// <summary>
        /// Checks to see if the EcrRepository property is set.
        /// </summary>
        internal bool IsSetEcrRepository() => this.EcrRepository != null;

        /// <summary>
        /// Gets and sets the property LambdaFunction. 
        /// <para>
        /// An object that contains metadata details for an Amazon Web Services Lambda function.
        /// </para>
        /// </summary>
        public LambdaFunctionMetadata LambdaFunction { get; set; }

        /// <summary>
        /// Checks to see if the LambdaFunction property is set.
        /// </summary>
        internal bool IsSetLambdaFunction() => this.LambdaFunction != null;

        /// <summary>
        /// Gets and sets the property ServerlessFunction. 
        /// <para>
        /// The serverless function metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public ServerlessFunctionMetadata ServerlessFunction { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessFunction property is set.
        /// </summary>
        internal bool IsSetServerlessFunction() => this.ServerlessFunction != null;

        /// <summary>
        /// Gets and sets the property VmInstance. 
        /// <para>
        /// The VM instance metadata associated with a covered resource.
        /// </para>
        /// </summary>
        public VmInstanceMetadata VmInstance { get; set; }

        /// <summary>
        /// Checks to see if the VmInstance property is set.
        /// </summary>
        internal bool IsSetVmInstance() => this.VmInstance != null;
    }
}
