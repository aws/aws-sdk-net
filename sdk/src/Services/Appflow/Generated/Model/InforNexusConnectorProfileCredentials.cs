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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The connector-specific profile credentials required by Infor Nexus.
    /// </summary>
    public partial class InforNexusConnectorProfileCredentials
    {
        private string _accessKeyId;
        private string _datakey;
        private string _secretAccessKey;
        private string _userId;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        ///  The Access Key portion of the credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=256)]
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Datakey. 
        /// <para>
        ///  The encryption keys used to encrypt data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Datakey
        {
            get { return this._datakey; }
            set { this._datakey = value; }
        }

        // Check to see if Datakey property is set
        internal bool IsSetDatakey()
        {
            return this._datakey != null;
        }

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        ///  The secret key used to sign requests. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string SecretAccessKey
        {
            get { return this._secretAccessKey; }
            set { this._secretAccessKey = value; }
        }

        // Check to see if SecretAccessKey property is set
        internal bool IsSetSecretAccessKey()
        {
            return this._secretAccessKey != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  The identifier for the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}