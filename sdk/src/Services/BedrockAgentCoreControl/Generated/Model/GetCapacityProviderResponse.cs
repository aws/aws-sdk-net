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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the GetCapacityProvider operation.
    /// </summary>
    public partial class GetCapacityProviderResponse : AmazonWebServiceResponse
    {
        private string _capacityProviderArn;
        private string _capacityProviderId;
        private ComputeConfiguration _computeConfiguration;
        private DateTime? _createdAt;
        private string _description;
        private DateTime? _lastUpdatedAt;
        private string _name;
        private PermissionsConfiguration _permissionsConfiguration;
        private CapacityProviderStatus _status;
        private CapacityProviderStatusCode _statusCode;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property CapacityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityProviderArn
        {
            get { return this._capacityProviderArn; }
            set { this._capacityProviderArn = value; }
        }

        // Check to see if CapacityProviderArn property is set
        internal bool IsSetCapacityProviderArn()
        {
            return this._capacityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityProviderId. 
        /// <para>
        /// The unique identifier of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string CapacityProviderId
        {
            get { return this._capacityProviderId; }
            set { this._capacityProviderId = value; }
        }

        // Check to see if CapacityProviderId property is set
        internal bool IsSetCapacityProviderId()
        {
            return this._capacityProviderId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration for the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeConfiguration ComputeConfiguration
        {
            get { return this._computeConfiguration; }
            set { this._computeConfiguration = value; }
        }

        // Check to see if ComputeConfiguration property is set
        internal bool IsSetComputeConfiguration()
        {
            return this._computeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the capacity provider was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the capacity provider, if one was provided.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the capacity provider was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
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
        /// Gets and sets the property PermissionsConfiguration. 
        /// <para>
        /// The permissions configuration for the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PermissionsConfiguration PermissionsConfiguration
        {
            get { return this._permissionsConfiguration; }
            set { this._permissionsConfiguration = value; }
        }

        // Check to see if PermissionsConfiguration property is set
        internal bool IsSetPermissionsConfiguration()
        {
            return this._permissionsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the capacity provider. For possible values, see <c>CapacityProviderStatus</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityProviderStatus Status
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// A reason code for a capacity provider that is not in the <c>READY</c> state. Use this
        /// code for programmatic error handling.
        /// </para>
        /// </summary>
        public CapacityProviderStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable message that describes why the capacity provider is not in the <c>READY</c>
        /// state. Because these messages can change, use <c>statusCode</c> for programmatic error
        /// handling.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}