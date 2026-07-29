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
    /// This is the response object from the GetAsset operation.
    /// </summary>
    public partial class GetAssetResponse : AmazonWebServiceResponse
    {
        private string _assetTypeId;
        private Dictionary<string, AssetFormEntry> _attachments = AWSConfigs.InitializeCollections ? new Dictionary<string, AssetFormEntry>() : null;
        private DateTime? _createdAt;
        private string _description;
        private Dictionary<string, AssetFormEntry> _forms = AWSConfigs.InitializeCollections ? new Dictionary<string, AssetFormEntry>() : null;
        private List<string> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private Dictionary<string, IterableFormEntry> _iterableForms = AWSConfigs.InitializeCollections ? new Dictionary<string, IterableFormEntry>() : null;
        private string _name;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AssetTypeId. 
        /// <para>
        /// The identifier of the asset type for this asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetTypeId
        {
            get { return this._assetTypeId; }
            set { this._assetTypeId = value; }
        }

        // Check to see if AssetTypeId property is set
        internal bool IsSetAssetTypeId()
        {
            return this._assetTypeId != null;
        }

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// Additional attachments on the asset for more context, keyed by attachment name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AssetFormEntry> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && (this._attachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp at which the asset was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the asset.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Forms. 
        /// <para>
        /// The forms on the asset, keyed by form name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AssetFormEntry> Forms
        {
            get { return this._forms; }
            set { this._forms = value; }
        }

        // Check to see if Forms property is set
        internal bool IsSetForms()
        {
            return this._forms != null && (this._forms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The identifiers of the glossary terms associated with the asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> GlossaryTerms
        {
            get { return this._glossaryTerms; }
            set { this._glossaryTerms = value; }
        }

        // Check to see if GlossaryTerms property is set
        internal bool IsSetGlossaryTerms()
        {
            return this._glossaryTerms != null && (this._glossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1087)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IterableForms. 
        /// <para>
        /// The iterable forms available on the asset, keyed by form name (for example, <c>columns</c>).
        /// Use the form name with <c>ListIterableForms</c> or <c>BatchGetIterableForms</c> to
        /// retrieve the form's items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, IterableFormEntry> IterableForms
        {
            get { return this._iterableForms; }
            set { this._iterableForms = value; }
        }

        // Check to see if IterableForms property is set
        internal bool IsSetIterableForms()
        {
            return this._iterableForms != null && (this._iterableForms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the asset was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}