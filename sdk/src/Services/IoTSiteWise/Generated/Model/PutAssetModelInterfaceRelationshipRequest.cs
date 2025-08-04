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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the PutAssetModelInterfaceRelationship operation.
    /// Creates or updates an interface relationship between an asset model and an interface
    /// asset model. This operation applies an interface to an asset model.
    /// </summary>
    public partial class PutAssetModelInterfaceRelationshipRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetModelId;
        private string _clientToken;
        private string _interfaceAssetModelId;
        private PropertyMappingConfiguration _propertyMappingConfiguration;

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model. This can be either the actual ID in UUID format, or else
        /// externalId: followed by the external ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
        public string AssetModelId
        {
            get { return this._assetModelId; }
            set { this._assetModelId = value; }
        }

        // Check to see if AssetModelId property is set
        internal bool IsSetAssetModelId()
        {
            return this._assetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
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
        /// Gets and sets the property InterfaceAssetModelId. 
        /// <para>
        /// The ID of the interface asset model. This can be either the actual ID in UUID format,
        /// or else externalId: followed by the external ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
        public string InterfaceAssetModelId
        {
            get { return this._interfaceAssetModelId; }
            set { this._interfaceAssetModelId = value; }
        }

        // Check to see if InterfaceAssetModelId property is set
        internal bool IsSetInterfaceAssetModelId()
        {
            return this._interfaceAssetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyMappingConfiguration. 
        /// <para>
        /// The configuration for mapping properties from the interface asset model to the asset
        /// model where the interface is applied. This configuration controls how properties are
        /// matched and created during the interface application process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyMappingConfiguration PropertyMappingConfiguration
        {
            get { return this._propertyMappingConfiguration; }
            set { this._propertyMappingConfiguration = value; }
        }

        // Check to see if PropertyMappingConfiguration property is set
        internal bool IsSetPropertyMappingConfiguration()
        {
            return this._propertyMappingConfiguration != null;
        }

    }
}