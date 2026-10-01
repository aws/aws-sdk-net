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
    /// Container for the parameters to the CreateGlossaryTerm operation. Creates a business
    /// glossary term. <para> A glossary term represents an individual entry within the Amazon
    /// DataZone glossary, serving as a standardized definition for a specific business concept
    /// or data element. Each term can include rich metadata such as detailed definitions,
    /// synonyms, related terms, and usage examples. Glossary terms can be linked directly
    /// to data assets, providing business context to technical data elements. This linking
    /// capability helps users understand the business meaning of data fields and ensures
    /// consistent interpretation across different systems and teams. Terms can also have
    /// relationships with other terms, creating a semantic network that reflects the complexity
    /// of business concepts. </para> <para> Prerequisites: </para> <ul> <li> <para> Domain
    /// must exist. </para> </li> <li> <para> Glossary must exist. </para> </li> <li> <para>
    /// The term name must be unique within the glossary. </para> </li> <li> <para> Ensure
    /// term does not conflict with existing terms in hierarchy. </para> </li> </ul>
    /// </summary>
    public partial class CreateGlossaryTermRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which this business glossary term is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property GlossaryIdentifier. 
        /// <para>
        /// The ID of the business glossary in which this term is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GlossaryIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlossaryIdentifier property is set.
        /// </summary>
        internal bool IsSetGlossaryIdentifier() => this.GlossaryIdentifier != null;

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// The long description of this business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 4096)]
        public string LongDescription { get; set; }

        /// <summary>
        /// Checks to see if the LongDescription property is set.
        /// </summary>
        internal bool IsSetLongDescription() => this.LongDescription != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// The short description of this business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 1024)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this business glossary term.
        /// </para>
        /// </summary>
        public GlossaryTermStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TermRelations. 
        /// <para>
        /// The term relations of this business glossary term.
        /// </para>
        /// </summary>
        public TermRelations TermRelations { get; set; }

        /// <summary>
        /// Checks to see if the TermRelations property is set.
        /// </summary>
        internal bool IsSetTermRelations() => this.TermRelations != null;
    }
}
