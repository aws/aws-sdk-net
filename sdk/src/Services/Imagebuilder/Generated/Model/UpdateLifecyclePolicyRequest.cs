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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLifecyclePolicy operation.
    /// Update the specified lifecycle policy.
    /// </summary>
    public partial class UpdateLifecyclePolicyRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private string _description;
        private string _executionRole;
        private string _lifecyclePolicyArn;
        private List<LifecyclePolicyDetail> _policyDetails = AWSConfigs.InitializeCollections ? new List<LifecyclePolicyDetail>() : null;
        private LifecyclePolicyResourceSelection _resourceSelection;
        private LifecyclePolicyResourceType _resourceType;
        private LifecyclePolicyStatus _status;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional description for the lifecycle policy.
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
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the IAM role that Image Builder uses to
        /// update the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the lifecycle policy resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string LifecyclePolicyArn
        {
            get { return this._lifecyclePolicyArn; }
            set { this._lifecyclePolicyArn = value; }
        }

        // Check to see if LifecyclePolicyArn property is set
        internal bool IsSetLifecyclePolicyArn()
        {
            return this._lifecyclePolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDetails. 
        /// <para>
        /// The configuration details for a lifecycle policy resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<LifecyclePolicyDetail> PolicyDetails
        {
            get { return this._policyDetails; }
            set { this._policyDetails = value; }
        }

        // Check to see if PolicyDetails property is set
        internal bool IsSetPolicyDetails()
        {
            return this._policyDetails != null && (this._policyDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceSelection. 
        /// <para>
        /// Selection criteria for resources that the lifecycle policy applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecyclePolicyResourceSelection ResourceSelection
        {
            get { return this._resourceSelection; }
            set { this._resourceSelection = value; }
        }

        // Check to see if ResourceSelection property is set
        internal bool IsSetResourceSelection()
        {
            return this._resourceSelection != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of image resource that the lifecycle policy applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecyclePolicyResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates whether the lifecycle policy resource is enabled.
        /// </para>
        /// </summary>
        public LifecyclePolicyStatus Status
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