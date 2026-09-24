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
    /// Container for the parameters to the UpdateGlossaryTerm operation. Updates a business
    /// glossary term in Amazon DataZone. <para> Prerequisites: </para> <ul> <li> <para> Glossary
    /// term must exist in the specified domain. </para> </li> <li> <para> New name must not
    /// conflict with existing terms in the same glossary. </para> </li> <li> <para> User
    /// must have permissions on the term. </para> </li> <li> <para> The term must not be
    /// in DELETED status. </para> </li> </ul>
    /// </summary>
    public partial class UpdateGlossaryTermRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which a business glossary term is
        /// to be updated.
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
        /// The identifier of the business glossary in which a term is to be updated.
        /// </para>
        /// </summary>
        public string GlossaryIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GlossaryIdentifier property is set.
        /// </summary>
        internal bool IsSetGlossaryIdentifier() => this.GlossaryIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the business glossary term that is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// The long description to be updated as part of the <c>UpdateGlossaryTerm</c> action.
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
        /// The name to be updated as part of the <c>UpdateGlossaryTerm</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// The short description to be updated as part of the <c>UpdateGlossaryTerm</c> action.
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
        /// The status to be updated as part of the <c>UpdateGlossaryTerm</c> action.
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
        /// The term relations to be updated as part of the <c>UpdateGlossaryTerm</c> action.
        /// </para>
        /// </summary>
        public TermRelations TermRelations { get; set; }

        /// <summary>
        /// Checks to see if the TermRelations property is set.
        /// </summary>
        internal bool IsSetTermRelations() => this.TermRelations != null;
    }
}
