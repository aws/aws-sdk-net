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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteKeyPair operation.
    /// Deletes the specified key pair by removing the public key from Amazon Lightsail.
    /// 
    ///  
    /// <para>
    /// You can delete key pairs that were created using the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_ImportKeyPair.html">ImportKeyPair</a>
    /// and <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateKeyPair.html">CreateKeyPair</a>
    /// actions, as well as the Lightsail default key pair. A new default key pair will not
    /// be created unless you launch an instance without specifying a custom key pair, or
    /// you call the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_DownloadDefaultKeyPair.html">DownloadDefaultKeyPair</a>
    /// API. 
    /// </para>
    ///  
    /// <para>
    /// The <c>delete key pair</c> operation supports tag-based access control via resource
    /// tags applied to the resource identified by <c>key pair name</c>. For more information,
    /// see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class DeleteKeyPairRequest : AmazonLightsailRequest
    {
        private string _expectedFingerprint;
        private string _keyPairName;

        /// <summary>
        /// Gets and sets the property ExpectedFingerprint. 
        /// <para>
        /// The RSA fingerprint of the Lightsail default key pair to delete.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>expectedFingerprint</c> parameter is required only when specifying to delete
        /// a Lightsail default key pair.
        /// </para>
        ///  </note>
        /// </summary>
        public string ExpectedFingerprint
        {
            get { return this._expectedFingerprint; }
            set { this._expectedFingerprint = value; }
        }

        // Check to see if ExpectedFingerprint property is set
        internal bool IsSetExpectedFingerprint()
        {
            return this._expectedFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPairName. 
        /// <para>
        /// The name of the key pair to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KeyPairName
        {
            get { return this._keyPairName; }
            set { this._keyPairName = value; }
        }

        // Check to see if KeyPairName property is set
        internal bool IsSetKeyPairName()
        {
            return this._keyPairName != null;
        }

    }
}