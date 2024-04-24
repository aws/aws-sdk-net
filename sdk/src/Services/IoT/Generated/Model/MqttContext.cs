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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Specifies the MQTT context to use for the test authorizer request
    /// </summary>
    public partial class MqttContext
    {
        private string _clientId;
        private MemoryStream _password;
        private string _username;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The value of the <c>clientId</c> key in an MQTT authorization request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The value of the <c>password</c> key in an MQTT authorization request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public MemoryStream Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The value of the <c>username</c> key in an MQTT authorization request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}