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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// A Amazon DataZone inventory asset.
    /// </summary>
    public partial class AssetItem
    {
        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// The additional attributes of a Amazon DataZone inventory asset. 
        /// </para>
        /// </summary>
        public AssetItemAdditionalAttributes AdditionalAttributes { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalAttributes property is set.
        /// </summary>
        internal bool IsSetAdditionalAttributes() => this.AdditionalAttributes != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the Amazon DataZone inventory asset was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the inventory asset.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of an Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the inventory asset exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property ExternalIdentifier. 
        /// <para>
        /// The external identifier of the Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 600)]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExternalIdentifier property is set.
        /// </summary>
        internal bool IsSetExternalIdentifier() => this.ExternalIdentifier != null;

        /// <summary>
        /// Gets and sets the property FirstRevisionCreatedAt. 
        /// <para>
        /// The timestamp of when the first revision of the inventory asset was created.
        /// </para>
        /// </summary>
        public DateTime? FirstRevisionCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstRevisionCreatedAt property is set.
        /// </summary>
        internal bool IsSetFirstRevisionCreatedAt() => this.FirstRevisionCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FirstRevisionCreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the first revision of the inventory asset.
        /// </para>
        /// </summary>
        public string FirstRevisionCreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the FirstRevisionCreatedBy property is set.
        /// </summary>
        internal bool IsSetFirstRevisionCreatedBy() => this.FirstRevisionCreatedBy != null;

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms attached to the Amazon DataZone inventory asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> GlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGlossaryTerms() => this.GlossaryTerms != null && (this.GlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GovernedGlossaryTerms. 
        /// <para>
        /// The restricted glossary terms accociated with an asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> GovernedGlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GovernedGlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGovernedGlossaryTerms() => this.GovernedGlossaryTerms != null && (this.GovernedGlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// the identifier of the Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the Amazon DataZone project that owns the inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwningProjectId { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectId property is set.
        /// </summary>
        internal bool IsSetOwningProjectId() => this.OwningProjectId != null;

        /// <summary>
        /// Gets and sets the property TypeIdentifier. 
        /// <para>
        /// The identifier of the asset type of the specified Amazon DataZone inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 513)]
        public string TypeIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TypeIdentifier property is set.
        /// </summary>
        internal bool IsSetTypeIdentifier() => this.TypeIdentifier != null;

        /// <summary>
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The revision of the inventory asset type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TypeRevision { get; set; }

        /// <summary>
        /// Checks to see if the TypeRevision property is set.
        /// </summary>
        internal bool IsSetTypeRevision() => this.TypeRevision != null;
    }
}
