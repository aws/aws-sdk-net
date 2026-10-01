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
    /// Container for the parameters to the DeleteGlossary operation. Deletes a business glossary
    /// in Amazon DataZone. <para> Prerequisites: </para> <ul> <li> <para> The glossary must
    /// be in DISABLED state. </para> </li> <li> <para> The glossary must not have any glossary
    /// terms associated with it. </para> </li> <li> <para> The glossary must exist in the
    /// specified domain. </para> </li> <li> <para> The caller must have the <c>datazone:DeleteGlossary</c>
    /// permission in the domain and glossary. </para> </li> <li> <para> Glossary should not
    /// be linked to any active metadata forms. </para> </li> </ul>
    /// </summary>
    public partial class DeleteGlossaryRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the business glossary is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the business glossary that is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;
    }
}
