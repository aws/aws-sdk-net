/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Describes a command.</para>
    /// </summary>
    public class Command
    {
        
        private string commandId;
        private string instanceId;
        private string deploymentId;
        private string createdAt;
        private string acknowledgedAt;
        private string completedAt;
        private string status;
        private int? exitCode;
        private string logUrl;
        private string type;


        /// <summary>
        /// The command ID.
        ///  
        /// </summary>
        public string CommandId
        {
            get { return this.commandId; }
            set { this.commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this.commandId != null;
        }

        /// <summary>
        /// The ID of the instance where the command was executed.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The command deployment ID.
        ///  
        /// </summary>
        public string DeploymentId
        {
            get { return this.deploymentId; }
            set { this.deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this.deploymentId != null;
        }

        /// <summary>
        /// Date and time when the command was run.
        ///  
        /// </summary>
        public string CreatedAt
        {
            get { return this.createdAt; }
            set { this.createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this.createdAt != null;
        }

        /// <summary>
        /// Date and time when the command was acknowledged.
        ///  
        /// </summary>
        public string AcknowledgedAt
        {
            get { return this.acknowledgedAt; }
            set { this.acknowledgedAt = value; }
        }

        // Check to see if AcknowledgedAt property is set
        internal bool IsSetAcknowledgedAt()
        {
            return this.acknowledgedAt != null;
        }

        /// <summary>
        /// Date when the command completed.
        ///  
        /// </summary>
        public string CompletedAt
        {
            get { return this.completedAt; }
            set { this.completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this.completedAt != null;
        }

        /// <summary>
        /// The command status: <ul> <li>failed</li> <li>successful</li> <li>skipped</li> <li>pending</li> </ul>
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The command exit code.
        ///  
        /// </summary>
        public int ExitCode
        {
            get { return this.exitCode ?? default(int); }
            set { this.exitCode = value; }
        }

        // Check to see if ExitCode property is set
        internal bool IsSetExitCode()
        {
            return this.exitCode.HasValue;
        }

        /// <summary>
        /// The URL of the command log.
        ///  
        /// </summary>
        public string LogUrl
        {
            get { return this.logUrl; }
            set { this.logUrl = value; }
        }

        // Check to see if LogUrl property is set
        internal bool IsSetLogUrl()
        {
            return this.logUrl != null;
        }

        /// <summary>
        /// The command type: <ul> <li><c>deploy</c></li> <li><c>rollback</c></li> <li><c>start</c></li> <li><c>stop</c></li> <li><c>restart</c></li>
        /// <li><c>undeploy</c></li> <li><c>update_dependencies</c></li> <li><c>install_dependencies</c></li> <li><c>update_custom_cookbooks</c></li>
        /// <li><c>execute_recipes</c></li> </ul>
        ///  
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }
    }
}
