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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes configuration updates to encryption at rest.
    /// </summary>
    public partial class ApplicationEncryptionConfigurationUpdate
    {
        private string _keyIdUpdate;
        private KeyType _keyTypeUpdate;

        /// <summary>
        /// Gets and sets the property KeyIdUpdate. 
        /// <para>
        /// The key ARN, key ID, alias ARN, or alias name of the KMS key to be used for encryption
        /// at rest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KeyIdUpdate
        {
            get { return this._keyIdUpdate; }
            set { this._keyIdUpdate = value; }
        }

        // Check to see if KeyIdUpdate property is set
        internal bool IsSetKeyIdUpdate()
        {
            return this._keyIdUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property KeyTypeUpdate. 
        /// <para>
        /// Specifies the type of key to be used for encryption at rest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyType KeyTypeUpdate
        {
            get { return this._keyTypeUpdate; }
            set { this._keyTypeUpdate = value; }
        }

        // Check to see if KeyTypeUpdate property is set
        internal bool IsSetKeyTypeUpdate()
        {
            return this._keyTypeUpdate != null;
        }

    }
}