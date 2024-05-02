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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the InstallToRemoteAccessSession operation.
    /// Installs an application to the device in a remote access session. For Android applications,
    /// the file must be in .apk format. For iOS applications, the file must be in .ipa format.
    /// </summary>
    public partial class InstallToRemoteAccessSessionRequest : AmazonDeviceFarmRequest
    {
        private string _appArn;
        private string _remoteAccessSessionArn;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The ARN of the app about which you are requesting information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteAccessSessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the remote access session about which you are requesting
        /// information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string RemoteAccessSessionArn
        {
            get { return this._remoteAccessSessionArn; }
            set { this._remoteAccessSessionArn = value; }
        }

        // Check to see if RemoteAccessSessionArn property is set
        internal bool IsSetRemoteAccessSessionArn()
        {
            return this._remoteAccessSessionArn != null;
        }

    }
}