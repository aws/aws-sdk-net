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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOpsMetadata operation.
    /// Amazon Web Services Systems Manager calls this API operation when you edit OpsMetadata
    /// in Application Manager.
    /// </summary>
    public partial class UpdateOpsMetadataRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _keysToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, MetadataValue> _metadataToUpdate = AWSConfigs.InitializeCollections ? new Dictionary<string, MetadataValue>() : null;
        private string _opsMetadataArn;

        /// <summary>
        /// Gets and sets the property KeysToDelete. 
        /// <para>
        /// The metadata keys to delete from the OpsMetadata object. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> KeysToDelete
        {
            get { return this._keysToDelete; }
            set { this._keysToDelete = value; }
        }

        // Check to see if KeysToDelete property is set
        internal bool IsSetKeysToDelete()
        {
            return this._keysToDelete != null && (this._keysToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetadataToUpdate. 
        /// <para>
        /// Metadata to add to an OpsMetadata object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public Dictionary<string, MetadataValue> MetadataToUpdate
        {
            get { return this._metadataToUpdate; }
            set { this._metadataToUpdate = value; }
        }

        // Check to see if MetadataToUpdate property is set
        internal bool IsSetMetadataToUpdate()
        {
            return this._metadataToUpdate != null && (this._metadataToUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OpsMetadataArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OpsMetadata Object to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string OpsMetadataArn
        {
            get { return this._opsMetadataArn; }
            set { this._opsMetadataArn = value; }
        }

        // Check to see if OpsMetadataArn property is set
        internal bool IsSetOpsMetadataArn()
        {
            return this._opsMetadataArn != null;
        }

    }
}