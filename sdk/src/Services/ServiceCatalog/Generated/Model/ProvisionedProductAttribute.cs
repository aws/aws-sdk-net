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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a provisioned product.
    /// </summary>
    public partial class ProvisionedProductAttribute
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _id;
        private string _idempotencyToken;
        private string _lastProvisioningRecordId;
        private string _lastRecordId;
        private string _lastSuccessfulProvisioningRecordId;
        private string _name;
        private string _physicalId;
        private string _productId;
        private string _productName;
        private string _provisioningArtifactId;
        private string _provisioningArtifactName;
        private ProvisionedProductStatus _status;
        private string _statusMessage;
        private List<Tag> _tags = new List<Tag>();
        private string _type;
        private string _userArn;
        private string _userArnSession;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The UTC time stamp of the creation time.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique identifier that you provide to ensure idempotency. If multiple requests differ
        /// only by the idempotency token, the same response is returned for each repeated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property LastProvisioningRecordId. 
        /// <para>
        /// The record identifier of the last request performed on this provisioned product of
        /// the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  ProvisionedProduct 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  UpdateProvisionedProduct 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  ExecuteProvisionedProductPlan 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  TerminateProvisionedProduct 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string LastProvisioningRecordId
        {
            get { return this._lastProvisioningRecordId; }
            set { this._lastProvisioningRecordId = value; }
        }

        // Check to see if LastProvisioningRecordId property is set
        internal bool IsSetLastProvisioningRecordId()
        {
            return this._lastProvisioningRecordId != null;
        }

        /// <summary>
        /// Gets and sets the property LastRecordId. 
        /// <para>
        /// The record identifier of the last request performed on this provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string LastRecordId
        {
            get { return this._lastRecordId; }
            set { this._lastRecordId = value; }
        }

        // Check to see if LastRecordId property is set
        internal bool IsSetLastRecordId()
        {
            return this._lastRecordId != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulProvisioningRecordId. 
        /// <para>
        /// The record identifier of the last successful request performed on this provisioned
        /// product of the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  ProvisionedProduct 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  UpdateProvisionedProduct 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  ExecuteProvisionedProductPlan 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  TerminateProvisionedProduct 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string LastSuccessfulProvisioningRecordId
        {
            get { return this._lastSuccessfulProvisioningRecordId; }
            set { this._lastSuccessfulProvisioningRecordId = value; }
        }

        // Check to see if LastSuccessfulProvisioningRecordId property is set
        internal bool IsSetLastSuccessfulProvisioningRecordId()
        {
            return this._lastSuccessfulProvisioningRecordId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user-friendly name of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
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
        /// Gets and sets the property PhysicalId. 
        /// <para>
        /// The assigned identifier for the resource, such as an EC2 instance ID or an S3 bucket
        /// name.
        /// </para>
        /// </summary>
        public string PhysicalId
        {
            get { return this._physicalId; }
            set { this._physicalId = value; }
        }

        // Check to see if PhysicalId property is set
        internal bool IsSetPhysicalId()
        {
            return this._physicalId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// The name of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8191)]
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }

        // Check to see if ProductName property is set
        internal bool IsSetProductName()
        {
            return this._productName != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProvisioningArtifactId
        {
            get { return this._provisioningArtifactId; }
            set { this._provisioningArtifactId = value; }
        }

        // Check to see if ProvisioningArtifactId property is set
        internal bool IsSetProvisioningArtifactId()
        {
            return this._provisioningArtifactId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactName. 
        /// <para>
        /// The name of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string ProvisioningArtifactName
        {
            get { return this._provisioningArtifactName; }
            set { this._provisioningArtifactName = value; }
        }

        // Check to see if ProvisioningArtifactName property is set
        internal bool IsSetProvisioningArtifactName()
        {
            return this._provisioningArtifactName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the provisioned product.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - Stable state, ready to perform any operation. The most recent
        /// operation succeeded and completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNDER_CHANGE</code> - Transitive state. Operations performed might not have
        /// valid results. Wait for an <code>AVAILABLE</code> status before performing operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TAINTED</code> - Stable state, ready to perform any operation. The stack has
        /// completed the requested operation but is not exactly what was requested. For example,
        /// a request to update to a new version failed and the stack rolled back to the current
        /// version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ERROR</code> - An unexpected error occurred. The provisioned product exists
        /// but the stack is not running. For example, CloudFormation received a parameter value
        /// that was not valid and could not launch the stack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PLAN_IN_PROGRESS</code> - Transitive state. The plan operations were performed
        /// to provision a new product, but resources have not yet been created. After reviewing
        /// the list of resources to be created, execute the plan. Wait for an <code>AVAILABLE</code>
        /// status before performing operations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProvisionedProductStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The current status message of the provisioned product.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of provisioned product. The supported values are <code>CFN_STACK</code> and
        /// <code>CFN_STACKSET</code>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user.
        /// </para>
        /// </summary>
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserArnSession. 
        /// <para>
        /// The ARN of the user in the session. This ARN might contain a session ID.
        /// </para>
        /// </summary>
        public string UserArnSession
        {
            get { return this._userArnSession; }
            set { this._userArnSession = value; }
        }

        // Check to see if UserArnSession property is set
        internal bool IsSetUserArnSession()
        {
            return this._userArnSession != null;
        }

    }
}