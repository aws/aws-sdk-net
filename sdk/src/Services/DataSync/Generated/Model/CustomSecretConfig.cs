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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies configuration information for a customer-managed Secrets Manager secret
    /// where a storage location authentication token or secret key is stored in plain text.
    /// This configuration includes the secret ARN, and the ARN for an IAM role that provides
    /// access to the secret.
    /// 
    ///  <note> 
    /// <para>
    /// You can use either <c>CmkSecretConfig</c> or <c>CustomSecretConfig</c> to provide
    /// credentials for a <c>CreateLocation</c> request. Do not provide both parameters for
    /// the same request.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CustomSecretConfig
    {
        private string _secretAccessRoleArn;
        private string _secretArn;

        /// <summary>
        /// Gets and sets the property SecretAccessRoleArn. 
        /// <para>
        /// Specifies the ARN for the Identity and Access Management role that DataSync uses to
        /// access the secret specified for <c>SecretArn</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string SecretAccessRoleArn
        {
            get { return this._secretAccessRoleArn; }
            set { this._secretAccessRoleArn = value; }
        }

        // Check to see if SecretAccessRoleArn property is set
        internal bool IsSetSecretAccessRoleArn()
        {
            return this._secretAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// Specifies the ARN for an Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string SecretArn
        {
            get { return this._secretArn; }
            set { this._secretArn = value; }
        }

        // Check to see if SecretArn property is set
        internal bool IsSetSecretArn()
        {
            return this._secretArn != null;
        }

    }
}