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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApprovalPolicy operation.
    /// Updates an approval policy in Quick Sight.
    /// </summary>
    public partial class UpdateApprovalPolicyRequest : AmazonQuickSightRequest
    {
        private List<string> _actions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ApplicableTo _applicableTo;
        private List<string> _approvalGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _assetTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _name;
        private string _policyId;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The list of governed actions that trigger the approval workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplicableTo. 
        /// <para>
        /// The scoping configuration that determines who the approval policy applies to.
        /// </para>
        /// </summary>
        public ApplicableTo ApplicableTo
        {
            get { return this._applicableTo; }
            set { this._applicableTo = value; }
        }

        // Check to see if ApplicableTo property is set
        internal bool IsSetApplicableTo()
        {
            return this._applicableTo != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovalGroups. 
        /// <para>
        /// The list of group ARNs whose members can approve requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> ApprovalGroups
        {
            get { return this._approvalGroups; }
            set { this._approvalGroups = value; }
        }

        // Check to see if ApprovalGroups property is set
        internal bool IsSetApprovalGroups()
        {
            return this._approvalGroups != null && (this._approvalGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssetTypes. 
        /// <para>
        /// The list of asset types that the approval policy applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> AssetTypes
        {
            get { return this._assetTypes; }
            set { this._assetTypes = value; }
        }

        // Check to see if AssetTypes property is set
        internal bool IsSetAssetTypes()
        {
            return this._assetTypes != null && (this._assetTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the approval policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the approval policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier of the approval policy to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

    }
}