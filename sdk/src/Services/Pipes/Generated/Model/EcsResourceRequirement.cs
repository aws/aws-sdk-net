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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The type and amount of a resource to assign to a container. The supported resource
    /// types are GPUs and Elastic Inference accelerators. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-gpu.html">Working
    /// with GPUs on Amazon ECS</a> or <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-inference.html">Working
    /// with Amazon Elastic Inference on Amazon ECS</a> in the <i>Amazon Elastic Container
    /// Service Developer Guide</i>
    /// </summary>
    public partial class EcsResourceRequirement
    {
        private EcsResourceRequirementType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of resource to assign to a container. The supported values are <code>GPU</code>
        /// or <code>InferenceAccelerator</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EcsResourceRequirementType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the specified resource type.
        /// </para>
        ///  
        /// <para>
        /// If the <code>GPU</code> type is used, the value is the number of physical <code>GPUs</code>
        /// the Amazon ECS container agent reserves for the container. The number of GPUs that's
        /// reserved for all containers in a task can't exceed the number of available GPUs on
        /// the container instance that the task is launched on.
        /// </para>
        ///  
        /// <para>
        /// If the <code>InferenceAccelerator</code> type is used, the <code>value</code> matches
        /// the <code>deviceName</code> for an InferenceAccelerator specified in a task definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}