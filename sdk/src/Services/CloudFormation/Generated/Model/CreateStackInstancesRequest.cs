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
    /// Container for the parameters to the CreateStackInstances operation.
    /// Creates stack instances for the specified accounts, within the specified Amazon Web
    /// Services Regions. A stack instance refers to a stack in a specific account and Region.
    /// You must specify at least one value for either <code>Accounts</code> or <code>DeploymentTargets</code>,
    /// and you must specify at least one value for <code>Regions</code>.
    /// </summary>
    public partial class CreateStackInstancesRequest : AmazonCloudFormationRequest
    {
        private List<string> _accounts = new List<string>();
        private CallAs _callAs;
        private DeploymentTargets _deploymentTargets;
        private string _operationId;
        private StackSetOperationPreferences _operationPreferences;
        private List<Parameter> _parameterOverrides = new List<Parameter>();
        private List<string> _regions = new List<string>();
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// [Self-managed permissions] The names of one or more Amazon Web Services accounts that
        /// you want to create stack instances in the specified Region(s) for.
        /// </para>
        ///  
        /// <para>
        /// You can specify <code>Accounts</code> or <code>DeploymentTargets</code>, but not both.
        /// </para>
        /// </summary>
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && this._accounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CallAs. 
        /// <para>
        /// [Service-managed permissions] Specifies whether you are acting as an account administrator
        /// in the organization's management account or as a delegated administrator in a member
        /// account.
        /// </para>
        ///  
        /// <para>
        /// By default, <code>SELF</code> is specified. Use <code>SELF</code> for stack sets with
        /// self-managed permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <code>SELF</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <code>DELEGATED_ADMIN</code>.
        /// </para>
        ///  
        /// <para>
        /// Your Amazon Web Services account must be registered as a delegated administrator in
        /// the management account. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-delegated-admin.html">Register
        /// a delegated administrator</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CallAs CallAs
        {
            get { return this._callAs; }
            set { this._callAs = value; }
        }

        // Check to see if CallAs property is set
        internal bool IsSetCallAs()
        {
            return this._callAs != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentTargets. 
        /// <para>
        /// [Service-managed permissions] The Organizations accounts for which to create stack
        /// instances in the specified Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// You can specify <code>Accounts</code> or <code>DeploymentTargets</code>, but not both.
        /// </para>
        /// </summary>
        public DeploymentTargets DeploymentTargets
        {
            get { return this._deploymentTargets; }
            set { this._deploymentTargets = value; }
        }

        // Check to see if DeploymentTargets property is set
        internal bool IsSetDeploymentTargets()
        {
            return this._deploymentTargets != null;
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// The unique identifier for this stack set operation.
        /// </para>
        ///  
        /// <para>
        /// The operation ID also functions as an idempotency token, to ensure that CloudFormation
        /// performs the stack set operation only once, even if you retry the request multiple
        /// times. You might retry stack set operation requests to ensure that CloudFormation
        /// successfully received them.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an operation ID, the SDK generates one automatically.
        /// </para>
        ///  
        /// <para>
        /// Repeating this stack set operation with a new operation ID retries all stack instances
        /// whose status is <code>OUTDATED</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property OperationPreferences. 
        /// <para>
        /// Preferences for how CloudFormation performs this stack set operation.
        /// </para>
        /// </summary>
        public StackSetOperationPreferences OperationPreferences
        {
            get { return this._operationPreferences; }
            set { this._operationPreferences = value; }
        }

        // Check to see if OperationPreferences property is set
        internal bool IsSetOperationPreferences()
        {
            return this._operationPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterOverrides. 
        /// <para>
        /// A list of stack set parameters whose values you want to override in the selected stack
        /// instances.
        /// </para>
        ///  
        /// <para>
        /// Any overridden parameter values will be applied to all stack instances in the specified
        /// accounts and Amazon Web Services Regions. When specifying parameters and their values,
        /// be aware of how CloudFormation sets parameter values during stack instance operations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To override the current value for a parameter, include the parameter and specify its
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To leave an overridden parameter set to its present value, include the parameter and
        /// specify <code>UsePreviousValue</code> as <code>true</code>. (You can't specify both
        /// a value and set <code>UsePreviousValue</code> to <code>true</code>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To set an overridden parameter back to the value specified in the stack set, specify
        /// a parameter list but don't include the parameter in the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To leave all parameters set to their present values, don't specify this property at
        /// all.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// During stack set updates, any parameter values overridden for a stack instance aren't
        /// updated, but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only override the parameter <i>values</i> that are specified in the stack
        /// set; to add or delete a parameter itself, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the stack set template.
        /// </para>
        /// </summary>
        public List<Parameter> ParameterOverrides
        {
            get { return this._parameterOverrides; }
            set { this._parameterOverrides = value; }
        }

        // Check to see if ParameterOverrides property is set
        internal bool IsSetParameterOverrides()
        {
            return this._parameterOverrides != null && this._parameterOverrides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The names of one or more Amazon Web Services Regions where you want to create stack
        /// instances using the specified Amazon Web Services accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the stack set that you want to create stack instances from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}