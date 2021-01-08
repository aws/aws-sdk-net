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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateOpsMetadata operation.
    /// Systems Manager calls this API action when you edit OpsMetadata in Application Manager.
    /// </summary>
    public partial class UpdateOpsMetadataRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<string> _keysToDelete = new List<string>();
        private Dictionary<string, MetadataValue> _metadataToUpdate = new Dictionary<string, MetadataValue>();
        private string _opsMetadataArn;

        /// <summary>
        /// Gets and sets the property KeysToDelete. 
        /// <para>
        /// The metadata keys to delete from the OpsMetadata object. 
        /// </para>
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
            return this._keysToDelete != null && this._keysToDelete.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetadataToUpdate. 
        /// <para>
        /// Metadata to add to an OpsMetadata object.
        /// </para>
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
            return this._metadataToUpdate != null && this._metadataToUpdate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OpsMetadataArn. 
        /// <para>
        /// The Amazon Resoure Name (ARN) of the OpsMetadata Object to update.
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