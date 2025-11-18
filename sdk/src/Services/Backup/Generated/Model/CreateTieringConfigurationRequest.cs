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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTieringConfiguration operation.
    /// Creates a tiering configuration.
    /// 
    ///  
    /// <para>
    /// A tiering configuration enables automatic movement of backup data to a lower-cost
    /// storage tier based on the age of backed-up objects in the backup vault.
    /// </para>
    ///  
    /// <para>
    /// Each vault can only have one vault-specific tiering configuration, in addition to
    /// any global configuration that applies to all vaults.
    /// </para>
    /// </summary>
    public partial class CreateTieringConfigurationRequest : AmazonBackupRequest
    {
        private string _creatorRequestId;
        private TieringConfigurationInputForCreate _tieringConfiguration;
        private Dictionary<string, string> _tieringConfigurationTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This is a unique string that identifies the request and allows failed requests to
        /// be retried without the risk of running the operation twice. This parameter is optional.
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property TieringConfiguration. 
        /// <para>
        /// A tiering configuration must contain a unique <c>TieringConfigurationName</c> string
        /// you create and must contain a <c>BackupVaultName</c> and <c>ResourceSelection</c>.
        /// You may optionally include a <c>CreatorRequestId</c> string.
        /// </para>
        ///  
        /// <para>
        /// The <c>TieringConfigurationName</c> is a unique string that is the name of the tiering
        /// configuration. This cannot be changed after creation, and it must consist of only
        /// alphanumeric characters and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TieringConfigurationInputForCreate TieringConfiguration
        {
            get { return this._tieringConfiguration; }
            set { this._tieringConfiguration = value; }
        }

        // Check to see if TieringConfiguration property is set
        internal bool IsSetTieringConfiguration()
        {
            return this._tieringConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TieringConfigurationTags. 
        /// <para>
        /// The tags to assign to the tiering configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> TieringConfigurationTags
        {
            get { return this._tieringConfigurationTags; }
            set { this._tieringConfigurationTags = value; }
        }

        // Check to see if TieringConfigurationTags property is set
        internal bool IsSetTieringConfigurationTags()
        {
            return this._tieringConfigurationTags != null && (this._tieringConfigurationTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}