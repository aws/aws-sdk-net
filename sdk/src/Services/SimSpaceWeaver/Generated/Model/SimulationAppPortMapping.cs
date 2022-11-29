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
    /// A collection of TCP/UDP ports for a custom or service app.
    /// </summary>
    public partial class SimulationAppPortMapping
    {
        private int? _actual;
        private int? _declared;

        /// <summary>
        /// Gets and sets the property Actual. 
        /// <para>
        /// The TCP/UDP port number of the running app. SimSpace Weaver dynamically assigns this
        /// port number when the app starts. SimSpace Weaver maps the <code>Declared</code> port
        /// to the <code>Actual</code> port. Clients connect to the app using the app's IP address
        /// and the <code>Actual</code> port number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int Actual
        {
            get { return this._actual.GetValueOrDefault(); }
            set { this._actual = value; }
        }

        // Check to see if Actual property is set
        internal bool IsSetActual()
        {
            return this._actual.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Declared. 
        /// <para>
        /// The TCP/UDP port number of the app, declared in the simulation schema. SimSpace Weaver
        /// maps the <code>Declared</code> port to the <code>Actual</code> port. The source code
        /// for the app should bind to the <code>Declared</code> port.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65535)]
        public int Declared
        {
            get { return this._declared.GetValueOrDefault(); }
            set { this._declared = value; }
        }

        // Check to see if Declared property is set
        internal bool IsSetDeclared()
        {
            return this._declared.HasValue; 
        }

    }
}