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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Represents a registered service with its configuration and accessible resources.
    /// </summary>
    public partial class RegisteredService
    {
        /// <summary>
        /// Gets and sets the property AccessibleResources. 
        /// <para>
        /// List of accessible resources for this service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Amazon.Runtime.Documents.Document> AccessibleResources { get; set; } = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the AccessibleResources property is set.
        /// </summary>
        internal bool IsSetAccessibleResources() => this.AccessibleResources != null && (this.AccessibleResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AdditionalServiceDetails. 
        /// <para>
        /// Additional details specific to the service type.
        /// </para>
        /// </summary>
        public AdditionalServiceDetails AdditionalServiceDetails { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalServiceDetails property is set.
        /// </summary>
        internal bool IsSetAdditionalServiceDetails() => this.AdditionalServiceDetails != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the service was registered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the AWS Key Management Service (AWS KMS) customer managed key that's used
        /// to encrypt resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the registered service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// The name of the private connection used for VPC connectivity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 30)]
        public string PrivateConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateConnectionName property is set.
        /// </summary>
        internal bool IsSetPrivateConnectionName() => this.PrivateConnectionName != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The unique identifier of a service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The service type e.g github or dynatrace
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Service ServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the service was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
