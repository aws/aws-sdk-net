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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the StartChangeSet operation.
    /// This operation allows you to request changes for your entities. Within a single ChangeSet,
    /// you cannot start the same change type against the same entity multiple times. Additionally,
    /// when a ChangeSet is running, all the entities targeted by the different changes are
    /// locked until the ChangeSet has completed (either succeeded, cancelled, or failed).
    /// If you try to start a ChangeSet containing a change against an entity that is already
    /// locked, you will receive a <code>ResourceInUseException</code>.
    /// 
    ///  
    /// <para>
    /// For example, you cannot start the ChangeSet described in the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_StartChangeSet.html#API_StartChangeSet_Examples">example</a>
    /// below because it contains two changes to execute the same change type (<code>AddRevisions</code>)
    /// against the same entity (<code>entity-id@1)</code>.
    /// </para>
    /// </summary>
    public partial class StartChangeSetRequest : AmazonMarketplaceCatalogRequest
    {
        private string _catalog;
        private List<Change> _changeSet = new List<Change>();
        private string _changeSetName;
        private string _clientRequestToken;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <code>AWSMarketplace</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeSet. 
        /// <para>
        /// Array of <code>change</code> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<Change> ChangeSet
        {
            get { return this._changeSet; }
            set { this._changeSet = value; }
        }

        // Check to see if ChangeSet property is set
        internal bool IsSetChangeSet()
        {
            return this._changeSet != null && this._changeSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChangeSetName. 
        /// <para>
        /// Optional case sensitive string of up to 100 ASCII characters. The change set name
        /// can be used to filter the list of change sets. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ChangeSetName
        {
            get { return this._changeSetName; }
            set { this._changeSetName = value; }
        }

        // Check to see if ChangeSetName property is set
        internal bool IsSetChangeSetName()
        {
            return this._changeSetName != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique token to identify the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

    }
}