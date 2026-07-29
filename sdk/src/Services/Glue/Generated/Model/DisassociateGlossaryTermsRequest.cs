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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateGlossaryTerms operation.
    /// Removes the association of one or more glossary terms from an asset in Glue Data Catalog.
    /// </summary>
    public partial class DisassociateGlossaryTermsRequest : AmazonGlueRequest
    {
        private string _assetIdentifier;
        private string _clientToken;
        private List<string> _glossaryTermIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AssetIdentifier. 
        /// <para>
        /// The unique identifier of the asset to disassociate glossary terms from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1087)]
        public string AssetIdentifier
        {
            get { return this._assetIdentifier; }
            set { this._assetIdentifier = value; }
        }

        // Check to see if AssetIdentifier property is set
        internal bool IsSetAssetIdentifier()
        {
            return this._assetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property GlossaryTermIdentifiers. 
        /// <para>
        /// The list of glossary term identifiers to disassociate from the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> GlossaryTermIdentifiers
        {
            get { return this._glossaryTermIdentifiers; }
            set { this._glossaryTermIdentifiers = value; }
        }

        // Check to see if GlossaryTermIdentifiers property is set
        internal bool IsSetGlossaryTermIdentifiers()
        {
            return this._glossaryTermIdentifiers != null && (this._glossaryTermIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}