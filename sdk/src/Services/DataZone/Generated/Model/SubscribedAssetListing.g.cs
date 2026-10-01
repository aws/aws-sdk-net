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
    /// The details of the published asset for which the subscription grant is created.
    /// </summary>
    public partial class SubscribedAssetListing
    {
        /// <summary>
        /// Gets and sets the property AssetScope. 
        /// <para>
        /// The asset scope of the subscribed asset listing.
        /// </para>
        /// </summary>
        public AssetScope AssetScope { get; set; }

        /// <summary>
        /// Checks to see if the AssetScope property is set.
        /// </summary>
        internal bool IsSetAssetScope() => this.AssetScope != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityRevision. 
        /// <para>
        /// The revision of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string EntityRevision { get; set; }

        /// <summary>
        /// Checks to see if the EntityRevision property is set.
        /// </summary>
        internal bool IsSetEntityRevision() => this.EntityRevision != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property Forms. 
        /// <para>
        /// The forms attached to the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        public string Forms { get; set; }

        /// <summary>
        /// Checks to see if the Forms property is set.
        /// </summary>
        internal bool IsSetForms() => this.Forms != null;

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms attached to the published asset for which the subscription grant
        /// is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetailedGlossaryTerm> GlossaryTerms { get; set; } = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;

        /// <summary>
        /// Checks to see if the GlossaryTerms property is set.
        /// </summary>
        internal bool IsSetGlossaryTerms() => this.GlossaryTerms != null && (this.GlossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The asset permissions.
        /// </para>
        /// </summary>
        public Permissions Permissions { get; set; }

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null;
    }
}
