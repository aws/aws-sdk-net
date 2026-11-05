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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <c>Change</c> structure describes the changes CloudFormation will perform if you
    /// execute the change set.
    /// </summary>
    public partial class Change
    {
        /// <summary>
        /// Gets and sets the property HookInvocationCount. 
        /// <para>
        /// Is either <c>null</c>, if no Hooks invoke for the resource, or contains the number
        /// of Hooks that will invoke for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? HookInvocationCount { get; set; }

        /// <summary>
        /// Checks to see if the HookInvocationCount property is set.
        /// </summary>
        internal bool IsSetHookInvocationCount() => this.HookInvocationCount.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceChange. 
        /// <para>
        /// A <c>ResourceChange</c> structure that describes the resource and action that CloudFormation
        /// will perform.
        /// </para>
        /// </summary>
        public ResourceChange ResourceChange { get; set; }

        /// <summary>
        /// Checks to see if the ResourceChange property is set.
        /// </summary>
        internal bool IsSetResourceChange() => this.ResourceChange != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entity that CloudFormation changes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Resource</c> This change is for a resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChangeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
