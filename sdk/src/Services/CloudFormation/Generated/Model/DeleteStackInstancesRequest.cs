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
    /// Container for the parameters to the DeleteStackInstances operation.
    /// Deletes stack instances for the specified accounts, in the specified Regions.
    /// </summary>
    public partial class DeleteStackInstancesRequest : AmazonCloudFormationRequest
    {
        private List<string> _accounts = new List<string>();
        private DeploymentTargets _deploymentTargets;
        private string _operationId;
        private StackSetOperationPreferences _operationPreferences;
        private List<string> _regions = new List<string>();
        private bool? _retainStacks;
        private string _stackSetName;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// [<code>Self-managed</code> permissions] The names of the AWS accounts that you want
        /// to delete stack instances for.
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
        /// Gets and sets the property DeploymentTargets. 
        /// <para>
        /// [<code>Service-managed</code> permissions] The AWS Organizations accounts from which
        /// to delete stack instances.
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
        /// If you don't specify an operation ID, the SDK generates one automatically. 
        /// </para>
        ///  
        /// <para>
        /// The operation ID also functions as an idempotency token, to ensure that AWS CloudFormation
        /// performs the stack set operation only once, even if you retry the request multiple
        /// times. You can retry stack set operation requests to ensure that AWS CloudFormation
        /// successfully received them.
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
        /// Preferences for how AWS CloudFormation performs this stack set operation.
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
        /// Gets and sets the property Regions. 
        /// <para>
        /// The Regions where you want to delete stack set instances. 
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
        /// Gets and sets the property RetainStacks. 
        /// <para>
        /// Removes the stack instances from the specified stack set, but doesn't delete the stacks.
        /// You can't reassociate a retained stack or add an existing, saved stack to a new stack
        /// set.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-ops-options">Stack
        /// set operation options</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool RetainStacks
        {
            get { return this._retainStacks.GetValueOrDefault(); }
            set { this._retainStacks = value; }
        }

        // Check to see if RetainStacks property is set
        internal bool IsSetRetainStacks()
        {
            return this._retainStacks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name or unique ID of the stack set that you want to delete stack instances for.
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