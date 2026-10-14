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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCloudExadataInfrastructure operation. Creates
    /// an Exadata infrastructure.
    /// </summary>
    public partial class CreateCloudExadataInfrastructureRequest : AmazonOdbRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone (AZ) where the Exadata infrastructure is located.
        /// </para>
        ///  
        /// <para>
        /// This operation requires that you specify a value for either <c>availabilityZone</c>
        /// or <c>availabilityZoneId</c>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>us-east-1a</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The AZ ID of the AZ where the Exadata infrastructure is located.
        /// </para>
        ///  
        /// <para>
        /// This operation requires that you specify a value for either <c>availabilityZone</c>
        /// or <c>availabilityZoneId</c>.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>use1-az1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency. The client
        /// token is valid for up to 24 hours after it's first used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The number of database servers for the Exadata infrastructure. Valid values for this
        /// parameter depend on the shape. To get information about the minimum and maximum values,
        /// use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ComputeCount { get; set; }

        /// <summary>
        /// Checks to see if the ComputeCount property is set.
        /// </summary>
        internal bool IsSetComputeCount() => this.ComputeCount.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerContactsToSendToOCI. 
        /// <para>
        /// The email addresses of contacts to receive notification from Oracle about maintenance
        /// updates for the Exadata infrastructure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerContact> CustomerContactsToSendToOCI { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomerContact>() : null;

        /// <summary>
        /// Checks to see if the CustomerContactsToSendToOCI property is set.
        /// </summary>
        internal bool IsSetCustomerContactsToSendToOCI() => this.CustomerContactsToSendToOCI != null && (this.CustomerContactsToSendToOCI.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DatabaseServerType. 
        /// <para>
        /// The database server model type of the Exadata infrastructure. For the list of valid
        /// model names, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatabaseServerType { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseServerType property is set.
        /// </summary>
        internal bool IsSetDatabaseServerType() => this.DatabaseServerType != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A user-friendly name for the Exadata infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// The maintenance window configuration for the Exadata Cloud infrastructure.
        /// </para>
        ///  
        /// <para>
        /// This allows you to define when maintenance operations such as patching and updates
        /// can be performed on the infrastructure.
        /// </para>
        /// </summary>
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindow() => this.MaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The model name of the Exadata infrastructure. For the list of valid model names, use
        /// the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Shape { get; set; }

        /// <summary>
        /// Checks to see if the Shape property is set.
        /// </summary>
        internal bool IsSetShape() => this.Shape != null;

        /// <summary>
        /// Gets and sets the property StorageCount. 
        /// <para>
        /// The number of storage servers to activate for this Exadata infrastructure. Valid values
        /// for this parameter depend on the shape. To get information about the minimum and maximum
        /// values, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? StorageCount { get; set; }

        /// <summary>
        /// Checks to see if the StorageCount property is set.
        /// </summary>
        internal bool IsSetStorageCount() => this.StorageCount.HasValue;

        /// <summary>
        /// Gets and sets the property StorageServerType. 
        /// <para>
        /// The storage server model type of the Exadata infrastructure. For the list of valid
        /// model names, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StorageServerType { get; set; }

        /// <summary>
        /// Checks to see if the StorageServerType property is set.
        /// </summary>
        internal bool IsSetStorageServerType() => this.StorageServerType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the Exadata infrastructure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
