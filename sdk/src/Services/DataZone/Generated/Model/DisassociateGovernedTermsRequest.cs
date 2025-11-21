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
    /// Container for the parameters to the DisassociateGovernedTerms operation.
    /// Disassociates restricted terms from an asset.
    /// </summary>
    public partial class DisassociateGovernedTermsRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _entityIdentifier;
        private GovernedEntityType _entityType;
        private List<string> _governedGlossaryTerms = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where you want to disassociate restricted terms from an asset.
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
        /// The ID of an asset from which you want to disassociate restricted terms.
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
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the asset from which you want to disassociate restricted terms.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GovernedEntityType EntityType
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
        /// Gets and sets the property GovernedGlossaryTerms. 
        /// <para>
        /// The restricted glossary terms that you want to disassociate from an asset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
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

    }
}