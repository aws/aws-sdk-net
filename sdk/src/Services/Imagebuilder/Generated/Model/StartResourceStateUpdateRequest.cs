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
    /// Begin asynchronous resource state update for lifecycle changes to the specified image
    /// resources.
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
        /// Gets and sets the property ExclusionRules. 
        /// <para>
        /// Skip action on the image resource and associated resources if specified exclusion
        /// rules are met.
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
        /// The name or Amazon Resource Name (ARN) of the IAM role that’s used to update image
        /// state.
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
        /// A list of image resources to update state for.
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
        /// The ARN of the Image Builder resource that is updated. The state update might also
        /// impact associated resources.
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
        /// Indicates the lifecycle action to take for this request.
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
        /// The timestamp that indicates when resources are updated by a lifecycle action.
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