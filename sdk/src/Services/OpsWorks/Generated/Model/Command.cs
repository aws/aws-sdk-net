/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes a command.
    /// </summary>
    public partial class Command
    {
        private string _acknowledgedAt;
        private string _commandId;
        private string _completedAt;
        private string _createdAt;
        private string _deploymentId;
        private int? _exitCode;
        private string _instanceId;
        private string _logUrl;
        private string _status;
        private string _type;

        /// <summary>
        /// Gets and sets the property AcknowledgedAt. 
        /// <para>
        /// Date and time when the command was acknowledged.
        /// </para>
        /// </summary>
        public string AcknowledgedAt
        {
            get { return this._acknowledgedAt; }
            set { this._acknowledgedAt = value; }
        }

        // Check to see if AcknowledgedAt property is set
        internal bool IsSetAcknowledgedAt()
        {
            return this._acknowledgedAt != null;
        }

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The command ID.
        /// </para>
        /// </summary>
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// Date when the command completed.
        /// </para>
        /// </summary>
        public string CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date and time when the command was run.
        /// </para>
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The command deployment ID.
        /// </para>
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property ExitCode. 
        /// <para>
        /// The command exit code.
        /// </para>
        /// </summary>
        public int ExitCode
        {
            get { return this._exitCode.GetValueOrDefault(); }
            set { this._exitCode = value; }
        }

        // Check to see if ExitCode property is set
        internal bool IsSetExitCode()
        {
            return this._exitCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance where the command was executed.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LogUrl. 
        /// <para>
        /// The URL of the command log.
        /// </para>
        /// </summary>
        public string LogUrl
        {
            get { return this._logUrl; }
            set { this._logUrl = value; }
        }

        // Check to see if LogUrl property is set
        internal bool IsSetLogUrl()
        {
            return this._logUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The command status:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// failed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// successful
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// skipped
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// pending
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The command type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>configure</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deploy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>execute_recipes</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>install_dependencies</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restart</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rollback</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>setup</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>start</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stop</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>undeploy</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>update_custom_cookbooks</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>update_dependencies</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}