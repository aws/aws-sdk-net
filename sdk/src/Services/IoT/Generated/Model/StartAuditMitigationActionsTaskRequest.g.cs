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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the StartAuditMitigationActionsTask operation. Starts
    /// a task that applies a set of mitigation actions to the specified target. <para> Requires
    /// permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartAuditMitigationActionsTask</a>
    /// action. </para>
    /// </summary>
    public partial class StartAuditMitigationActionsTaskRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AuditCheckToActionsMapping. 
        /// <para>
        /// For an audit check, specifies which mitigation actions to apply. Those actions must
        /// be defined in your Amazon Web Services accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, List<string>> AuditCheckToActionsMapping { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the AuditCheckToActionsMapping property is set.
        /// </summary>
        internal bool IsSetAuditCheckToActionsMapping() => this.AuditCheckToActionsMapping != null && (this.AuditCheckToActionsMapping.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Each audit mitigation task must have a unique client request token. If you try to
        /// start a new task with the same token as a task that already exists, an exception occurs.
        /// If you omit this value, a unique client request token is generated automatically.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Specifies the audit findings to which the mitigation actions are applied. You can
        /// apply them to a type of audit check, to all findings from an audit, or to a specific
        /// set of findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuditMitigationActionsTaskTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// A unique identifier for the task. You can use this identifier to check the status
        /// of the task or to cancel it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
