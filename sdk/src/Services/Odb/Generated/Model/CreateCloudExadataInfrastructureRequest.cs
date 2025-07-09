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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
    /// Container for the parameters to the CreateCloudExadataInfrastructure operation.
    /// Creates an Exadata infrastructure.
    /// </summary>
    public partial class CreateCloudExadataInfrastructureRequest : AmazonOdbRequest
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _clientToken;
        private int? _computeCount;
        private List<CustomerContact> _customerContactsToSendToOCI = AWSConfigs.InitializeCollections ? new List<CustomerContact>() : null;
        private string _databaseServerType;
        private string _displayName;
        private MaintenanceWindow _maintenanceWindow;
        private string _shape;
        private int? _storageCount;
        private string _storageServerType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        [AWSProperty(Min=1, Max=255)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

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
        [AWSProperty(Min=1, Max=255)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you don't specify a client token, the Amazon Web Services SDK automatically
        /// generates a client token and uses it for the request to ensure idempotency. The client
        /// token is valid for up to 24 hours after it's first used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=64)]
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
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The number of database servers for the Exadata infrastructure. Valid values for this
        /// parameter depend on the shape. To get information about the minimum and maximum values,
        /// use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ComputeCount
        {
            get { return this._computeCount; }
            set { this._computeCount = value; }
        }

        // Check to see if ComputeCount property is set
        internal bool IsSetComputeCount()
        {
            return this._computeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerContactsToSendToOCI. 
        /// <para>
        /// The email addresses of contacts to receive notification from Oracle about maintenance
        /// updates for the Exadata infrastructure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerContact> CustomerContactsToSendToOCI
        {
            get { return this._customerContactsToSendToOCI; }
            set { this._customerContactsToSendToOCI = value; }
        }

        // Check to see if CustomerContactsToSendToOCI property is set
        internal bool IsSetCustomerContactsToSendToOCI()
        {
            return this._customerContactsToSendToOCI != null && (this._customerContactsToSendToOCI.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DatabaseServerType. 
        /// <para>
        /// The database server model type of the Exadata infrastructure. For the list of valid
        /// model names, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DatabaseServerType
        {
            get { return this._databaseServerType; }
            set { this._databaseServerType = value; }
        }

        // Check to see if DatabaseServerType property is set
        internal bool IsSetDatabaseServerType()
        {
            return this._databaseServerType != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A user-friendly name for the Exadata infrastructure.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

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
        public MaintenanceWindow MaintenanceWindow
        {
            get { return this._maintenanceWindow; }
            set { this._maintenanceWindow = value; }
        }

        // Check to see if MaintenanceWindow property is set
        internal bool IsSetMaintenanceWindow()
        {
            return this._maintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The model name of the Exadata infrastructure. For the list of valid model names, use
        /// the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Shape
        {
            get { return this._shape; }
            set { this._shape = value; }
        }

        // Check to see if Shape property is set
        internal bool IsSetShape()
        {
            return this._shape != null;
        }

        /// <summary>
        /// Gets and sets the property StorageCount. 
        /// <para>
        /// The number of storage servers to activate for this Exadata infrastructure. Valid values
        /// for this parameter depend on the shape. To get information about the minimum and maximum
        /// values, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? StorageCount
        {
            get { return this._storageCount; }
            set { this._storageCount = value; }
        }

        // Check to see if StorageCount property is set
        internal bool IsSetStorageCount()
        {
            return this._storageCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageServerType. 
        /// <para>
        /// The storage server model type of the Exadata infrastructure. For the list of valid
        /// model names, use the <c>ListDbSystemShapes</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string StorageServerType
        {
            get { return this._storageServerType; }
            set { this._storageServerType = value; }
        }

        // Check to see if StorageServerType property is set
        internal bool IsSetStorageServerType()
        {
            return this._storageServerType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of resource tags to apply to the Exadata infrastructure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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

    }
}