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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Session keys for ABP v1.1
    /// </summary>
    public partial class SessionKeysAbpV1_0_x
    {
        private string _appSKey;
        private string _nwkSKey;

        /// <summary>
        /// Gets and sets the property AppSKey. 
        /// <para>
        /// The AppSKey value.
        /// </para>
        /// </summary>
        public string AppSKey
        {
            get { return this._appSKey; }
            set { this._appSKey = value; }
        }

        // Check to see if AppSKey property is set
        internal bool IsSetAppSKey()
        {
            return this._appSKey != null;
        }

        /// <summary>
        /// Gets and sets the property NwkSKey. 
        /// <para>
        /// The NwkSKey value.
        /// </para>
        /// </summary>
        public string NwkSKey
        {
            get { return this._nwkSKey; }
            set { this._nwkSKey = value; }
        }

        // Check to see if NwkSKey property is set
        internal bool IsSetNwkSKey()
        {
            return this._nwkSKey != null;
        }

    }
}