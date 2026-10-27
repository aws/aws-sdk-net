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
    /// Container for the parameters to the ListDesignations operation. Lists the designations
    /// in a domain. Returns system-managed designations first, followed by user-created designations
    /// sorted alphabetically by name.
    /// </summary>
    public partial class ListDesignationsRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain that contains the designations to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of designations to return in a single call to <c>ListDesignations</c>.
        /// If the number of designations exceeds <c>MaxResults</c>, the response includes a <c>NextToken</c>
        /// value. Use that token in a subsequent call to <c>ListDesignations</c> to retrieve
        /// the next set of designations. The default value is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the results exceed the value of <c>MaxResults</c>, the previous call returns a
        /// pagination token. Specify this token in a subsequent call to <c>ListDesignations</c>
        /// to retrieve the next set of results. If not specified, the operation returns the first
        /// page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
