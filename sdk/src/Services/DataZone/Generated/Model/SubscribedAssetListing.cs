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
    /// The details of the published asset for which the subscription grant is created.
    /// </summary>
    public partial class SubscribedAssetListing
    {
        private AssetScope _assetScope;
        private string _entityId;
        private string _entityRevision;
        private string _entityType;
        private string _forms;
        private List<DetailedGlossaryTerm> _glossaryTerms = AWSConfigs.InitializeCollections ? new List<DetailedGlossaryTerm>() : null;

        /// <summary>
        /// Gets and sets the property AssetScope. 
        /// <para>
        /// The asset scope of the subscribed asset listing.
        /// </para>
        /// </summary>
        public AssetScope AssetScope
        {
            get { return this._assetScope; }
            set { this._assetScope = value; }
        }

        // Check to see if AssetScope property is set
        internal bool IsSetAssetScope()
        {
            return this._assetScope != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityRevision. 
        /// <para>
        /// The revision of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EntityRevision
        {
            get { return this._entityRevision; }
            set { this._entityRevision = value; }
        }

        // Check to see if EntityRevision property is set
        internal bool IsSetEntityRevision()
        {
            return this._entityRevision != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property Forms. 
        /// <para>
        /// The forms attached to the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        public string Forms
        {
            get { return this._forms; }
            set { this._forms = value; }
        }

        // Check to see if Forms property is set
        internal bool IsSetForms()
        {
            return this._forms != null;
        }

        /// <summary>
        /// Gets and sets the property GlossaryTerms. 
        /// <para>
        /// The glossary terms attached to the published asset for which the subscription grant
        /// is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DetailedGlossaryTerm> GlossaryTerms
        {
            get { return this._glossaryTerms; }
            set { this._glossaryTerms = value; }
        }

        // Check to see if GlossaryTerms property is set
        internal bool IsSetGlossaryTerms()
        {
            return this._glossaryTerms != null && (this._glossaryTerms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}