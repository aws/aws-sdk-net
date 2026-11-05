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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CancelCommand operation. Attempts to cancel the
    /// command specified by the Command ID. There is no guarantee that the command will be
    /// terminated and the underlying process stopped.
    /// </summary>
    public partial class CancelCommandRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CancelCommandRequest() { }

        /// <summary>
        /// Instantiates CancelCommandRequest with the parameterized properties
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        public CancelCommandRequest(string commandId)
        {
            this.CommandId = commandId;
        }

        /// <summary>
        /// Instantiates CancelCommandRequest with the parameterized properties
        /// </summary>
        /// <param name="commandId">The ID of the command you want to cancel.</param>
        /// <param name="instanceIds">(Optional) A list of managed node IDs on which you want to cancel the command. If not   provided, the command is canceled on every node on which it was requested.</param>
        public CancelCommandRequest(string commandId, List<string> instanceIds)
        {
            this.CommandId = commandId;
            this.InstanceIds = instanceIds;
        }

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The ID of the command you want to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CommandId { get; set; }

        /// <summary>
        /// Checks to see if the CommandId property is set.
        /// </summary>
        internal bool IsSetCommandId() => this.CommandId != null;

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// (Optional) A list of managed node IDs on which you want to cancel the command. If
        /// not provided, the command is canceled on every node on which it was requested.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> InstanceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceIds property is set.
        /// </summary>
        internal bool IsSetInstanceIds() => this.InstanceIds != null && (this.InstanceIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
