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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a request operation.
    /// </summary>
    public partial class RecordDetail
    {
        private DateTime? _createdTime;
        private string _launchRoleArn;
        private string _pathId;
        private string _productId;
        private string _provisionedProductId;
        private string _provisionedProductName;
        private string _provisionedProductType;
        private string _provisioningArtifactId;
        private List<RecordError> _recordErrors = AWSConfigs.InitializeCollections ? new List<RecordError>() : null;
        private string _recordId;
        private List<RecordTag> _recordTags = AWSConfigs.InitializeCollections ? new List<RecordTag>() : null;
        private string _recordType;
        private RecordStatus _status;
        private DateTime? _updatedTime;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The UTC time stamp of the creation time.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchRoleArn. 
        /// <para>
        /// The ARN of the launch role associated with the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string LaunchRoleArn
        {
            get { return this._launchRoleArn; }
            set { this._launchRoleArn = value; }
        }

        // Check to see if LaunchRoleArn property is set
        internal bool IsSetLaunchRoleArn()
        {
            return this._launchRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property PathId. 
        /// <para>
        /// The path identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PathId
        {
            get { return this._pathId; }
            set { this._pathId = value; }
        }

        // Check to see if PathId property is set
        internal bool IsSetPathId()
        {
            return this._pathId != null;
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
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The identifier of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProvisionedProductId
        {
            get { return this._provisionedProductId; }
            set { this._provisionedProductId = value; }
        }

        // Check to see if ProvisionedProductId property is set
        internal bool IsSetProvisionedProductId()
        {
            return this._provisionedProductId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// The user-friendly name of the provisioned product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProvisionedProductName
        {
            get { return this._provisionedProductName; }
            set { this._provisionedProductName = value; }
        }

        // Check to see if ProvisionedProductName property is set
        internal bool IsSetProvisionedProductName()
        {
            return this._provisionedProductName != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductType. 
        /// <para>
        /// The type of provisioned product. The supported values are <c>CFN_STACK</c>, <c>CFN_STACKSET</c>,
        /// <c>TERRAFORM_OPEN_SOURCE</c>, <c>TERRAFORM_CLOUD</c>, and <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        public string ProvisionedProductType
        {
            get { return this._provisionedProductType; }
            set { this._provisionedProductType = value; }
        }

        // Check to see if ProvisionedProductType property is set
        internal bool IsSetProvisionedProductType()
        {
            return this._provisionedProductType != null;
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
        /// Gets and sets the property RecordErrors. 
        /// <para>
        /// The errors that occurred.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecordError> RecordErrors
        {
            get { return this._recordErrors; }
            set { this._recordErrors = value; }
        }

        // Check to see if RecordErrors property is set
        internal bool IsSetRecordErrors()
        {
            return this._recordErrors != null && (this._recordErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The identifier of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        // Check to see if RecordId property is set
        internal bool IsSetRecordId()
        {
            return this._recordId != null;
        }

        /// <summary>
        /// Gets and sets the property RecordTags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<RecordTag> RecordTags
        {
            get { return this._recordTags; }
            set { this._recordTags = value; }
        }

        // Check to see if RecordTags property is set
        internal bool IsSetRecordTags()
        {
            return this._recordTags != null && (this._recordTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The record type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROVISION_PRODUCT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_PROVISIONED_PRODUCT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATE_PROVISIONED_PRODUCT</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string RecordType
        {
            get { return this._recordType; }
            set { this._recordType = value; }
        }

        // Check to see if RecordType property is set
        internal bool IsSetRecordType()
        {
            return this._recordType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the provisioned product.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED</c> - The request was created but the operation has not started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - The requested operation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS_IN_ERROR</c> - The provisioned product is under change but the requested
        /// operation failed and some remediation is occurring. For example, a rollback.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> - The requested operation has successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The requested operation has unsuccessfully completed. Investigate
        /// using the error messages returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RecordStatus Status
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
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The time when the record was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTime
        {
            get { return this._updatedTime; }
            set { this._updatedTime = value; }
        }

        // Check to see if UpdatedTime property is set
        internal bool IsSetUpdatedTime()
        {
            return this._updatedTime.HasValue; 
        }

    }
}