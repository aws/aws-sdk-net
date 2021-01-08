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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoleAlias operation.
    /// Updates a role alias.
    /// </summary>
    public partial class UpdateRoleAliasRequest : AmazonIoTRequest
    {
        private int? _credentialDurationSeconds;
        private string _roleAlias;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CredentialDurationSeconds. 
        /// <para>
        /// The number of seconds the credential will be valid.
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=3600)]
        public int CredentialDurationSeconds
        {
            get { return this._credentialDurationSeconds.GetValueOrDefault(); }
            set { this._credentialDurationSeconds = value; }
        }

        // Check to see if CredentialDurationSeconds property is set
        internal bool IsSetCredentialDurationSeconds()
        {
            return this._credentialDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleAlias. 
        /// <para>
        /// The role alias to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RoleAlias
        {
            get { return this._roleAlias; }
            set { this._roleAlias = value; }
        }

        // Check to see if RoleAlias property is set
        internal bool IsSetRoleAlias()
        {
            return this._roleAlias != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}