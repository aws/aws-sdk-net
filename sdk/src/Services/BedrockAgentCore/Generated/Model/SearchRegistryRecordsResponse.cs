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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the SearchRegistryRecords operation.
    /// </summary>
    public partial class SearchRegistryRecordsResponse : AmazonWebServiceResponse
    {
        private List<RegistryRecordSummary> _registryRecords = AWSConfigs.InitializeCollections ? new List<RegistryRecordSummary>() : null;

        /// <summary>
        /// Gets and sets the property RegistryRecords. 
        /// <para>
        ///  The list of registry records that match the search query, ordered by relevance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RegistryRecordSummary> RegistryRecords
        {
            get { return this._registryRecords; }
            set { this._registryRecords = value; }
        }

        // Check to see if RegistryRecords property is set
        internal bool IsSetRegistryRecords()
        {
            return this._registryRecords != null && (this._registryRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}