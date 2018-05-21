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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// A structure that contains information about a stack set. A stack set enables you to
    /// provision stacks into AWS accounts and across regions by using a single CloudFormation
    /// template. In the stack set, you specify the template to use, as well as any parameters
    /// and capabilities that the template requires.
    /// </summary>
    public partial class StackSet
    {
        private string _administrationRoleARN;
        private List<string> _capabilities = new List<string>();
        private string _description;
        private string _executionRoleName;
        private List<Parameter> _parameters = new List<Parameter>();
        private string _stackSetARN;
        private string _stackSetId;
        private string _stackSetName;
        private StackSetStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private string _templateBody;

        /// <summary>
        /// Gets and sets the property AdministrationRoleARN. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the IAM role used to create or update the stack
        /// set.
        /// </para>
        ///  
        /// <para>
        /// Use customized administrator roles to control which users or groups can manage specific
        /// stack sets within the same administrator account. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs.html">Prerequisites:
        /// Granting Permissions for Stack Set Operations</a> in the <i>AWS CloudFormation User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string AdministrationRoleARN
        {
            get { return this._administrationRoleARN; }
            set { this._administrationRoleARN = value; }
        }

        // Check to see if AdministrationRoleARN property is set
        internal bool IsSetAdministrationRoleARN()
        {
            return this._administrationRoleARN != null;
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities that are allowed in the stack set. Some stack set templates might
        /// include resources that can affect permissions in your AWS account—for example, by
        /// creating new AWS Identity and Access Management (IAM) users. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html#capabilities">Acknowledging
        /// IAM Resources in AWS CloudFormation Templates.</a> 
        /// </para>
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the stack set that you specify when the stack set is created or updated.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleName. 
        /// <para>
        /// The name of the IAM execution role used to create or update the stack set. 
        /// </para>
        ///  
        /// <para>
        /// Use customized execution roles to control which stack resources users and groups can
        /// include in their stack sets. 
        /// </para>
        /// </summary>
        public string ExecutionRoleName
        {
            get { return this._executionRoleName; }
            set { this._executionRoleName = value; }
        }

        // Check to see if ExecutionRoleName property is set
        internal bool IsSetExecutionRoleName()
        {
            return this._executionRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of input parameters for a stack set.
        /// </para>
        /// </summary>
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackSetARN. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the stack set.
        /// </para>
        /// </summary>
        public string StackSetARN
        {
            get { return this._stackSetARN; }
            set { this._stackSetARN = value; }
        }

        // Check to see if StackSetARN property is set
        internal bool IsSetStackSetARN()
        {
            return this._stackSetARN != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetId. 
        /// <para>
        /// The ID of the stack set.
        /// </para>
        /// </summary>
        public string StackSetId
        {
            get { return this._stackSetId; }
            set { this._stackSetId = value; }
        }

        // Check to see if StackSetId property is set
        internal bool IsSetStackSetId()
        {
            return this._stackSetId != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name that's associated with the stack set.
        /// </para>
        /// </summary>
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the stack set.
        /// </para>
        /// </summary>
        public StackSetStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that specify information about the stack set. A maximum number of 50
        /// tags can be specified.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// The structure that contains the body of the template that was used to create or update
        /// the stack set.
        /// </para>
        /// </summary>
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

    }
}