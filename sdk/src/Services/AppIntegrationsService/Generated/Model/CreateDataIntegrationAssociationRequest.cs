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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataIntegrationAssociation operation.
    /// Creates and persists a DataIntegrationAssociation resource.
    /// </summary>
    public partial class CreateDataIntegrationAssociationRequest : AmazonAppIntegrationsServiceRequest
    {
        private Dictionary<string, string> _clientAssociationMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientId;
        private string _clientToken;
        private string _dataIntegrationIdentifier;
        private string _destinationURI;
        private ExecutionConfiguration _executionConfiguration;
        private Dictionary<string, Dictionary<string, List<string>>> _objectConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, List<string>>>() : null;

        /// <summary>
        /// Gets and sets the property ClientAssociationMetadata. 
        /// <para>
        /// The mapping of metadata to be extracted from the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ClientAssociationMetadata
        {
            get { return this._clientAssociationMetadata; }
            set { this._clientAssociationMetadata = value; }
        }

        // Check to see if ClientAssociationMetadata property is set
        internal bool IsSetClientAssociationMetadata()
        {
            return this._clientAssociationMetadata != null && (this._clientAssociationMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The identifier for the client that is associated with the DataIntegration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property DataIntegrationIdentifier. 
        /// <para>
        /// A unique identifier for the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DataIntegrationIdentifier
        {
            get { return this._dataIntegrationIdentifier; }
            set { this._dataIntegrationIdentifier = value; }
        }

        // Check to see if DataIntegrationIdentifier property is set
        internal bool IsSetDataIntegrationIdentifier()
        {
            return this._dataIntegrationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationURI. 
        /// <para>
        /// The URI of the data destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string DestinationURI
        {
            get { return this._destinationURI; }
            set { this._destinationURI = value; }
        }

        // Check to see if DestinationURI property is set
        internal bool IsSetDestinationURI()
        {
            return this._destinationURI != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionConfiguration. 
        /// <para>
        /// The configuration for how the files should be pulled from the source.
        /// </para>
        /// </summary>
        public ExecutionConfiguration ExecutionConfiguration
        {
            get { return this._executionConfiguration; }
            set { this._executionConfiguration = value; }
        }

        // Check to see if ExecutionConfiguration property is set
        internal bool IsSetExecutionConfiguration()
        {
            return this._executionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectConfiguration.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, List<string>>> ObjectConfiguration
        {
            get { return this._objectConfiguration; }
            set { this._objectConfiguration = value; }
        }

        // Check to see if ObjectConfiguration property is set
        internal bool IsSetObjectConfiguration()
        {
            return this._objectConfiguration != null && (this._objectConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}