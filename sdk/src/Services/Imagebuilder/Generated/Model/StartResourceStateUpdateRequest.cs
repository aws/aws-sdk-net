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
    /// Container for the parameters to the StartResourceStateUpdate operation.
    /// Begins an ad-hoc state change for the specified image build version. This is a one-time
    /// operation - if you schedule the update, it runs only once. If the request includes
    /// underlying resources, or schedules the update far enough in the future, Image Builder
    /// runs the update as an asynchronous lifecycle execution and returns its identifier.
    /// Otherwise, for target states other than <c>DELETED</c>, the state change applies immediately.
    /// If a request that starts a lifecycle execution arrives while the image already has
    /// one in progress, Image Builder rejects it.
    /// </summary>
    public partial class StartResourceStateUpdateRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private ResourceStateUpdateExclusionRules _exclusionRules;
        private string _executionRole;
        private ResourceStateUpdateIncludeResources _includeResources;
        private string _resourceArn;
        private ResourceState _state;
        private DateTime? _updateAt;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure that the operation runs
        /// no more than one time. If you retry a request with the same client token, Image Builder
        /// returns the original response without running the operation again. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ExclusionRules. 
        /// <para>
        /// Rules that Image Builder evaluates against each of the image's AMIs. Matching AMIs
        /// and their snapshots are skipped. Exclusion rules only take effect when the request
        /// includes AMIs. If the target state is <c>DELETED</c> and any resource was skipped,
        /// the Image Builder image resource itself is also retained. For the <c>DEPRECATED</c>
        /// and <c>DISABLED</c> target states, Image Builder updates the image resource's state
        /// regardless of exclusions.
        /// </para>
        /// </summary>
        public ResourceStateUpdateExclusionRules ExclusionRules
        {
            get { return this._exclusionRules; }
            set { this._exclusionRules = value; }
        }

        // Check to see if ExclusionRules property is set
        internal bool IsSetExclusionRules()
        {
            return this._exclusionRules != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the IAM role that's used to update image
        /// state. You must provide this property together with <c>includeResources</c>. Neither
        /// is valid without the other.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property IncludeResources. 
        /// <para>
        /// Specifies which underlying resources to update, in addition to the Image Builder image
        /// resource itself. Snapshots and containers are only valid for the <c>DELETED</c> state.
        /// To set an image to <c>DELETED</c>, you must include its underlying resources. To delete
        /// only the Image Builder image record, use the <a>DeleteImage</a> operation instead.
        /// </para>
        /// </summary>
        public ResourceStateUpdateIncludeResources IncludeResources
        {
            get { return this._includeResources; }
            set { this._includeResources = value; }
        }

        // Check to see if IncludeResources property is set
        internal bool IsSetIncludeResources()
        {
            return this._includeResources != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image build version to update. The image must
        /// be in one of these terminal states: <c>AVAILABLE</c>, <c>DEPRECATED</c>, <c>DISABLED</c>,
        /// <c>FAILED</c>, or <c>CANCELLED</c>. Images with <c>FAILED</c> or <c>CANCELLED</c>
        /// status can transition only to <c>DELETED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Specifies the lifecycle action to take for this request. For AMI-based images, valid
        /// values are <c>AVAILABLE</c>, <c>DEPRECATED</c>, <c>DISABLED</c>, and <c>DELETED</c>.
        /// For container-based images, only <c>DELETED</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateAt. 
        /// <para>
        /// The timestamp that indicates when resources are updated by a lifecycle action. This
        /// property is valid only when the target status is <c>DEPRECATED</c>, and the value
        /// must be a future time. If you don't specify a value, Image Builder begins the state
        /// update right away. For a scheduled deprecation, included AMIs get their EC2 deprecation
        /// time set immediately, and Image Builder schedules the image resource to transition
        /// to <c>DEPRECATED</c> at that time.
        /// </para>
        /// </summary>
        public DateTime? UpdateAt
        {
            get { return this._updateAt; }
            set { this._updateAt = value; }
        }

        // Check to see if UpdateAt property is set
        internal bool IsSetUpdateAt()
        {
            return this._updateAt.HasValue; 
        }

    }
}