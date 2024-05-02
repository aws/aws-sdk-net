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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Authorization-related configuration inputs for the security configuration.
    /// </summary>
    public partial class AuthorizationConfiguration
    {
        private EncryptionConfiguration _encryptionConfiguration;
        private LakeFormationConfiguration _lakeFormationConfiguration;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Encryption-related configuration input for the security configuration.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LakeFormationConfiguration. 
        /// <para>
        /// Lake Formation related configuration inputs for the security configuration.
        /// </para>
        /// </summary>
        public LakeFormationConfiguration LakeFormationConfiguration
        {
            get { return this._lakeFormationConfiguration; }
            set { this._lakeFormationConfiguration = value; }
        }

        // Check to see if LakeFormationConfiguration property is set
        internal bool IsSetLakeFormationConfiguration()
        {
            return this._lakeFormationConfiguration != null;
        }

    }
}