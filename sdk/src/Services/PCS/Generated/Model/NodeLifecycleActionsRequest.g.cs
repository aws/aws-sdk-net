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

namespace Amazon.PCS.Model
{
    /// <summary>
    /// The lifecycle actions to configure on a compute node group when you create it. Lifecycle
    /// actions define scripts that PCS runs on compute nodes at specific stages of their
    /// lifecycle.
    /// </summary>
    public partial class NodeLifecycleActionsRequest
    {
        /// <summary>
        /// Gets and sets the property ScriptCachingPolicy. 
        /// <para>
        /// The caching policy for node lifecycle scripts. The default value is <c>CACHE_ONCE</c>.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CACHE_ONCE</c> – Downloads each script once and reuses it on subsequent boots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REFRESH_ON_REBOOT</c> – Downloads each script on every boot.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScriptCachingPolicy ScriptCachingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ScriptCachingPolicy property is set.
        /// </summary>
        internal bool IsSetScriptCachingPolicy() => this.ScriptCachingPolicy != null;

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// The lifecycle stages where you configure scripts to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NodeLifecycleStages Stages { get; set; }

        /// <summary>
        /// Checks to see if the Stages property is set.
        /// </summary>
        internal bool IsSetStages() => this.Stages != null;
    }
}
