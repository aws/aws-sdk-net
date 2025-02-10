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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The structure that defines how Firehose accesses the secret.
    /// </summary>
    public partial class SecretsManagerConfiguration
    {
        private bool? _enabled;
        private string _roleARN;
        private string _secretARN;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether you want to use the secrets manager feature. When set as <c>True</c>
        /// the secrets manager configuration overwrites the existing secrets in the destination
        /// configuration. When it's set to <c>False</c> Firehose falls back to the credentials
        /// in the destination configuration.
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
        /// Gets and sets the property RoleARN. 
        /// <para>
        ///  Specifies the role that Firehose assumes when calling the Secrets Manager API operation.
        /// When you provide the role, it overrides any destination specific role defined in the
        /// destination configuration. If you do not provide the then we use the destination specific
        /// role. This parameter is required for Splunk. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property SecretARN. 
        /// <para>
        /// The ARN of the secret that stores your credentials. It must be in the same region
        /// as the Firehose stream and the role. The secret ARN can reside in a different account
        /// than the Firehose stream and role as Firehose supports cross-account secret access.
        /// This parameter is required when <b>Enabled</b> is set to <c>True</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SecretARN
        {
            get { return this._secretARN; }
            set { this._secretARN = value; }
        }

        // Check to see if SecretARN property is set
        internal bool IsSetSecretARN()
        {
            return this._secretARN != null;
        }

    }
}