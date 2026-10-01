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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A physical specification for a quote option. Describes the rack or server configuration
    /// that would be deployed.
    /// </summary>
    public partial class QuoteSpecification
    {
        /// <summary>
        /// Gets and sets the property ExistingRackSpecificationDetails. 
        /// <para>
        /// The existing rack specification details, if the specification type is <c>UPDATED_RACK</c>
        /// or <c>EXISTING_RACK</c>.
        /// </para>
        /// </summary>
        public RackSpecificationDetails ExistingRackSpecificationDetails { get; set; }

        /// <summary>
        /// Checks to see if the ExistingRackSpecificationDetails property is set.
        /// </summary>
        internal bool IsSetExistingRackSpecificationDetails() => this.ExistingRackSpecificationDetails != null;

        /// <summary>
        /// Gets and sets the property FinalRackSpecificationDetails. 
        /// <para>
        /// The final rack specification details after the quote is fulfilled.
        /// </para>
        /// </summary>
        public RackSpecificationDetails FinalRackSpecificationDetails { get; set; }

        /// <summary>
        /// Checks to see if the FinalRackSpecificationDetails property is set.
        /// </summary>
        internal bool IsSetFinalRackSpecificationDetails() => this.FinalRackSpecificationDetails != null;

        /// <summary>
        /// Gets and sets the property QuoteSpecificationType. 
        /// <para>
        /// The type of specification. Valid values are <c>NEW_RACK</c>, <c>UPDATED_RACK</c>,
        /// <c>EXISTING_RACK</c>, and <c>SERVER</c>.
        /// </para>
        /// </summary>
        public QuoteSpecificationType QuoteSpecificationType { get; set; }

        /// <summary>
        /// Checks to see if the QuoteSpecificationType property is set.
        /// </summary>
        internal bool IsSetQuoteSpecificationType() => this.QuoteSpecificationType != null;

        /// <summary>
        /// Gets and sets the property ServerSpecificationDetails. 
        /// <para>
        /// The server specification details, if the specification type is <c>SERVER</c>.
        /// </para>
        /// </summary>
        public ServerSpecificationDetails ServerSpecificationDetails { get; set; }

        /// <summary>
        /// Checks to see if the ServerSpecificationDetails property is set.
        /// </summary>
        internal bool IsSetServerSpecificationDetails() => this.ServerSpecificationDetails != null;
    }
}
