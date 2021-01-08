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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents types of timeouts.
    /// </summary>
    public partial class TcpTimeout
    {
        private Duration _idle;

        /// <summary>
        /// Gets and sets the property Idle. 
        /// <para>
        /// An object that represents an idle timeout. An idle timeout bounds the amount of time
        /// that a connection may be idle. The default value is none.
        /// </para>
        /// </summary>
        public Duration Idle
        {
            get { return this._idle; }
            set { this._idle = value; }
        }

        // Check to see if Idle property is set
        internal bool IsSetIdle()
        {
            return this._idle != null;
        }

    }
}