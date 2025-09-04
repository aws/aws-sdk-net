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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStackInstances operation.
    /// Creates stack instances for the specified accounts, within the specified Amazon Web
    /// Services Regions. A stack instance refers to a stack in a specific account and Region.
    /// You must specify at least one value for either <c>Accounts</c> or <c>DeploymentTargets</c>,
    /// and you must specify at least one value for <c>Regions</c>.
    /// 
    ///  <note> 
    /// <para>
    /// The maximum number of organizational unit (OUs) supported by a <c>CreateStackInstances</c>
    /// operation is 50.
    /// </para>
    ///  
    /// <para>
    /// If you need more than 50, consider the following options:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Batch processing:</i> If you don't want to expose your OU hierarchy, split up
    /// the operations into multiple calls with less than 50 OUs each.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Parent OU strategy:</i> If you don't mind exposing the OU hierarchy, target a
    /// parent OU that contains all desired child OUs.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateStackInstancesRequest : AmazonCloudFormationRequest
    {
        private List<string> _accounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private CallAs _callAs;
        private DeploymentTargets _deploymentTargets;
        private string _operationId;
        private StackSetOperationPreferences _operationPreferences;
        private List<Parameter> _parameterOverrides = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// [Self-managed permissions] The account IDs of one or more Amazon Web Services accounts
        /// that you want to create stack instances in the specified Region(s) for.
        /// </para>
        ///  
        /// <para>
        /// You can specify <c>Accounts</c> or <c>DeploymentTargets</c>, but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// By default, <c>SELF</c> is specified. Use <c>SELF</c> for StackSets with self-managed
        /// permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are signed in to the management account, specify <c>SELF</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are signed in to a delegated administrator account, specify <c>DELEGATED_ADMIN</c>.
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
        /// [Service-managed permissions] The Organizations accounts in which to create stack
        /// instances in the specified Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// You can specify <c>Accounts</c> or <c>DeploymentTargets</c>, but not both.
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
        /// The unique identifier for this StackSet operation.
        /// </para>
        ///  
        /// <para>
        /// The operation ID also functions as an idempotency token, to ensure that CloudFormation
        /// performs the StackSet operation only once, even if you retry the request multiple
        /// times. You might retry StackSet operation requests to ensure that CloudFormation successfully
        /// received them.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify an operation ID, the SDK generates one automatically.
        /// </para>
        ///  
        /// <para>
        /// Repeating this StackSet operation with a new operation ID retries all stack instances
        /// whose status is <c>OUTDATED</c>.
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
        /// Preferences for how CloudFormation performs this StackSet operation.
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
        /// A list of StackSet parameters whose values you want to override in the selected stack
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
        /// specify <c>UsePreviousValue</c> as <c>true</c>. (You can't specify both a value and
        /// set <c>UsePreviousValue</c> to <c>true</c>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To set an overridden parameter back to the value specified in the StackSet, specify
        /// a parameter list but don't include the parameter in the list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To leave all parameters set to their present values, don't specify this property at
        /// all.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// During StackSet updates, any parameter values overridden for a stack instance aren't
        /// updated, but retain their overridden value.
        /// </para>
        ///  
        /// <para>
        /// You can only override the parameter <i>values</i> that are specified in the StackSet;
        /// to add or delete a parameter itself, use <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_UpdateStackSet.html">UpdateStackSet</a>
        /// to update the StackSet template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Parameter> ParameterOverrides
        {
            get { return this._parameterOverrides; }
            set { this._parameterOverrides = value; }
        }

        // Check to see if ParameterOverrides property is set
        internal bool IsSetParameterOverrides()
        {
            return this._parameterOverrides != null && (this._parameterOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The names of one or more Amazon Web Services Regions where you want to create stack
        /// instances using the specified Amazon Web Services accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the StackSet that you want to create stack instances from.
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