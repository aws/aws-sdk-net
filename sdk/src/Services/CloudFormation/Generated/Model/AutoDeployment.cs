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
    /// Describes whether StackSets automatically deploys to Organizations accounts that are
    /// added to a target organization or organizational unit (OU). For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-orgs-manage-auto-deployment.html">Enable
    /// or disable automatic deployments for StackSets in Organizations</a> in the <i>CloudFormation
    /// User Guide</i>.
    /// </summary>
    public partial class AutoDeployment
    {
        private List<string> _dependsOn = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _enabled;
        private bool? _retainStacksOnAccountRemoval;

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of StackSet ARNs that this StackSet depends on for auto-deployment operations.
        /// When auto-deployment is triggered, operations will be sequenced to ensure all dependencies
        /// complete successfully before this StackSet's operation begins.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && (this._dependsOn.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If set to <c>true</c>, StackSets automatically deploys additional stack instances
        /// to Organizations accounts that are added to a target organization or organizational
        /// unit (OU) in the specified Regions. If an account is removed from a target organization
        /// or OU, StackSets deletes stack instances from the account in the specified Regions.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetainStacksOnAccountRemoval. 
        /// <para>
        /// If set to <c>true</c>, stack resources are retained when an account is removed from
        /// a target organization or OU. If set to <c>false</c>, stack resources are deleted.
        /// Specify only if <c>Enabled</c> is set to <c>True</c>.
        /// </para>
        /// </summary>
        public bool? RetainStacksOnAccountRemoval
        {
            get { return this._retainStacksOnAccountRemoval; }
            set { this._retainStacksOnAccountRemoval = value; }
        }

        // Check to see if RetainStacksOnAccountRemoval property is set
        internal bool IsSetRetainStacksOnAccountRemoval()
        {
            return this._retainStacksOnAccountRemoval.HasValue; 
        }

    }
}