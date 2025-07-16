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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The settings to enable CDN authorization headers in MediaPackage.
    /// </summary>
    public partial class CdnAuthConfiguration
    {
        private List<string> _cdnIdentifierSecretArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _secretsRoleArn;

        /// <summary>
        /// Gets and sets the property CdnIdentifierSecretArns. 
        /// <para>
        /// The ARN for the secret in Secrets Manager that your CDN uses for authorization to
        /// access the endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> CdnIdentifierSecretArns
        {
            get { return this._cdnIdentifierSecretArns; }
            set { this._cdnIdentifierSecretArns = value; }
        }

        // Check to see if CdnIdentifierSecretArns property is set
        internal bool IsSetCdnIdentifierSecretArns()
        {
            return this._cdnIdentifierSecretArns != null && (this._cdnIdentifierSecretArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecretsRoleArn. 
        /// <para>
        /// The ARN for the IAM role that gives MediaPackage read access to Secrets Manager and
        /// KMS for CDN authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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