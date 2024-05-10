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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
    public partial class DataProviderDescriptorDefinition
    {
        private string _dataProviderIdentifier;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;

        /// <summary>
        /// Gets and sets the property DataProviderIdentifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the data provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataProviderIdentifier
        {
            get { return this._dataProviderIdentifier; }
            set { this._dataProviderIdentifier = value; }
        }

        // Check to see if DataProviderIdentifier property is set
        internal bool IsSetDataProviderIdentifier()
        {
            return this._dataProviderIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The ARN of the role used to access Amazon Web Services Secrets Manager.
        /// </para>
        /// </summary>
        public string SecretsManagerAccessRoleArn
        {
            get { return this._secretsManagerAccessRoleArn; }
            set { this._secretsManagerAccessRoleArn = value; }
        }

        // Check to see if SecretsManagerAccessRoleArn property is set
        internal bool IsSetSecretsManagerAccessRoleArn()
        {
            return this._secretsManagerAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The identifier of the Amazon Web Services Secrets Manager Secret used to store access
        /// credentials for the data provider.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId
        {
            get { return this._secretsManagerSecretId; }
            set { this._secretsManagerSecretId = value; }
        }

        // Check to see if SecretsManagerSecretId property is set
        internal bool IsSetSecretsManagerSecretId()
        {
            return this._secretsManagerSecretId != null;
        }

    }
}