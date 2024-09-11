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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for SrtOutputDestinationSettings
    /// </summary>
    public partial class SrtOutputDestinationSettings
    {
        private string _encryptionPassphraseSecretArn;
        private string _streamId;
        private string _url;

        /// <summary>
        /// Gets and sets the property EncryptionPassphraseSecretArn. Arn used to extract the
        /// password from Secrets Manager
        /// </summary>
        public string EncryptionPassphraseSecretArn
        {
            get { return this._encryptionPassphraseSecretArn; }
            set { this._encryptionPassphraseSecretArn = value; }
        }

        // Check to see if EncryptionPassphraseSecretArn property is set
        internal bool IsSetEncryptionPassphraseSecretArn()
        {
            return this._encryptionPassphraseSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. Stream id for SRT destinations (URLs of type
        /// srt://)
        /// </summary>
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

        /// <summary>
        /// Gets and sets the property Url. A URL specifying a destination
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}