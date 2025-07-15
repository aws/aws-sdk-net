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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The inventory table configuration for an S3 Metadata configuration.
    /// </summary>
    public partial class InventoryTableConfiguration
    {
        private InventoryConfigurationState _configurationState;
        private MetadataTableEncryptionConfiguration _encryptionConfiguration;

        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        ///  The configuration state of the inventory table, indicating whether the inventory table is enabled or disabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InventoryConfigurationState ConfigurationState
        {
            get { return this._configurationState; }
            set { this._configurationState = value; }
        }

        // Check to see if ConfigurationState property is set
        internal bool IsSetConfigurationState()
        {
            return this._configurationState != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        ///  The encryption configuration for the inventory table. 
        /// </para>
        /// </summary>
        public MetadataTableEncryptionConfiguration EncryptionConfiguration
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