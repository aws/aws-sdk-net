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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The input configuration for a customer-managed Amazon Web Services Secrets Manager
    /// secret used to supply a password.
    /// </summary>
    public partial class CustomerManagedAwsSecretConfigurationInput
    {
        private ExternalIdType _externalIdType;
        private string _iamRoleArn;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property ExternalIdType. 
        /// <para>
        /// The type of Oracle Cloud Identifier (OCID) used as the external ID when assuming the
        /// IAM role.
        /// </para>
        /// </summary>
        public ExternalIdType ExternalIdType
        {
            get { return this._externalIdType; }
            set { this._externalIdType = value; }
        }

        // Check to see if ExternalIdType property is set
        internal bool IsSetExternalIdType()
        {
            return this._externalIdType != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Identity and Access Management
        /// (IAM) role that OCI assumes to retrieve the secret value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The identifier or ARN of the Amazon Web Services Secrets Manager secret that contains
        /// the password.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SecretId
        {
            get { return this._secretId; }
            set { this._secretId = value; }
        }

        // Check to see if SecretId property is set
        internal bool IsSetSecretId()
        {
            return this._secretId != null;
        }

    }
}