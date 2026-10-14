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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Error message.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property FailureTime. 
        /// <para>
        /// Failure time.
        /// </para>
        /// </summary>
        public DateTime? FailureTime { get; set; }

        /// <summary>
        /// Checks to see if the FailureTime property is set.
        /// </summary>
        internal bool IsSetFailureTime() => this.FailureTime.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataList. 
        /// <para>
        /// Reserved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Metadata> MetadataList { get; set; } = AWSConfigs.InitializeCollections ? new List<Metadata>() : null;

        /// <summary>
        /// Checks to see if the MetadataList property is set.
        /// </summary>
        internal bool IsSetMetadataList() => this.MetadataList != null && (this.MetadataList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// Name of the operation.
        /// </para>
        /// </summary>
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;

        /// <summary>
        /// Gets and sets the property OperationRequestedBy. 
        /// <para>
        /// The requester is "License Manager Automated Discovery".
        /// </para>
        /// </summary>
        public string OperationRequestedBy { get; set; }

        /// <summary>
        /// Checks to see if the OperationRequestedBy property is set.
        /// </summary>
        internal bool IsSetOperationRequestedBy() => this.OperationRequestedBy != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        /// ID of the Amazon Web Services account that owns the resource.
        /// </para>
        /// </summary>
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerId() => this.ResourceOwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Resource type.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
