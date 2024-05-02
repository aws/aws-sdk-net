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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The location in Amazon Simple Storage Service (Amazon S3) where query and calculation
    /// results are stored and the encryption option, if any, used for query and calculation
    /// results. These are known as client-side settings. If workgroup settings override client-side
    /// settings, then the query uses the workgroup settings.
    /// </summary>
    public partial class AwsAthenaWorkGroupConfigurationResultConfigurationDetails
    {
        private AwsAthenaWorkGroupConfigurationResultConfigurationEncryptionConfigurationDetails _encryptionConfiguration;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        ///  Specifies the method used to encrypt the user’s data stores in the Athena workgroup.
        /// 
        /// </para>
        /// </summary>
        public AwsAthenaWorkGroupConfigurationResultConfigurationEncryptionConfigurationDetails EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

    }
}