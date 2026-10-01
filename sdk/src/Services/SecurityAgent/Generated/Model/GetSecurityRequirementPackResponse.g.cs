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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// This is the response object from the GetSecurityRequirementPack operation.
    /// </summary>
    public partial class GetSecurityRequirementPackResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the security requirement pack was created, in UTC format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the security requirement pack.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        /// The status of the security requirements import workflow for this pack.
        /// </para>
        /// </summary>
        public SecurityRequirementPackImportStatus ImportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImportStatus property is set.
        /// </summary>
        internal bool IsSetImportStatus() => this.ImportStatus != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the AWS KMS key used to encrypt pack contents.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ManagementType. 
        /// <para>
        /// The management type of the pack. Valid values are AWS_MANAGED and CUSTOMER_MANAGED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ManagementType ManagementType { get; set; }

        /// <summary>
        /// Checks to see if the ManagementType property is set.
        /// </summary>
        internal bool IsSetManagementType() => this.ManagementType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the security requirement pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PackId. 
        /// <para>
        /// The unique identifier of the security requirement pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PackId { get; set; }

        /// <summary>
        /// Checks to see if the PackId property is set.
        /// </summary>
        internal bool IsSetPackId() => this.PackId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the security requirement pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SecurityRequirementPackStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the security requirement pack was last updated, in UTC format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The vendor name for AWS managed packs, such as ISO or NIST.
        /// </para>
        /// </summary>
        public string VendorName { get; set; }

        /// <summary>
        /// Checks to see if the VendorName property is set.
        /// </summary>
        internal bool IsSetVendorName() => this.VendorName != null;
    }
}
