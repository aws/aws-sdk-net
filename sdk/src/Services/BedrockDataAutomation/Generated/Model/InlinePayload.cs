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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Input payload structure definition
    /// </summary>
    public partial class InlinePayload
    {
        private DeleteEntitiesInfo _deleteEntitiesInfo;
        private List<UpsertEntityInfo> _upsertEntitiesInfo = AWSConfigs.InitializeCollections ? new List<UpsertEntityInfo>() : null;

        /// <summary>
        /// Gets and sets the property DeleteEntitiesInfo.
        /// </summary>
        public DeleteEntitiesInfo DeleteEntitiesInfo
        {
            get { return this._deleteEntitiesInfo; }
            set { this._deleteEntitiesInfo = value; }
        }

        // Check to see if DeleteEntitiesInfo property is set
        internal bool IsSetDeleteEntitiesInfo()
        {
            return this._deleteEntitiesInfo != null;
        }

        /// <summary>
        /// Gets and sets the property UpsertEntitiesInfo.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<UpsertEntityInfo> UpsertEntitiesInfo
        {
            get { return this._upsertEntitiesInfo; }
            set { this._upsertEntitiesInfo = value; }
        }

        // Check to see if UpsertEntitiesInfo property is set
        internal bool IsSetUpsertEntitiesInfo()
        {
            return this._upsertEntitiesInfo != null && (this._upsertEntitiesInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}