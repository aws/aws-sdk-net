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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The login credentials to use to import a data source resource.
    /// </summary>
    public partial class AssetBundleImportJobDataSourceCredentials
    {
        /// <summary>
        /// Gets and sets the property CredentialPair. 
        /// <para>
        /// A username and password credential pair to be used to create the imported data source.
        /// Keep this field blank if you are using a Secrets Manager secret to provide credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public AssetBundleImportJobDataSourceCredentialPair CredentialPair { get; set; }

        /// <summary>
        /// Checks to see if the CredentialPair property is set.
        /// </summary>
        internal bool IsSetCredentialPair() => this.CredentialPair != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The ARN of the Secrets Manager secret that's used to create the imported data source.
        /// Keep this field blank, unless you are using a secret in place of a credential pair.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;
    }
}
