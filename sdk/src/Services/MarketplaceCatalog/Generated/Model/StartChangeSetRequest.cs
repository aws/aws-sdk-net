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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the StartChangeSet operation.
    /// Allows you to request changes for your entities. Within a single <c>ChangeSet</c>,
    /// you can't start the same change type against the same entity multiple times. Additionally,
    /// when a <c>ChangeSet</c> is running, all the entities targeted by the different changes
    /// are locked until the change set has completed (either succeeded, cancelled, or failed).
    /// If you try to start a change set containing a change against an entity that is already
    /// locked, you will receive a <c>ResourceInUseException</c> error.
    /// 
    ///  
    /// <para>
    /// For example, you can't start the <c>ChangeSet</c> described in the <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/API_StartChangeSet.html#API_StartChangeSet_Examples">example</a>
    /// later in this topic because it contains two changes to run the same change type (<c>AddRevisions</c>)
    /// against the same entity (<c>entity-id@1</c>).
    /// </para>
    ///  
    /// <para>
    /// For more information about working with change sets, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/welcome.html#working-with-change-sets">
    /// Working with change sets</a>. For information about change types for single-AMI products,
    /// see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/ami-products.html#working-with-single-AMI-products">Working
    /// with single-AMI products</a>. Also, for more information about change types available
    /// for container-based products, see <a href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/container-products.html#working-with-container-products">Working
    /// with container products</a>.
    /// </para>
    ///  
    /// <para>
    /// To download "DetailsDocument" shapes, see <a href="https://github.com/awslabs/aws-marketplace-catalog-api-shapes-for-python">Python</a>
    /// and <a href="https://github.com/awslabs/aws-marketplace-catalog-api-shapes-for-java/tree/main">Java</a>
    /// shapes on GitHub.
    /// </para>
    /// </summary>
    public partial class StartChangeSetRequest : AmazonMarketplaceCatalogRequest
    {
        private string _catalog;
        private List<Change> _changeSet = AWSConfigs.InitializeCollections ? new List<Change>() : null;
        private string _changeSetName;
        private List<Tag> _changeSetTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _clientRequestToken;
        private Intent _intent;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <c>AWSMarketplace</c> 
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
        /// Array of <c>change</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._changeSet != null && (this._changeSet.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ChangeSetTags. 
        /// <para>
        /// A list of objects specifying each key name and value for the <c>ChangeSetTags</c>
        /// property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> ChangeSetTags
        {
            get { return this._changeSetTags; }
            set { this._changeSetTags = value; }
        }

        // Check to see if ChangeSetTags property is set
        internal bool IsSetChangeSetTags()
        {
            return this._changeSetTags != null && (this._changeSetTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique token to identify the request to ensure idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property Intent. 
        /// <para>
        /// The intent related to the request. The default is <c>APPLY</c>. To test your request
        /// before applying changes to your entities, use <c>VALIDATE</c>. This feature is currently
        /// available for adding versions to single-AMI products. For more information, see <a
        /// href="https://docs.aws.amazon.com/marketplace-catalog/latest/api-reference/ami-products.html#ami-add-version">Add
        /// a new version</a>.
        /// </para>
        /// </summary>
        public Intent Intent
        {
            get { return this._intent; }
            set { this._intent = value; }
        }

        // Check to see if Intent property is set
        internal bool IsSetIntent()
        {
            return this._intent != null;
        }

    }
}