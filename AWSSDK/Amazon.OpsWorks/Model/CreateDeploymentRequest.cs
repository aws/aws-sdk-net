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
    /// Container for the parameters to the CreateDeployment operation.
    /// Deploys a stack or app.
    /// 
    ///   <ul>  <li>App deployment generates a <code>deploy</code> event, which runs the associated
    /// recipes and passes them a JSON stack configuration object            that includes
    /// information about the app. </li>  <li>Stack deployment runs the <code>deploy</code>
    /// recipes but does not raise an event.</li>  </ul>  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingapps-deploying.html">Deploying
    /// Apps</a>         and <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-commands.html">Run
    /// Stack Commands</a>.
    /// </para>
    ///     
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Deploy or
    /// Manage permissions level for the stack, or an attached       policy that explicitly
    /// grants permissions. For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonWebServiceRequest
    {
        private string _appId;
        private DeploymentCommand _command;
        private string _comment;
        private string _customJson;
        private List<string> _instanceIds = new List<string>();
        private string _stackId;


        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID. This parameter is required for app deployments, but not for other deployment
        /// commands.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }


        /// <summary>
        /// Sets the AppId property
        /// </summary>
        /// <param name="appId">The value to set for the AppId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDeploymentRequest WithAppId(string appId)
        {
            this._appId = appId;
            return this;
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }


        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// A <code>DeploymentCommand</code> object that specifies the deployment command and
        /// any associated arguments.
        /// </para>
        /// </summary>
        public DeploymentCommand Command
        {
            get { return this._command; }
            set { this._command = value; }
        }


        /// <summary>
        /// Sets the Command property
        /// </summary>
        /// <param name="command">The value to set for the Command property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDeploymentRequest WithCommand(DeploymentCommand command)
        {
            this._command = command;
            return this;
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }


        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A user-defined comment.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }


        /// <summary>
        /// Sets the Comment property
        /// </summary>
        /// <param name="comment">The value to set for the Comment property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDeploymentRequest WithComment(string comment)
        {
            this._comment = comment;
            return this;
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }


        /// <summary>
        /// Gets and sets the property CustomJson. 
        /// <para>
        /// A string that contains user-defined, custom JSON. It is used to override the corresponding
        /// default stack configuration JSON values. The string should be in the following format
        /// and must escape characters such as '"'.:
        /// </para>
        ///     
        /// <para>
        /// <code>"{\"key1\": \"value1\", \"key2\": \"value2\",...}"</code>
        /// </para>
        ///   
        /// <para>
        /// For more information on custom JSON, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-json.html">Use
        /// Custom JSON to Modify the Stack Configuration JSON</a>.
        /// </para>
        /// </summary>
        public string CustomJson
        {
            get { return this._customJson; }
            set { this._customJson = value; }
        }


        /// <summary>
        /// Sets the CustomJson property
        /// </summary>
        /// <param name="customJson">The value to set for the CustomJson property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDeploymentRequest WithCustomJson(string customJson)
        {
            this._customJson = customJson;
            return this;
        }

        // Check to see if CustomJson property is set
        internal bool IsSetCustomJson()
        {
            return this._customJson != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The instance IDs for the deployment targets.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        /// <summary>
        /// Sets the InstanceIds property
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDeploymentRequest WithInstanceIds(params string[] instanceIds)
        {
            foreach (var element in instanceIds)
            {
                this._instanceIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the InstanceIds property
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDeploymentRequest WithInstanceIds(IEnumerable<string> instanceIds)
        {
            foreach (var element in instanceIds)
            {
                this._instanceIds.Add(element);
            }
            return this;
        }
        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }


        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDeploymentRequest WithStackId(string stackId)
        {
            this._stackId = stackId;
            return this;
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}