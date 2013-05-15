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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeployment operation.
    /// <para>Deploys a stack or app.</para>
    /// <ul>
    /// <li>App deployment generates a <c>deploy</c> event, which runs the associated recipes and passes them a JSON stack configuration object
    /// that includes information about the app. </li>
    /// <li>Stack deployment runs the <c>deploy</c> recipes but does not raise an event.</li>
    /// 
    /// </ul>
    /// <para>For more information, see Deploying Apps and Run Stack Commands.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.CreateDeployment"/>
    public class CreateDeploymentRequest : AmazonWebServiceRequest
    {
        private string stackId;
        private string appId;
        private List<string> instanceIds = new List<string>();
        private DeploymentCommand command;
        private string comment;
        private string customJson;

        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        public CreateDeploymentRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

        /// <summary>
        /// The app ID. This parameter is required for app deployments, but not for other deployment commands.
        ///  
        /// </summary>
        public string AppId
        {
            get { return this.appId; }
            set { this.appId = value; }
        }

        /// <summary>
        /// Sets the AppId property
        /// </summary>
        /// <param name="appId">The value to set for the AppId property </param>
        /// <returns>this instance</returns>
        public CreateDeploymentRequest WithAppId(string appId)
        {
            this.appId = appId;
            return this;
        }
            

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this.appId != null;
        }

        /// <summary>
        /// The instance IDs for the deployment targets.
        ///  
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this.instanceIds; }
            set { this.instanceIds = value; }
        }
        /// <summary>
        /// Adds elements to the InstanceIds collection
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        public CreateDeploymentRequest WithInstanceIds(params string[] instanceIds)
        {
            foreach (string element in instanceIds)
            {
                this.instanceIds.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the InstanceIds collection
        /// </summary>
        /// <param name="instanceIds">The values to add to the InstanceIds collection </param>
        /// <returns>this instance</returns>
        public CreateDeploymentRequest WithInstanceIds(IEnumerable<string> instanceIds)
        {
            foreach (string element in instanceIds)
            {
                this.instanceIds.Add(element);
            }

            return this;
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this.instanceIds.Count > 0;
        }

        /// <summary>
        /// A <c>DeploymentCommand</c> object that specifies the deployment command and any associated arguments.
        ///  
        /// </summary>
        public DeploymentCommand Command
        {
            get { return this.command; }
            set { this.command = value; }
        }

        /// <summary>
        /// Sets the Command property
        /// </summary>
        /// <param name="command">The value to set for the Command property </param>
        /// <returns>this instance</returns>
        public CreateDeploymentRequest WithCommand(DeploymentCommand command)
        {
            this.command = command;
            return this;
        }
            

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this.command != null;
        }

        /// <summary>
        /// A user-defined comment.
        ///  
        /// </summary>
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        /// <summary>
        /// Sets the Comment property
        /// </summary>
        /// <param name="comment">The value to set for the Comment property </param>
        /// <returns>this instance</returns>
        public CreateDeploymentRequest WithComment(string comment)
        {
            this.comment = comment;
            return this;
        }
            

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }

        /// <summary>
        /// A string that contains user-defined, custom JSON. It is used to override the corresponding default stack configuration JSON values. The
        /// string should be in the following format and must escape characters such as '"'.: <c>"{\"key1\": \"value1\", \"key2\": \"value2\",...}"</c>
        /// For more information on custom JSON, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workingstacks-json.html"> Use Custom
        /// JSON to Modify the Stack Configuration JSON</a>.
        ///  
        /// </summary>
        public string CustomJson
        {
            get { return this.customJson; }
            set { this.customJson = value; }
        }

        /// <summary>
        /// Sets the CustomJson property
        /// </summary>
        /// <param name="customJson">The value to set for the CustomJson property </param>
        /// <returns>this instance</returns>
        public CreateDeploymentRequest WithCustomJson(string customJson)
        {
            this.customJson = customJson;
            return this;
        }
            

        // Check to see if CustomJson property is set
        internal bool IsSetCustomJson()
        {
            return this.customJson != null;
        }
    }
}
    
