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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
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
namespace Amazon.DAX.Model
{
    /// <summary>
    /// The description of the server-side encryption status on the specified DAX cluster.
    /// </summary>
    public partial class SSEDescription
    {
        private SSEStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of server-side encryption:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLING</c> - Server-side encryption is being enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED</c> - Server-side encryption is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLING</c> - Server-side encryption is being disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - Server-side encryption is disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SSEStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}