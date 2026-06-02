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
    /// This is the response object from the CreatePaymentManager operation.
    /// </summary>
    public partial class CreatePaymentManagerResponse : AmazonWebServiceResponse
    {
        private AuthorizerConfiguration _authorizerConfiguration;
        private PaymentsAuthorizerType _authorizerType;
        private DateTime? _createdAt;
        private string _name;
        private string _paymentManagerArn;
        private string _paymentManagerId;
        private string _roleArn;
        private PaymentManagerStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private WorkloadIdentityDetails _workloadIdentityDetails;

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration.
        /// </summary>
        public AuthorizerConfiguration AuthorizerConfiguration
        {
            get { return this._authorizerConfiguration; }
            set { this._authorizerConfiguration = value; }
        }

        // Check to see if AuthorizerConfiguration property is set
        internal bool IsSetAuthorizerConfiguration()
        {
            return this._authorizerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerType. 
        /// <para>
        /// The type of authorizer for the created payment manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentsAuthorizerType AuthorizerType
        {
            get { return this._authorizerType; }
            set { this._authorizerType = value; }
        }

        // Check to see if AuthorizerType property is set
        internal bool IsSetAuthorizerType()
        {
            return this._authorizerType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the payment manager was created.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the created payment manager.
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
        /// Gets and sets the property PaymentManagerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created payment manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=66, Max=2048)]
        public string PaymentManagerArn
        {
            get { return this._paymentManagerArn; }
            set { this._paymentManagerArn = value; }
        }

        // Check to see if PaymentManagerArn property is set
        internal bool IsSetPaymentManagerArn()
        {
            return this._paymentManagerArn != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentManagerId. 
        /// <para>
        /// The unique identifier of the created payment manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=211)]
        public string PaymentManagerId
        {
            get { return this._paymentManagerId; }
            set { this._paymentManagerId = value; }
        }

        // Check to see if PaymentManagerId property is set
        internal bool IsSetPaymentManagerId()
        {
            return this._paymentManagerId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the created payment
        /// manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the payment manager. Possible values include <c>CREATING</c>,
        /// <c>READY</c>, <c>UPDATING</c>, <c>DELETING</c>, <c>CREATE_FAILED</c>, <c>UPDATE_FAILED</c>,
        /// and <c>DELETE_FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PaymentManagerStatus Status
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
        /// The tags associated with the created payment manager.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadIdentityDetails.
        /// </summary>
        public WorkloadIdentityDetails WorkloadIdentityDetails
        {
            get { return this._workloadIdentityDetails; }
            set { this._workloadIdentityDetails = value; }
        }

        // Check to see if WorkloadIdentityDetails property is set
        internal bool IsSetWorkloadIdentityDetails()
        {
            return this._workloadIdentityDetails != null;
        }

    }
}