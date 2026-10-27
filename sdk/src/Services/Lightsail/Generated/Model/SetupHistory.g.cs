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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Returns a list of the commands that were ran on the target resource.
    /// 
    ///  
    /// <para>
    /// The status of each command is also returned.
    /// </para>
    /// </summary>
    public partial class SetupHistory
    {
        /// <summary>
        /// Gets and sets the property ExecutionDetails. 
        /// <para>
        /// Describes the full details of the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SetupExecutionDetails> ExecutionDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<SetupExecutionDetails>() : null;

        /// <summary>
        /// Checks to see if the ExecutionDetails property is set.
        /// </summary>
        internal bool IsSetExecutionDetails() => this.ExecutionDetails != null && (this.ExecutionDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// A GUID that's used to identify the operation.
        /// </para>
        /// </summary>
        public string OperationId { get; set; }

        /// <summary>
        /// Checks to see if the OperationId property is set.
        /// </summary>
        internal bool IsSetOperationId() => this.OperationId != null;

        /// <summary>
        /// Gets and sets the property Request. 
        /// <para>
        /// Information about the specified request.
        /// </para>
        /// </summary>
        public SetupRequest Request { get; set; }

        /// <summary>
        /// Checks to see if the Request property is set.
        /// </summary>
        internal bool IsSetRequest() => this.Request != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The target resource name for the request.
        /// </para>
        /// </summary>
        public SetupHistoryResource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request.
        /// </para>
        /// </summary>
        public SetupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
