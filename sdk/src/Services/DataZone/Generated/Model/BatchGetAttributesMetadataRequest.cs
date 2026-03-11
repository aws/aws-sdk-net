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
    /// Container for the parameters to the BatchGetAttributesMetadata operation.
    /// Gets the attribute metadata.
    /// </summary>
    public partial class BatchGetAttributesMetadataRequest : AmazonDataZoneRequest
    {
        private List<string> _attributeIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domainIdentifier;
        private string _entityIdentifier;
        private string _entityRevision;
        private AttributeEntityType _entityType;

        /// <summary>
        /// Gets and sets the property AttributeIdentifiers. 
        /// <para>
        /// The attribute identifier.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> AttributeIdentifiers
        {
            get { return this._attributeIdentifiers; }
            set { this._attributeIdentifiers = value; }
        }

        // Check to see if AttributeIdentifiers property is set
        internal bool IsSetAttributeIdentifiers()
        {
            return this._attributeIdentifiers != null && (this._attributeIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The domain ID where you want to get the attribute metadata.
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
        /// Gets and sets the property EntityIdentifier. 
        /// <para>
        /// The entity ID for which you want to get attribute metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EntityIdentifier
        {
            get { return this._entityIdentifier; }
            set { this._entityIdentifier = value; }
        }

        // Check to see if EntityIdentifier property is set
        internal bool IsSetEntityIdentifier()
        {
            return this._entityIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EntityRevision. 
        /// <para>
        /// The entity revision for which you want to get attribute metadata.
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
        /// The entity type for which you want to get attribute metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AttributeEntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

    }
}