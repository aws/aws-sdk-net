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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies the encryption settings for shared snapshots that are copied across Regions.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private string _cmkArn;
        private bool? _encrypted;

        /// <summary>
        /// Gets and sets the property CmkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS KMS customer master key (CMK) to use for
        /// EBS encryption. If this parameter is not specified, your AWS managed CMK for EBS is
        /// used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string CmkArn
        {
            get { return this._cmkArn; }
            set { this._cmkArn = value; }
        }

        // Check to see if CmkArn property is set
        internal bool IsSetCmkArn()
        {
            return this._cmkArn != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// To encrypt a copy of an unencrypted snapshot when encryption by default is not enabled,
        /// enable encryption using this parameter. Copies of encrypted snapshots are encrypted,
        /// even if this parameter is false or when encryption by default is not enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

    }
}