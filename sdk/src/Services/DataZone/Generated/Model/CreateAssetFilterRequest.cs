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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAssetFilter operation.
    /// Creates a data asset filter.
    /// 
    ///  
    /// <para>
    /// Asset filters provide a sophisticated way to create controlled views of data assets
    /// by selecting specific columns or applying row-level filters. This capability is crucial
    /// for organizations that need to share data while maintaining security and privacy controls.
    /// For example, your database might be filtered to show only non-PII fields to certain
    /// users, or sales data might be filtered by region for different regional teams. Asset
    /// filters enable fine-grained access control while maintaining a single source of truth.
    /// </para>
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A valid domain (<c>--domain-identifier</c>) must exist. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A data asset (<c>--asset-identifier</c>) must already be created under that domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The asset must have the referenced columns available in its schema for column-based
    /// filtering.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot specify both (<c>columnConfiguration</c>, <c>rowConfiguration</c>)at the
    /// same time.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateAssetFilterRequest : AmazonDataZoneRequest
    {
        private string _assetIdentifier;
        private string _clientToken;
        private AssetFilterConfiguration _configuration;
        private string _description;
        private string _domainIdentifier;
        private string _name;

        /// <summary>
        /// Gets and sets the property AssetIdentifier. 
        /// <para>
        /// The ID of the data asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the asset filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetFilterConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the asset filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain in which you want to create an asset filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
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

    }
}