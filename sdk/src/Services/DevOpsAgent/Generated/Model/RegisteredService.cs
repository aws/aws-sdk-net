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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
        private List<Amazon.Runtime.Documents.Document> _accessibleResources = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;
        private AdditionalServiceDetails _additionalServiceDetails;
        private string _kmsKeyArn;
        private string _name;
        private string _privateConnectionName;
        private string _serviceId;
        private Service _serviceType;

        /// <summary>
        /// Gets and sets the property AccessibleResources. 
        /// <para>
        /// List of accessible resources for this service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Amazon.Runtime.Documents.Document> AccessibleResources
        {
            get { return this._accessibleResources; }
            set { this._accessibleResources = value; }
        }

        // Check to see if AccessibleResources property is set
        internal bool IsSetAccessibleResources()
        {
            return this._accessibleResources != null && (this._accessibleResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AdditionalServiceDetails. 
        /// <para>
        /// Additional details specific to the service type.
        /// </para>
        /// </summary>
        public AdditionalServiceDetails AdditionalServiceDetails
        {
            get { return this._additionalServiceDetails; }
            set { this._additionalServiceDetails = value; }
        }

        // Check to see if AdditionalServiceDetails property is set
        internal bool IsSetAdditionalServiceDetails()
        {
            return this._additionalServiceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the AWS Key Management Service (AWS KMS) customer managed key that's used
        /// to encrypt resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the registered service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// The name of the private connection used for VPC connectivity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=30)]
        public string PrivateConnectionName
        {
            get { return this._privateConnectionName; }
            set { this._privateConnectionName = value; }
        }

        // Check to see if PrivateConnectionName property is set
        internal bool IsSetPrivateConnectionName()
        {
            return this._privateConnectionName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The unique identifier of a service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The service type e.g github or dynatrace
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Service ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

    }
}