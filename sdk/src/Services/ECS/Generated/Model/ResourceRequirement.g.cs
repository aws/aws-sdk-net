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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The type and amount of a resource to assign to a container. The supported resource
    /// types are GPUs, Neuron devices, and Elastic Inference accelerators. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-gpu.html">Working
    /// with GPUs on Amazon ECS</a> or <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-inference.html">Working
    /// with Amazon Elastic Inference on Amazon ECS</a> in the <i>Amazon Elastic Container
    /// Service Developer Guide</i>
    /// </summary>
    public partial class ResourceRequirement
    {
        /// <summary>
        /// Gets and sets the property SharingStrategy. 
        /// <para>
        /// The strategy that the container uses to share a GPU with other containers. Specify
        /// a sharing strategy only when the type is <c>GPU</c>. For a GPU resource requirement,
        /// specify either <c>value</c> or <c>sharingStrategy</c>, but not both. If you don't
        /// specify a sharing strategy, the container has exclusive use of each GPU that Amazon
        /// ECS assigns to it. The containers in a task that request GPUs must all use the same
        /// option.
        /// </para>
        ///  
        /// <para>
        /// You can use GPU sharing with tasks that run on Amazon EC2 instances or Amazon ECS
        /// Managed Instances. Task definitions that require <c>EXTERNAL</c> compatibility don't
        /// support GPU sharing.
        /// </para>
        /// </summary>
        public SharingStrategy SharingStrategy { get; set; }

        /// <summary>
        /// Checks to see if the SharingStrategy property is set.
        /// </summary>
        internal bool IsSetSharingStrategy() => this.SharingStrategy != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource to assign to a container. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the specified resource type.
        /// </para>
        ///  
        /// <para>
        /// You must specify this parameter unless the type is <c>GPU</c> and you specify <c>sharingStrategy</c>.
        /// </para>
        ///  
        /// <para>
        /// When the type is <c>GPU</c>, the value is the number of physical <c>GPUs</c> the Amazon
        /// ECS container agent reserves for the container. The number of GPUs that's reserved
        /// for all containers in a task can't exceed the number of available GPUs on the container
        /// instance that the task is launched on. You can also specify <c>ALL</c> to allocate
        /// all available GPUs on the instance to the container.
        /// </para>
        ///  
        /// <para>
        /// When the type is <c>NeuronDevice</c>, the value must be <c>ALL</c>. This allocates
        /// all available Neuron devices on the instance to the container. Only one container
        /// in a task can specify <c>NeuronDevice</c> resources. This resource type is only supported
        /// on Managed Instances.
        /// </para>
        ///  
        /// <para>
        /// When the type is <c>InferenceAccelerator</c>, the <c>value</c> matches the <c>deviceName</c>
        /// for an <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_InferenceAccelerator.html">InferenceAccelerator</a>
        /// specified in a task definition.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
