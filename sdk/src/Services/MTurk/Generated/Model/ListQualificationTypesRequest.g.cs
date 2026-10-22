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

namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the ListQualificationTypes operation. The <c>ListQualificationTypes</c>
    /// operation returns a list of Qualification types, filtered by an optional search term.
    /// </summary>
    public partial class ListQualificationTypesRequest : AmazonMTurkRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return in a single call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MustBeOwnedByCaller. 
        /// <para>
        ///  Specifies that only Qualification types that the Requester created are returned.
        /// If false, the operation returns all Qualification types. 
        /// </para>
        /// </summary>
        public bool? MustBeOwnedByCaller { get; set; }

        /// <summary>
        /// Checks to see if the MustBeOwnedByCaller property is set.
        /// </summary>
        internal bool IsSetMustBeOwnedByCaller() => this.MustBeOwnedByCaller.HasValue;

        /// <summary>
        /// Gets and sets the property MustBeRequestable. 
        /// <para>
        /// Specifies that only Qualification types that a user can request through the Amazon
        /// Mechanical Turk web site, such as by taking a Qualification test, are returned as
        /// results of the search. Some Qualification types, such as those assigned automatically
        /// by the system, cannot be requested directly by users. If false, all Qualification
        /// types, including those managed by the system, are considered. Valid values are True
        /// | False. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? MustBeRequestable { get; set; }

        /// <summary>
        /// Checks to see if the MustBeRequestable property is set.
        /// </summary>
        internal bool IsSetMustBeRequestable() => this.MustBeRequestable.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        ///  A text query against all of the searchable attributes of Qualification types. 
        /// </para>
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;
    }
}
