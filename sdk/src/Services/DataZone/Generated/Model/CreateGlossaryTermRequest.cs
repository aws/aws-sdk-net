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
    /// Container for the parameters to the CreateGlossaryTerm operation.
    /// Creates a business glossary term.
    /// 
    ///  
    /// <para>
    /// A glossary term represents an individual entry within the Amazon DataZone glossary,
    /// serving as a standardized definition for a specific business concept or data element.
    /// Each term can include rich metadata such as detailed definitions, synonyms, related
    /// terms, and usage examples. Glossary terms can be linked directly to data assets, providing
    /// business context to technical data elements. This linking capability helps users understand
    /// the business meaning of data fields and ensures consistent interpretation across different
    /// systems and teams. Terms can also have relationships with other terms, creating a
    /// semantic network that reflects the complexity of business concepts.
    /// </para>
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Domain must exist. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Glossary must exist.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The term name must be unique within the glossary.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Ensure term does not conflict with existing terms in hierarchy.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateGlossaryTermRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private string _domainIdentifier;
        private string _glossaryIdentifier;
        private string _longDescription;
        private string _name;
        private string _shortDescription;
        private GlossaryTermStatus _status;
        private TermRelations _termRelations;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which this business glossary term is created.
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
        /// Gets and sets the property GlossaryIdentifier. 
        /// <para>
        /// The ID of the business glossary in which this term is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlossaryIdentifier
        {
            get { return this._glossaryIdentifier; }
            set { this._glossaryIdentifier = value; }
        }

        // Check to see if GlossaryIdentifier property is set
        internal bool IsSetGlossaryIdentifier()
        {
            return this._glossaryIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// The long description of this business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
        public string LongDescription
        {
            get { return this._longDescription; }
            set { this._longDescription = value; }
        }

        // Check to see if LongDescription property is set
        internal bool IsSetLongDescription()
        {
            return this._longDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this business glossary term.
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
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// The short description of this business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string ShortDescription
        {
            get { return this._shortDescription; }
            set { this._shortDescription = value; }
        }

        // Check to see if ShortDescription property is set
        internal bool IsSetShortDescription()
        {
            return this._shortDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this business glossary term.
        /// </para>
        /// </summary>
        public GlossaryTermStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TermRelations. 
        /// <para>
        /// The term relations of this business glossary term.
        /// </para>
        /// </summary>
        public TermRelations TermRelations
        {
            get { return this._termRelations; }
            set { this._termRelations = value; }
        }

        // Check to see if TermRelations property is set
        internal bool IsSetTermRelations()
        {
            return this._termRelations != null;
        }

    }
}