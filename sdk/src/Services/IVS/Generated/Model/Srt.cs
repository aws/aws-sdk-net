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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Specifies information needed to stream using the SRT protocol.
    /// </summary>
    public partial class Srt
    {
        private string _endpoint;
        private string _passphrase;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint to be used when streaming with IVS using the SRT protocol.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Passphrase. 
        /// <para>
        /// Auto-generated passphrase to enable encryption. This field is applicable only if the
        /// end user has <i>not</i> enabled the <c>insecureIngest</c> option for the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Passphrase
        {
            get { return this._passphrase; }
            set { this._passphrase = value; }
        }

        // Check to see if Passphrase property is set
        internal bool IsSetPassphrase()
        {
            return this._passphrase != null;
        }

    }
}