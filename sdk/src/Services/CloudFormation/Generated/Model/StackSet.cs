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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// A structure that contains information about a stack set. A stack set enables you to
    /// provision stacks into Amazon Web Services accounts and across Regions by using a single
    /// CloudFormation template. In the stack set, you specify the template to use, in addition
    /// to any parameters and capabilities that the template requires.
    /// </summary>
    public partial class StackSet
    {
        private string _administrationRoleARN;
        private AutoDeployment _autoDeployment;
        private List<string> _capabilities = new List<string>();
        private string _description;
        private string _executionRoleName;
        private ManagedExecution _managedExecution;
        private List<string> _organizationalUnitIds = new List<string>();
        private List<Parameter> _parameters = new List<Parameter>();
        private PermissionModels _permissionModel;
        private List<string> _regions = new List<string>();
        private string _stackSetARN;
        private StackSetDriftDetectionDetails _stackSetDriftDetectionDetails;
        private string _stackSetId;
        private string _stackSetName;
        private StackSetStatus _status;
        private List<Tag> _tags = new List<Tag>();
        private string _templateBody;

        /// <summary>
        /// Gets and sets the property AdministrationRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to create or update the stack
        /// set.
        /// </para>
        ///  
        /// <para>
        /// Use customized administrator roles to control which users or groups can manage specific
        /// stack sets within the same administrator account. For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs.html">Prerequisites:
        /// Granting Permissions for Stack Set Operations</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property AutoDeployment. 
        /// <para>
        /// [Service-managed permissions] Describes whether StackSets automatically deploys to
        /// Organizations accounts that are added to a target organization or organizational unit
        /// (OU).
        /// </para>
        /// </summary>
        public AutoDeployment AutoDeployment
        {
            get { return this._autoDeployment; }
            set { this._autoDeployment = value; }
        }

        // Check to see if AutoDeployment property is set
        internal bool IsSetAutoDeployment()
        {
            return this._autoDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// The capabilities that are allowed in the stack set. Some stack set templates might
        /// include resources that can affect permissions in your Amazon Web Services account—for
        /// example, by creating new Identity and Access Management (IAM) users. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-iam-template.html#capabilities">Acknowledging
        /// IAM Resources in CloudFormation Templates.</a> 
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
        [AWSProperty(Min=1, Max=1024)]
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
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ManagedExecution. 
        /// <para>
        /// Describes whether StackSets performs non-conflicting operations concurrently and queues
        /// conflicting operations.
        /// </para>
        /// </summary>
        public ManagedExecution ManagedExecution
        {
            get { return this._managedExecution; }
            set { this._managedExecution = value; }
        }

        // Check to see if ManagedExecution property is set
        internal bool IsSetManagedExecution()
        {
            return this._managedExecution != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitIds. 
        /// <para>
        /// [Service-managed permissions] The organization root ID or organizational unit (OU)
        /// IDs that you specified for <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_DeploymentTargets.html">DeploymentTargets</a>.
        /// </para>
        /// </summary>
        public List<string> OrganizationalUnitIds
        {
            get { return this._organizationalUnitIds; }
            set { this._organizationalUnitIds = value; }
        }

        // Check to see if OrganizationalUnitIds property is set
        internal bool IsSetOrganizationalUnitIds()
        {
            return this._organizationalUnitIds != null && this._organizationalUnitIds.Count > 0; 
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
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Describes how the IAM roles required for stack set operations are created.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <code>self-managed</code> permissions, you must create the administrator and
        /// execution roles required to deploy to target accounts. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-self-managed.html">Grant
        /// Self-Managed Stack Set Permissions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <code>service-managed</code> permissions, StackSets automatically creates the
        /// IAM roles required to deploy to accounts managed by Organizations. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-service-managed.html">Grant
        /// Service-Managed Stack Set Permissions</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionModels PermissionModel
        {
            get { return this._permissionModel; }
            set { this._permissionModel = value; }
        }

        // Check to see if PermissionModel property is set
        internal bool IsSetPermissionModel()
        {
            return this._permissionModel != null;
        }

        /// <summary>
        /// Gets and sets the property Regions.
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && this._regions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackSetARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the stack set.
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
        /// Gets and sets the property StackSetDriftDetectionDetails. 
        /// <para>
        /// Detailed information about the drift status of the stack set.
        /// </para>
        ///  
        /// <para>
        /// For stack sets, contains information about the last <i>completed</i> drift operation
        /// performed on the stack set. Information about drift operations currently in progress
        /// isn't included.
        /// </para>
        /// </summary>
        public StackSetDriftDetectionDetails StackSetDriftDetectionDetails
        {
            get { return this._stackSetDriftDetectionDetails; }
            set { this._stackSetDriftDetectionDetails = value; }
        }

        // Check to see if StackSetDriftDetectionDetails property is set
        internal bool IsSetStackSetDriftDetectionDetails()
        {
            return this._stackSetDriftDetectionDetails != null;
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
        [AWSProperty(Max=50)]
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
        [AWSProperty(Min=1)]
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