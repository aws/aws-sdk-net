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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the SetLocalConsolePassword operation.
    /// Sets the password for your VM local console. When you log in to the local console
    /// for the first time, you log in to the VM with the default credentials. We recommend
    /// that you set a new password. You don't need to know the default password to set a
    /// new password.
    /// </summary>
    public partial class SetLocalConsolePasswordRequest : AmazonStorageGatewayRequest
    {
        private string _gatewayARN;
        private string _localConsolePassword;

        /// <summary>
        /// Gets and sets the property GatewayARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string GatewayARN
        {
            get { return this._gatewayARN; }
            set { this._gatewayARN = value; }
        }

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this._gatewayARN != null;
        }

        /// <summary>
        /// Gets and sets the property LocalConsolePassword. 
        /// <para>
        /// The password you want to set for your VM local console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=6, Max=512)]
        public string LocalConsolePassword
        {
            get { return this._localConsolePassword; }
            set { this._localConsolePassword = value; }
        }

        // Check to see if LocalConsolePassword property is set
        internal bool IsSetLocalConsolePassword()
        {
            return this._localConsolePassword != null;
        }

    }
}