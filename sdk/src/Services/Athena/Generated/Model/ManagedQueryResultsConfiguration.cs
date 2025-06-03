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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// The configuration for storing results in Athena owned storage, which includes whether
    /// this feature is enabled; whether encryption configuration, if any, is used for encrypting
    /// query results.
    /// </summary>
    public partial class ManagedQueryResultsConfiguration
    {
        private bool? _enabled;
        private ManagedQueryResultsEncryptionConfiguration _encryptionConfiguration;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If set to true, allows you to store query results in Athena owned storage. If set
        /// to false, workgroup member stores query results in location specified under <c>ResultConfiguration$OutputLocation</c>.
        /// The default is false. A workgroup cannot have the <c>ResultConfiguration$OutputLocation</c>
        /// parameter when you set this field to true. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// If you encrypt query and calculation results in Athena owned storage, this field indicates
        /// the encryption option (for example, SSE_KMS or CSE_KMS) and key information.
        /// </para>
        /// </summary>
        public ManagedQueryResultsEncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

    }
}