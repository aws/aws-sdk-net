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
    public partial class SessionKeysAbpV1_1
    {
        private string _appSKey;
        private string _fNwkSIntKey;
        private string _nwkSEncKey;
        private string _sNwkSIntKey;

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
        /// Gets and sets the property FNwkSIntKey. 
        /// <para>
        /// The FNwkSIntKey value.
        /// </para>
        /// </summary>
        public string FNwkSIntKey
        {
            get { return this._fNwkSIntKey; }
            set { this._fNwkSIntKey = value; }
        }

        // Check to see if FNwkSIntKey property is set
        internal bool IsSetFNwkSIntKey()
        {
            return this._fNwkSIntKey != null;
        }

        /// <summary>
        /// Gets and sets the property NwkSEncKey. 
        /// <para>
        /// The NwkSEncKey value.
        /// </para>
        /// </summary>
        public string NwkSEncKey
        {
            get { return this._nwkSEncKey; }
            set { this._nwkSEncKey = value; }
        }

        // Check to see if NwkSEncKey property is set
        internal bool IsSetNwkSEncKey()
        {
            return this._nwkSEncKey != null;
        }

        /// <summary>
        /// Gets and sets the property SNwkSIntKey. 
        /// <para>
        /// The SNwkSIntKey value.
        /// </para>
        /// </summary>
        public string SNwkSIntKey
        {
            get { return this._sNwkSIntKey; }
            set { this._sNwkSIntKey = value; }
        }

        // Check to see if SNwkSIntKey property is set
        internal bool IsSetSNwkSIntKey()
        {
            return this._sNwkSIntKey != null;
        }

    }
}