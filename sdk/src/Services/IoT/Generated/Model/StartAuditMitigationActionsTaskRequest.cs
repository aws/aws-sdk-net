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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// Container for the parameters to the StartAuditMitigationActionsTask operation.
    /// Starts a task that applies a set of mitigation actions to the specified target.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartAuditMitigationActionsTask</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class StartAuditMitigationActionsTaskRequest : AmazonIoTRequest
    {
        private Dictionary<string, List<string>> _auditCheckToActionsMapping = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _clientRequestToken;
        private AuditMitigationActionsTaskTarget _target;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property AuditCheckToActionsMapping. 
        /// <para>
        /// For an audit check, specifies which mitigation actions to apply. Those actions must
        /// be defined in your Amazon Web Services accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, List<string>> AuditCheckToActionsMapping
        {
            get { return this._auditCheckToActionsMapping; }
            set { this._auditCheckToActionsMapping = value; }
        }

        // Check to see if AuditCheckToActionsMapping property is set
        internal bool IsSetAuditCheckToActionsMapping()
        {
            return this._auditCheckToActionsMapping != null && (this._auditCheckToActionsMapping.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Each audit mitigation task must have a unique client request token. If you try to
        /// start a new task with the same token as a task that already exists, an exception occurs.
        /// If you omit this value, a unique client request token is generated automatically.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Specifies the audit findings to which the mitigation actions are applied. You can
        /// apply them to a type of audit check, to all findings from an audit, or to a specific
        /// set of findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuditMitigationActionsTaskTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// A unique identifier for the task. You can use this identifier to check the status
        /// of the task or to cancel it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}