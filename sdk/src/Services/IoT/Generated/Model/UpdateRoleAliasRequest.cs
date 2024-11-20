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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRoleAlias operation.
    /// Updates a role alias.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateRoleAlias</a>
    /// action.
    /// </para>
    ///  <important> 
    /// <para>
    /// The value of <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_UpdateRoleAlias.html#iot-UpdateRoleAlias-request-credentialDurationSeconds">
    /// <c>credentialDurationSeconds</c> </a> must be less than or equal to the maximum session
    /// duration of the IAM role that the role alias references. For more information, see
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-managingrole-editing-api.html#roles-modify_max-session-duration-api">
    /// Modifying a role maximum session duration (Amazon Web Services API)</a> from the Amazon
    /// Web Services Identity and Access Management User Guide.
    /// </para>
    ///  </important>
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
        ///  
        /// <para>
        /// This value must be less than or equal to the maximum session duration of the IAM role
        /// that the role alias references.
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=43200)]
        public int? CredentialDurationSeconds
        {
            get { return this._credentialDurationSeconds; }
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