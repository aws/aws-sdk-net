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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMetadataTransferJob operation.
    /// Creates a new metadata transfer job.
    /// </summary>
    public partial class CreateMetadataTransferJobRequest : AmazonIoTTwinMakerRequest
    {
        private string _description;
        private DestinationConfiguration _destination;
        private string _metadataTransferJobId;
        private List<SourceConfiguration> _sources = AWSConfigs.InitializeCollections ? new List<SourceConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The metadata transfer job description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The metadata transfer job destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationConfiguration Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataTransferJobId. 
        /// <para>
        /// The metadata transfer job Id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string MetadataTransferJobId
        {
            get { return this._metadataTransferJobId; }
            set { this._metadataTransferJobId = value; }
        }

        // Check to see if MetadataTransferJobId property is set
        internal bool IsSetMetadataTransferJobId()
        {
            return this._metadataTransferJobId != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The metadata transfer job sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<SourceConfiguration> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}