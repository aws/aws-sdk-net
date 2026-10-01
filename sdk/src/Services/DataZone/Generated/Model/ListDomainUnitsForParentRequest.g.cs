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
    /// Container for the parameters to the ListDomainUnitsForParent operation. Lists child
    /// domain units for the specified parent domain unit.
    /// </summary>
    public partial class ListDomainUnitsForParentRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain in which you want to list domain units for a parent domain unit.
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
        /// The maximum number of domain units to return in a single call to ListDomainUnitsForParent.
        /// When the number of domain units to be listed is greater than the value of MaxResults,
        /// the response contains a NextToken value that you can use in a subsequent call to ListDomainUnitsForParent
        /// to list the next set of domain units.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of domain units is greater than the default value for the MaxResults
        /// parameter, or if you explicitly specify a value for MaxResults that is less than the
        /// number of domain units, the response includes a pagination token named NextToken.
        /// You can specify this NextToken value in a subsequent call to ListDomainUnitsForParent
        /// to list the next set of domain units.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ParentDomainUnitIdentifier. 
        /// <para>
        /// The ID of the parent domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ParentDomainUnitIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ParentDomainUnitIdentifier property is set.
        /// </summary>
        internal bool IsSetParentDomainUnitIdentifier() => this.ParentDomainUnitIdentifier != null;
    }
}
