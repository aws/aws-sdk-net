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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Specifies configurations for the storage location of the images extracted from multimodal
    /// documents in your data source. These images can be retrieved and returned to the end
    /// user.
    /// </summary>
    public partial class SupplementalDataStorageConfiguration
    {
        private List<SupplementalDataStorageLocation> _storageLocations = AWSConfigs.InitializeCollections ? new List<SupplementalDataStorageLocation>() : null;

        /// <summary>
        /// Gets and sets the property StorageLocations. 
        /// <para>
        /// A list of objects specifying storage locations for images extracted from multimodal
        /// documents in your data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<SupplementalDataStorageLocation> StorageLocations
        {
            get { return this._storageLocations; }
            set { this._storageLocations = value; }
        }

        // Check to see if StorageLocations property is set
        internal bool IsSetStorageLocations()
        {
            return this._storageLocations != null && (this._storageLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}