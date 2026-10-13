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

namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// Container for the parameters to the PutLifecyclePolicy operation. Writes an object
    /// lifecycle policy to a container. If the container already has an object lifecycle
    /// policy, the service replaces the existing policy with the new policy. It takes up
    /// to 20 minutes for the change to take effect. <para> For information about how to construct
    /// an object lifecycle policy, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/policies-object-lifecycle-components.html">Components
    /// of an Object Lifecycle Policy</a>. </para>
    /// </summary>
    public partial class PutLifecyclePolicyRequest : AmazonMediaStoreRequest
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container that you want to assign the object lifecycle policy to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property LifecyclePolicy. 
        /// <para>
        /// The object lifecycle policy to apply to the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 8192)]
        public string LifecyclePolicy { get; set; }

        /// <summary>
        /// Checks to see if the LifecyclePolicy property is set.
        /// </summary>
        internal bool IsSetLifecyclePolicy() => this.LifecyclePolicy != null;
    }
}
