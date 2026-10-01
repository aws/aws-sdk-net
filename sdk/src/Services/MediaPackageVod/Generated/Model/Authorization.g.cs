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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// CDN Authorization credentials
    /// </summary>
    public partial class Authorization
    {
        /// <summary>
        /// Gets and sets the property CdnIdentifierSecret. The Amazon Resource Name (ARN) for
        /// the secret in AWS Secrets Manager that is used for CDN authorization.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CdnIdentifierSecret { get; set; }

        /// <summary>
        /// Checks to see if the CdnIdentifierSecret property is set.
        /// </summary>
        internal bool IsSetCdnIdentifierSecret() => this.CdnIdentifierSecret != null;

        /// <summary>
        /// Gets and sets the property SecretsRoleArn. The Amazon Resource Name (ARN) for the
        /// IAM role that allows MediaPackage to communicate with AWS Secrets Manager.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecretsRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsRoleArn() => this.SecretsRoleArn != null;
    }
}
