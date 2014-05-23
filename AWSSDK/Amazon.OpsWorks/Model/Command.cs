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


        /// <summary>
        /// Sets the AcknowledgedAt property
        /// </summary>
        /// <param name="acknowledgedAt">The value to set for the AcknowledgedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithAcknowledgedAt(string acknowledgedAt)
        {
            this._acknowledgedAt = acknowledgedAt;
            return this;
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


        /// <summary>
        /// Sets the CommandId property
        /// </summary>
        /// <param name="commandId">The value to set for the CommandId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithCommandId(string commandId)
        {
            this._commandId = commandId;
            return this;
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


        /// <summary>
        /// Sets the CompletedAt property
        /// </summary>
        /// <param name="completedAt">The value to set for the CompletedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithCompletedAt(string completedAt)
        {
            this._completedAt = completedAt;
            return this;
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


        /// <summary>
        /// Sets the CreatedAt property
        /// </summary>
        /// <param name="createdAt">The value to set for the CreatedAt property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithCreatedAt(string createdAt)
        {
            this._createdAt = createdAt;
            return this;
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


        /// <summary>
        /// Sets the DeploymentId property
        /// </summary>
        /// <param name="deploymentId">The value to set for the DeploymentId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithDeploymentId(string deploymentId)
        {
            this._deploymentId = deploymentId;
            return this;
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


        /// <summary>
        /// Sets the ExitCode property
        /// </summary>
        /// <param name="exitCode">The value to set for the ExitCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithExitCode(int exitCode)
        {
            this._exitCode = exitCode;
            return this;
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


        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithInstanceId(string instanceId)
        {
            this._instanceId = instanceId;
            return this;
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


        /// <summary>
        /// Sets the LogUrl property
        /// </summary>
        /// <param name="logUrl">The value to set for the LogUrl property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithLogUrl(string logUrl)
        {
            this._logUrl = logUrl;
            return this;
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
        ///   <ul>  <li>failed</li>  <li>successful</li>  <li>skipped</li>  <li>pending</li> 
        /// </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithStatus(string status)
        {
            this._status = status;
            return this;
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
        ///   <ul>  <li><code>deploy</code></li>  <li><code>rollback</code></li>  <li><code>start</code></li>
        ///  <li><code>stop</code></li>  <li><code>restart</code></li>  <li><code>undeploy</code></li>
        ///  <li><code>update_dependencies</code></li>  <li><code>install_dependencies</code></li>
        ///  <li><code>update_custom_cookbooks</code></li>  <li><code>execute_recipes</code></li>
        ///  </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }


        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The value to set for the Type property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Command WithType(string type)
        {
            this._type = type;
            return this;
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}