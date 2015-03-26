/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Specifies the lifecycle event configuration
    /// </summary>
    public partial class LifecycleEventConfiguration
    {
        private ShutdownEventConfiguration _shutdown;

        /// <summary>
        /// Gets and sets the property Shutdown. 
        /// <para>
        /// A <code>ShutdownEventConfiguration</code> object that specifies the Shutdown event
        /// configuration.
        /// </para>
        /// </summary>
        public ShutdownEventConfiguration Shutdown
        {
            get { return this._shutdown; }
            set { this._shutdown = value; }
        }

        // Check to see if Shutdown property is set
        internal bool IsSetShutdown()
        {
            return this._shutdown != null;
        }

    }
}