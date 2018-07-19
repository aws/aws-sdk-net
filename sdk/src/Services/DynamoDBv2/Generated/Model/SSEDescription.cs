/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// The description of the server-side encryption status on the specified table.
    /// </summary>
    public partial class SSEDescription
    {
        private string _kmsMasterKeyArn;
        private SSEType _sseType;
        private SSEStatus _status;

        /// <summary>
        /// Gets and sets the property KMSMasterKeyArn. 
        /// <para>
        /// The KMS master key ARN used for the KMS encryption.
        /// </para>
        /// </summary>
        public string KMSMasterKeyArn
        {
            get { return this._kmsMasterKeyArn; }
            set { this._kmsMasterKeyArn = value; }
        }

        // Check to see if KMSMasterKeyArn property is set
        internal bool IsSetKMSMasterKeyArn()
        {
            return this._kmsMasterKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SSEType. 
        /// <para>
        /// Server-side encryption type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AES256</code> - Server-side encryption which uses the AES256 algorithm.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KMS</code> - Server-side encryption which uses AWS Key Management Service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SSEType SSEType
        {
            get { return this._sseType; }
            set { this._sseType = value; }
        }

        // Check to see if SSEType property is set
        internal bool IsSetSSEType()
        {
            return this._sseType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of server-side encryption:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLING</code> - Server-side encryption is being enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENABLED</code> - Server-side encryption is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLING</code> - Server-side encryption is being disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> - Server-side encryption is disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SSEStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}