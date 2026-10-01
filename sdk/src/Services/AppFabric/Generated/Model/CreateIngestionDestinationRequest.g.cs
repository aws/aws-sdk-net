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

namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIngestionDestination operation. Creates
    /// an ingestion destination, which specifies how an application's ingested data is processed
    /// by Amazon Web Services AppFabric and where it's delivered.
    /// </summary>
    public partial class CreateIngestionDestinationRequest : AmazonAppFabricRequest
    {
        /// <summary>
        /// Gets and sets the property AppBundleIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the app bundle
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string AppBundleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AppBundleIdentifier property is set.
        /// </summary>
        internal bool IsSetAppBundleIdentifier() => this.AppBundleIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <c>ClientToken</c>, but with different parameters,
        /// the retry fails with an <c>IdempotentParameterMismatch</c> error.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// Contains information about the destination of ingested data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationConfiguration DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationConfiguration() => this.DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property IngestionIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the ingestion
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string IngestionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the IngestionIdentifier property is set.
        /// </summary>
        internal bool IsSetIngestionIdentifier() => this.IngestionIdentifier != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// Contains information about how ingested data is processed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
