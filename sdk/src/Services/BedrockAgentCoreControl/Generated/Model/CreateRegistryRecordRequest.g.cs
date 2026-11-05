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
    /// Container for the parameters to the CreateRegistryRecord operation. Creates a new
    /// registry record within the specified registry. A registry record represents an individual
    /// AI resource's metadata in the registry. This could be an MCP server (and associated
    /// tools), A2A agent, agent skill, or a custom resource with a custom schema. <para>
    /// The record is processed asynchronously and returns HTTP 202 Accepted. </para>
    /// </summary>
    public partial class CreateRegistryRecordRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DescriptorType. 
        /// <para>
        /// The descriptor type of the registry record.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MCP</c> - Model Context Protocol descriptor for MCP-compatible servers and tools.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>A2A</c> - Agent-to-Agent protocol descriptor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM</c> - Custom descriptor type for resources such as APIs, Lambda functions,
        /// or servers not conforming to a standard protocol.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AGENT_SKILLS</c> - Agent skills descriptor for defining agent skill definitions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DescriptorType DescriptorType { get; set; }

        /// <summary>
        /// Checks to see if the DescriptorType property is set.
        /// </summary>
        internal bool IsSetDescriptorType() => this.DescriptorType != null;

        /// <summary>
        /// Gets and sets the property Descriptors. 
        /// <para>
        /// The descriptor-type-specific configuration containing the resource schema and metadata.
        /// The structure of this field depends on the <c>descriptorType</c> you specify.
        /// </para>
        /// </summary>
        public Descriptors Descriptors { get; set; }

        /// <summary>
        /// Checks to see if the Descriptors property is set.
        /// </summary>
        internal bool IsSetDescriptors() => this.Descriptors != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the registry record.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecordVersion. 
        /// <para>
        /// The version of the registry record. Use this to track different versions of the record's
        /// content.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RecordVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecordVersion property is set.
        /// </summary>
        internal bool IsSetRecordVersion() => this.RecordVersion != null;

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The identifier of the registry where the record will be created. You can specify either
        /// the Amazon Resource Name (ARN) or the ID of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property SynchronizationConfiguration. 
        /// <para>
        /// The configuration for synchronizing registry record metadata from an external source,
        /// such as a URL-based MCP server.
        /// </para>
        /// </summary>
        public SynchronizationConfiguration SynchronizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SynchronizationConfiguration property is set.
        /// </summary>
        internal bool IsSetSynchronizationConfiguration() => this.SynchronizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property SynchronizationType. 
        /// <para>
        /// The type of synchronization to use for keeping the record metadata up to date from
        /// an external source. Possible values include <c>FROM_URL</c> and <c>NONE</c>.
        /// </para>
        /// </summary>
        public SynchronizationType SynchronizationType { get; set; }

        /// <summary>
        /// Checks to see if the SynchronizationType property is set.
        /// </summary>
        internal bool IsSetSynchronizationType() => this.SynchronizationType != null;
    }
}
