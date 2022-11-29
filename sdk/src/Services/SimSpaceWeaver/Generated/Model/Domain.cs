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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// A collection of app instances that run the same executable app code and have the same
    /// launch options and commands.
    /// 
    ///  
    /// <para>
    /// For more information about domains, see <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/what-is_key-concepts.html">Key
    /// concepts</a> in the <i>Amazon Web Services SimSpace Weaver User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Domain
    {
        private LifecycleManagementStrategy _lifecycle;
        private string _name;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The type of lifecycle management for apps in the domain. This value indicates whether
        /// apps in this domain are <i>managed</i> (SimSpace Weaver starts and stops the apps)
        /// or <i>unmanaged</i> (you must start and stop the apps).
        /// </para>
        ///  <p class="title"> <b>Lifecycle types</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PerWorker</code> – Managed: SimSpace Weaver starts 1 app on each worker
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BySpatialSubdivision</code> – Managed: SimSpace Weaver starts 1 app for each
        /// spatial partition
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ByRequest</code> – Unmanaged: You use the <b>StartApp</b> API to start the
        /// apps and use the <b>StopApp</b> API to stop the apps.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The lifecycle types will change when the service is released for general availability
        /// (GA).
        /// </para>
        ///  </note>
        /// </summary>
        public LifecycleManagementStrategy Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}