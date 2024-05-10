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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The KMS key details.
    /// </summary>
    public partial class KMSKey
    {
        private string _kmsEncryptionKeyArn;

        /// <summary>
        /// Gets and sets the property KmsEncryptionKeyArn. 
        /// <para>
        /// The encryption key ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=90)]
        public string KmsEncryptionKeyArn
        {
            get { return this._kmsEncryptionKeyArn; }
            set { this._kmsEncryptionKeyArn = value; }
        }

        // Check to see if KmsEncryptionKeyArn property is set
        internal bool IsSetKmsEncryptionKeyArn()
        {
            return this._kmsEncryptionKeyArn != null;
        }

    }
}