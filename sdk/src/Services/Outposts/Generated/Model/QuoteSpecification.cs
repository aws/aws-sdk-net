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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
        private RackSpecificationDetails _existingRackSpecificationDetails;
        private RackSpecificationDetails _finalRackSpecificationDetails;
        private QuoteSpecificationType _quoteSpecificationType;
        private ServerSpecificationDetails _serverSpecificationDetails;

        /// <summary>
        /// Gets and sets the property ExistingRackSpecificationDetails. 
        /// <para>
        /// The existing rack specification details, if the specification type is <c>UPDATED_RACK</c>
        /// or <c>EXISTING_RACK</c>.
        /// </para>
        /// </summary>
        public RackSpecificationDetails ExistingRackSpecificationDetails
        {
            get { return this._existingRackSpecificationDetails; }
            set { this._existingRackSpecificationDetails = value; }
        }

        // Check to see if ExistingRackSpecificationDetails property is set
        internal bool IsSetExistingRackSpecificationDetails()
        {
            return this._existingRackSpecificationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property FinalRackSpecificationDetails. 
        /// <para>
        /// The final rack specification details after the quote is fulfilled.
        /// </para>
        /// </summary>
        public RackSpecificationDetails FinalRackSpecificationDetails
        {
            get { return this._finalRackSpecificationDetails; }
            set { this._finalRackSpecificationDetails = value; }
        }

        // Check to see if FinalRackSpecificationDetails property is set
        internal bool IsSetFinalRackSpecificationDetails()
        {
            return this._finalRackSpecificationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteSpecificationType. 
        /// <para>
        /// The type of specification. Valid values are <c>NEW_RACK</c>, <c>UPDATED_RACK</c>,
        /// <c>EXISTING_RACK</c>, and <c>SERVER</c>.
        /// </para>
        /// </summary>
        public QuoteSpecificationType QuoteSpecificationType
        {
            get { return this._quoteSpecificationType; }
            set { this._quoteSpecificationType = value; }
        }

        // Check to see if QuoteSpecificationType property is set
        internal bool IsSetQuoteSpecificationType()
        {
            return this._quoteSpecificationType != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSpecificationDetails. 
        /// <para>
        /// The server specification details, if the specification type is <c>SERVER</c>.
        /// </para>
        /// </summary>
        public ServerSpecificationDetails ServerSpecificationDetails
        {
            get { return this._serverSpecificationDetails; }
            set { this._serverSpecificationDetails = value; }
        }

        // Check to see if ServerSpecificationDetails property is set
        internal bool IsSetServerSpecificationDetails()
        {
            return this._serverSpecificationDetails != null;
        }

    }
}