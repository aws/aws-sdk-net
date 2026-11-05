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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetApiKeys operation. Gets information about the
    /// current ApiKeys resource.
    /// </summary>
    public partial class GetApiKeysRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// The identifier of a customer in Amazon Web Services Marketplace or an external system,
        /// such as a developer portal.
        /// </para>
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerId property is set.
        /// </summary>
        internal bool IsSetCustomerId() => this.CustomerId != null;

        /// <summary>
        /// Gets and sets the property IncludeValues. 
        /// <para>
        /// A boolean flag to specify whether (<c>true</c>) or not (<c>false</c>) the result contains
        /// key values.
        /// </para>
        /// </summary>
        public bool? IncludeValues { get; set; }

        /// <summary>
        /// Checks to see if the IncludeValues property is set.
        /// </summary>
        internal bool IsSetIncludeValues() => this.IncludeValues.HasValue;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of returned results per page. The default value is 25 and the maximum
        /// value is 500.
        /// </para>
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NameQuery. 
        /// <para>
        /// The name of queried API keys.
        /// </para>
        /// </summary>
        public string NameQuery { get; set; }

        /// <summary>
        /// Checks to see if the NameQuery property is set.
        /// </summary>
        internal bool IsSetNameQuery() => this.NameQuery != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The current pagination position in the paged result set.
        /// </para>
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null;
    }
}
