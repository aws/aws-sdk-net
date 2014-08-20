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
    /// Describes a deployment of a stack or app.
    /// </summary>
    public partial class Deployment
    {
        private string _appId;
        private DeploymentCommand _command;
        private string _comment;
        private string _completedAt;
        private string _createdAt;
        private string _customJson;
        private string _deploymentId;
        private int? _duration;
        private string _iamUserArn;
        private List<string> _instanceIds = new List<string>();
        private string _stackId;
        private string _status;


        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The app ID.
        /// </para>
        /// </summary>
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }


        /// <summary>
        /// Gets and sets the property Command.
        /// </summary>
        public DeploymentCommand Command
        {
            get { return this._command; }
            set { this._command = value; }
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

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }


        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// Date when the deployment completed.
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
        /// Date when the deployment was created.
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
        /// Gets and sets the property CustomJson. 
        /// <para>
        /// A string that contains user-defined custom JSON. It is used to override the corresponding
        /// default stack configuration JSON values for stack. The string should be in the following
        /// format and must escape characters such as '"'.:
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

        // Check to see if CustomJson property is set
        internal bool IsSetCustomJson()
        {
            return this._customJson != null;
        }


        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The deployment ID.
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
        /// Gets and sets the property Duration. 
        /// <para>
        /// The deployment duration.
        /// </para>
        /// </summary>
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property IamUserArn. 
        /// <para>
        /// The user's IAM ARN.
        /// </para>
        /// </summary>
        public string IamUserArn
        {
            get { return this._iamUserArn; }
            set { this._iamUserArn = value; }
        }

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this._iamUserArn != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the target instances.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
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

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment status:
        /// </para>
        ///  <ul> <li>running</li> <li>successful</li> <li>failed</li> </ul>
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

    }
}