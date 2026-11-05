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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Information about a data provider.
    /// </summary>
    public partial class DataProviderDescriptor
    {
        /// <summary>
        /// Gets and sets the property DataProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data provider.
        /// </para>
        /// </summary>
        public string DataProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the DataProviderArn property is set.
        /// </summary>
        internal bool IsSetDataProviderArn() => this.DataProviderArn != null;

        /// <summary>
        /// Gets and sets the property DataProviderName. 
        /// <para>
        /// The user-friendly name of the data provider.
        /// </para>
        /// </summary>
        public string DataProviderName { get; set; }

        /// <summary>
        /// Checks to see if the DataProviderName property is set.
        /// </summary>
        internal bool IsSetDataProviderName() => this.DataProviderName != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The ARN of the role used to access Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        public string SecretsManagerAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetSecretsManagerAccessRoleArn() => this.SecretsManagerAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The identifier of the Amazon Web Services Secrets Manager Secret used to store access
        /// credentials for the data provider.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecretId property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecretId() => this.SecretsManagerSecretId != null;
    }
}
