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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the ListRegistryRecords operation.
    /// Lists registry records within a registry. You can optionally filter results using
    /// the <c>name</c>, <c>status</c>, and <c>descriptorType</c> parameters. When multiple
    /// filters are specified, they are combined using AND logic.
    /// </summary>
    public partial class ListRegistryRecordsRequest : AmazonBedrockAgentCoreControlRequest
    {
        private DescriptorType _descriptorType;
        private int? _maxResults;
        private string _name;
        private string _nextToken;
        private string _registryId;
        private RegistryRecordStatus _status;

        /// <summary>
        /// Gets and sets the property DescriptorType. 
        /// <para>
        /// Filter registry records by their descriptor type. Possible values are <c>MCP</c>,
        /// <c>A2A</c>, <c>CUSTOM</c>, and <c>AGENT_SKILLS</c>.
        /// </para>
        /// </summary>
        public DescriptorType DescriptorType
        {
            get { return this._descriptorType; }
            set { this._descriptorType = value; }
        }

        // Check to see if DescriptorType property is set
        internal bool IsSetDescriptorType()
        {
            return this._descriptorType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. If the total number of results
        /// is greater than this value, use the token returned in the response in the <c>nextToken</c>
        /// field when making another request to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Filter registry records by name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, enter the token returned in the <c>nextToken</c> field in the response
        /// in this field to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The identifier of the registry to list records from. You can specify either the Amazon
        /// Resource Name (ARN) or the ID of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter registry records by their current status. Possible values include <c>CREATING</c>,
        /// <c>DRAFT</c>, <c>APPROVED</c>, <c>PENDING_APPROVAL</c>, <c>REJECTED</c>, <c>DEPRECATED</c>,
        /// <c>UPDATING</c>, <c>CREATE_FAILED</c>, and <c>UPDATE_FAILED</c>.
        /// </para>
        /// </summary>
        public RegistryRecordStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}