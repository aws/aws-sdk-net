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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The lifecycle hooks that run when you create or update the AgentCore Runtime, before
    /// any sessions are created.
    /// </summary>
    public partial class BuildLifecycleHooks
    {
        /// <summary>
        /// Gets and sets the property Warmup. 
        /// <para>
        /// The hook that warms up your agent before any sessions are created. Use this hook to
        /// load the resources that your sessions need, such as models, libraries, or caches.
        /// Your hook must complete within 120 seconds.
        /// </para>
        /// </summary>
        public LifecycleHook Warmup { get; set; }

        /// <summary>
        /// Checks to see if the Warmup property is set.
        /// </summary>
        internal bool IsSetWarmup() => this.Warmup != null;
    }
}
