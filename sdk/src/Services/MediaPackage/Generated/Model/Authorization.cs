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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
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
namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// CDN Authorization credentials
    /// </summary>
    public partial class Authorization
    {
        private string _cdnIdentifierSecret;
        private string _secretsRoleArn;

        /// <summary>
        /// Gets and sets the property CdnIdentifierSecret. The Amazon Resource Name (ARN) for
        /// the secret in Secrets Manager that your Content Distribution Network (CDN) uses for
        /// authorization to access your endpoint.
        /// </summary>
        [AWSProperty(Required=true)]
        public string CdnIdentifierSecret
        {
            get { return this._cdnIdentifierSecret; }
            set { this._cdnIdentifierSecret = value; }
        }

        // Check to see if CdnIdentifierSecret property is set
        internal bool IsSetCdnIdentifierSecret()
        {
            return this._cdnIdentifierSecret != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsRoleArn. The Amazon Resource Name (ARN) for the
        /// IAM role that allows MediaPackage to communicate with AWS Secrets Manager.
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecretsRoleArn
        {
            get { return this._secretsRoleArn; }
            set { this._secretsRoleArn = value; }
        }

        // Check to see if SecretsRoleArn property is set
        internal bool IsSetSecretsRoleArn()
        {
            return this._secretsRoleArn != null;
        }

    }
}