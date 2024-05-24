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
    /// OTAA device object for v1.1
    /// </summary>
    public partial class OtaaV1_1
    {
        private string _appKey;
        private string _joinEui;
        private string _nwkKey;

        /// <summary>
        /// Gets and sets the property AppKey. 
        /// <para>
        /// The AppKey value.
        /// </para>
        /// </summary>
        public string AppKey
        {
            get { return this._appKey; }
            set { this._appKey = value; }
        }

        // Check to see if AppKey property is set
        internal bool IsSetAppKey()
        {
            return this._appKey != null;
        }

        /// <summary>
        /// Gets and sets the property JoinEui. 
        /// <para>
        /// The JoinEUI value.
        /// </para>
        /// </summary>
        public string JoinEui
        {
            get { return this._joinEui; }
            set { this._joinEui = value; }
        }

        // Check to see if JoinEui property is set
        internal bool IsSetJoinEui()
        {
            return this._joinEui != null;
        }

        /// <summary>
        /// Gets and sets the property NwkKey. 
        /// <para>
        /// The NwkKey value.
        /// </para>
        /// </summary>
        public string NwkKey
        {
            get { return this._nwkKey; }
            set { this._nwkKey = value; }
        }

        // Check to see if NwkKey property is set
        internal bool IsSetNwkKey()
        {
            return this._nwkKey != null;
        }

    }
}