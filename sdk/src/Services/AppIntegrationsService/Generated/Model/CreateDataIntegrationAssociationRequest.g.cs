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

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataIntegrationAssociation operation. Creates
    /// and persists a DataIntegrationAssociation resource.
    /// </summary>
    public partial class CreateDataIntegrationAssociationRequest : AmazonAppIntegrationsServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ClientAssociationMetadata. 
        /// <para>
        /// The mapping of metadata to be extracted from the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ClientAssociationMetadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ClientAssociationMetadata property is set.
        /// </summary>
        internal bool IsSetClientAssociationMetadata() => this.ClientAssociationMetadata != null && (this.ClientAssociationMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The identifier for the client that is associated with the DataIntegration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataIntegrationIdentifier. 
        /// <para>
        /// A unique identifier for the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DataIntegrationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DataIntegrationIdentifier property is set.
        /// </summary>
        internal bool IsSetDataIntegrationIdentifier() => this.DataIntegrationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DestinationURI. 
        /// <para>
        /// The URI of the data destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DestinationURI { get; set; }

        /// <summary>
        /// Checks to see if the DestinationURI property is set.
        /// </summary>
        internal bool IsSetDestinationURI() => this.DestinationURI != null;

        /// <summary>
        /// Gets and sets the property ExecutionConfiguration. 
        /// <para>
        /// The configuration for how the files should be pulled from the source.
        /// </para>
        /// </summary>
        public ExecutionConfiguration ExecutionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionConfiguration property is set.
        /// </summary>
        internal bool IsSetExecutionConfiguration() => this.ExecutionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ObjectConfiguration.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, List<string>>> ObjectConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, List<string>>>() : null;

        /// <summary>
        /// Checks to see if the ObjectConfiguration property is set.
        /// </summary>
        internal bool IsSetObjectConfiguration() => this.ObjectConfiguration != null && (this.ObjectConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
