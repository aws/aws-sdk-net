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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a tag for an Auto Scaling group.
    /// </summary>
    public partial class TagDescription
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The tag key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property PropagateAtLaunch. 
        /// <para>
        /// Determines whether the tag is added to new instances as they are launched in the group.
        /// </para>
        /// </summary>
        public bool? PropagateAtLaunch { get; set; }

        /// <summary>
        /// Checks to see if the PropagateAtLaunch property is set.
        /// </summary>
        internal bool IsSetPropagateAtLaunch() => this.PropagateAtLaunch.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource. The only supported value is <c>auto-scaling-group</c>.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The tag value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
