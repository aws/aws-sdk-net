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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
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
namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// Describes an AWS Data Exchange fulfillment option for data set delivery.
    /// </summary>
    public partial class DataExchangeFulfillmentOption
    {
        private List<DataArtifact> _dataArtifacts = AWSConfigs.InitializeCollections ? new List<DataArtifact>() : null;
        private string _fulfillmentOptionDisplayName;
        private string _fulfillmentOptionId;
        private FulfillmentOptionType _fulfillmentOptionType;

        /// <summary>
        /// Gets and sets the property DataArtifacts. 
        /// <para>
        /// The data artifacts included in this Data Exchange fulfillment option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataArtifact> DataArtifacts
        {
            get { return this._dataArtifacts; }
            set { this._dataArtifacts = value; }
        }

        // Check to see if DataArtifacts property is set
        internal bool IsSetDataArtifacts()
        {
            return this._dataArtifacts != null && (this._dataArtifacts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionDisplayName. 
        /// <para>
        /// A human-readable name for the fulfillment option type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FulfillmentOptionDisplayName
        {
            get { return this._fulfillmentOptionDisplayName; }
            set { this._fulfillmentOptionDisplayName = value; }
        }

        // Check to see if FulfillmentOptionDisplayName property is set
        internal bool IsSetFulfillmentOptionDisplayName()
        {
            return this._fulfillmentOptionDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionId. 
        /// <para>
        /// The unique identifier of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FulfillmentOptionId
        {
            get { return this._fulfillmentOptionId; }
            set { this._fulfillmentOptionId = value; }
        }

        // Check to see if FulfillmentOptionId property is set
        internal bool IsSetFulfillmentOptionId()
        {
            return this._fulfillmentOptionId != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentOptionType. 
        /// <para>
        /// The category of the fulfillment option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FulfillmentOptionType FulfillmentOptionType
        {
            get { return this._fulfillmentOptionType; }
            set { this._fulfillmentOptionType = value; }
        }

        // Check to see if FulfillmentOptionType property is set
        internal bool IsSetFulfillmentOptionType()
        {
            return this._fulfillmentOptionType != null;
        }

    }
}