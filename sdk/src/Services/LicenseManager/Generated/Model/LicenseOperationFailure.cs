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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes the failure of a license operation.
    /// </summary>
    public partial class LicenseOperationFailure
    {
        private string _errorMessage;
        private DateTime? _failureTime;
        private List<Metadata> _metadataList = AWSConfigs.InitializeCollections ? new List<Metadata>() : null;
        private string _operationName;
        private string _operationRequestedBy;
        private string _resourceArn;
        private string _resourceOwnerId;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property FailureTime. 
        /// <para>
        /// Failure time.
        /// </para>
        /// </summary>
        public DateTime? FailureTime
        {
            get { return this._failureTime; }
            set { this._failureTime = value; }
        }

        // Check to see if FailureTime property is set
        internal bool IsSetFailureTime()
        {
            return this._failureTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataList. 
        /// <para>
        /// Reserved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Metadata> MetadataList
        {
            get { return this._metadataList; }
            set { this._metadataList = value; }
        }

        // Check to see if MetadataList property is set
        internal bool IsSetMetadataList()
        {
            return this._metadataList != null && (this._metadataList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// Name of the operation.
        /// </para>
        /// </summary>
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

        /// <summary>
        /// Gets and sets the property OperationRequestedBy. 
        /// <para>
        /// The requester is "License Manager Automated Discovery".
        /// </para>
        /// </summary>
        public string OperationRequestedBy
        {
            get { return this._operationRequestedBy; }
            set { this._operationRequestedBy = value; }
        }

        // Check to see if OperationRequestedBy property is set
        internal bool IsSetOperationRequestedBy()
        {
            return this._operationRequestedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// ID of the Amazon Web Services account that owns the resource.
        /// </para>
        /// </summary>
        public string ResourceOwnerId
        {
            get { return this._resourceOwnerId; }
            set { this._resourceOwnerId = value; }
        }

        // Check to see if ResourceOwnerId property is set
        internal bool IsSetResourceOwnerId()
        {
            return this._resourceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Resource type.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}