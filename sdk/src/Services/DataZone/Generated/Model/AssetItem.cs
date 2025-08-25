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
    /// A Amazon DataZone inventory asset.
    /// </summary>
    public partial class AssetItem
    {
        private AssetItemAdditionalAttributes _additionalAttributes;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _domainId;
        private string _externalIdentifier;
        private DateTime? _firstRevisionCreatedAt;
        private string _firstRevisionCreatedBy;
        private List<string> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _governedGlossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identifier;
        private string _name;
        private string _owningProjectId;
        private string _typeIdentifier;
        private string _typeRevision;

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// The additional attributes of a Amazon DataZone inventory asset. 
        /// </para>
        /// </summary>
        public AssetItemAdditionalAttributes AdditionalAttributes
        {
            get { return this._additionalAttributes; }
            set { this._additionalAttributes = value; }
        }

        // Check to see if AdditionalAttributes property is set
        internal bool IsSetAdditionalAttributes()
        {
            return this._additionalAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the Amazon DataZone inventory asset was created.
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the inventory asset.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of an Amazon DataZone inventory asset.
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the inventory asset exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalIdentifier. 
        /// <para>
        /// The external identifier of the Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600)]
        public string ExternalIdentifier
        {
            get { return this._externalIdentifier; }
            set { this._externalIdentifier = value; }
        }

        // Check to see if ExternalIdentifier property is set
        internal bool IsSetExternalIdentifier()
        {
            return this._externalIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FirstRevisionCreatedAt. 
        /// <para>
        /// The timestamp of when the first revision of the inventory asset was created.
        /// </para>
        /// </summary>
        public DateTime? FirstRevisionCreatedAt
        {
            get { return this._firstRevisionCreatedAt; }
            set { this._firstRevisionCreatedAt = value; }
        }

        // Check to see if FirstRevisionCreatedAt property is set
        internal bool IsSetFirstRevisionCreatedAt()
        {
            return this._firstRevisionCreatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstRevisionCreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the first revision of the inventory asset.
        /// </para>
        /// </summary>
        public string FirstRevisionCreatedBy
        {
            get { return this._firstRevisionCreatedBy; }
            set { this._firstRevisionCreatedBy = value; }
        }

        // Check to see if FirstRevisionCreatedBy property is set
        internal bool IsSetFirstRevisionCreatedBy()
        {
            return this._firstRevisionCreatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms attached to the Amazon DataZone inventory asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property GovernedGlossaryTerms. 
        /// <para>
        /// The restricted glossary terms accociated with an asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> GovernedGlossaryTerms
        {
            get { return this._governedGlossaryTerms; }
            set { this._governedGlossaryTerms = value; }
        }

        // Check to see if GovernedGlossaryTerms property is set
        internal bool IsSetGovernedGlossaryTerms()
        {
            return this._governedGlossaryTerms != null && (this._governedGlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// the identifier of the Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the Amazon DataZone project that owns the inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwningProjectId
        {
            get { return this._owningProjectId; }
            set { this._owningProjectId = value; }
        }

        // Check to see if OwningProjectId property is set
        internal bool IsSetOwningProjectId()
        {
            return this._owningProjectId != null;
        }

        /// <summary>
        /// Gets and sets the property TypeIdentifier. 
        /// <para>
        /// The identifier of the asset type of the specified Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=513)]
        public string TypeIdentifier
        {
            get { return this._typeIdentifier; }
            set { this._typeIdentifier = value; }
        }

        // Check to see if TypeIdentifier property is set
        internal bool IsSetTypeIdentifier()
        {
            return this._typeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The revision of the inventory asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TypeRevision
        {
            get { return this._typeRevision; }
            set { this._typeRevision = value; }
        }

        // Check to see if TypeRevision property is set
        internal bool IsSetTypeRevision()
        {
            return this._typeRevision != null;
        }

    }
}