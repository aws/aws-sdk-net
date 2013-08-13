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

        /// <summary>
        /// Sets the CommandId property
        /// </summary>
        /// <param name="commandId">The value to set for the CommandId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithCommandId(string commandId)
        {
            this.commandId = commandId;
            return this;
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

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithInstanceId(string instanceId)
        {
            this.instanceId = instanceId;
            return this;
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

        /// <summary>
        /// Sets the DeploymentId property
        /// </summary>
        /// <param name="deploymentId">The value to set for the DeploymentId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithDeploymentId(string deploymentId)
        {
            this.deploymentId = deploymentId;
            return this;
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

        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
            return this;
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

        /// <summary>
        /// Sets the AcknowledgedAt property
        /// </summary>
        /// <param name="acknowledgedAt">The value to set for the AcknowledgedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithAcknowledgedAt(string acknowledgedAt)
        {
            this.acknowledgedAt = acknowledgedAt;
            return this;
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

        /// <summary>
        /// Sets the CompletedAt property
        /// </summary>
        /// <param name="completedAt">The value to set for the CompletedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithCompletedAt(string completedAt)
        {
            this.completedAt = completedAt;
            return this;
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

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithStatus(string status)
        {
            this.status = status;
            return this;
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

        /// <summary>
        /// Sets the ExitCode property
        /// </summary>
        /// <param name="exitCode">The value to set for the ExitCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithExitCode(int exitCode)
        {
            this.exitCode = exitCode;
            return this;
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

        /// <summary>
        /// Sets the LogUrl property
        /// </summary>
        /// <param name="logUrl">The value to set for the LogUrl property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithLogUrl(string logUrl)
        {
            this.logUrl = logUrl;
            return this;
        }
            

        // Check to see if LogUrl property is set
        internal bool IsSetLogUrl()
        {
            return this.logUrl != null;
        }

        /// <summary>
        /// The command type: <ul> <li>deploy</li> <li>rollback</li> <li>start</li> <li>stop</li> <li>restart</li> <li>undeploy</li>
        /// <li>update_dependencies</li> <li>install_dependencies</li> <li>update_custom_cookbooks</li> <li>execute_recipes</li> </ul>
        ///  
        /// </summary>
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithType(string type)
        {
            this.type = type;
            return this;
        }
            

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }
    }
}
