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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListRegistryRecords operation. Lists registry
    /// records within a registry. You can optionally filter results using the <c>name</c>,
    /// <c>status</c>, and <c>descriptorType</c> parameters. When multiple filters are specified,
    /// they are combined using AND logic.
    /// </summary>
    public partial class ListRegistryRecordsRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property DescriptorType. 
        /// <para>
        /// Filter registry records by their descriptor type. Possible values are <c>MCP</c>,
        /// <c>A2A</c>, <c>CUSTOM</c>, and <c>AGENT_SKILLS</c>.
        /// </para>
        /// </summary>
        public DescriptorType DescriptorType { get; set; }

        /// <summary>
        /// Checks to see if the DescriptorType property is set.
        /// </summary>
        internal bool IsSetDescriptorType() => this.DescriptorType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in the response. If the total number of results
        /// is greater than this value, use the token returned in the response in the <c>nextToken</c>
        /// field when making another request to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Filter registry records by name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the total number of results is greater than the <c>maxResults</c> value provided
        /// in the request, enter the token returned in the <c>nextToken</c> field in the response
        /// in this field to return the next batch of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The identifier of the registry to list records from. You can specify either the Amazon
        /// Resource Name (ARN) or the ID of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter registry records by their current status. Possible values include <c>CREATING</c>,
        /// <c>DRAFT</c>, <c>APPROVED</c>, <c>PENDING_APPROVAL</c>, <c>REJECTED</c>, <c>DEPRECATED</c>,
        /// <c>UPDATING</c>, <c>CREATE_FAILED</c>, and <c>UPDATE_FAILED</c>.
        /// </para>
        /// </summary>
        public RegistryRecordStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
