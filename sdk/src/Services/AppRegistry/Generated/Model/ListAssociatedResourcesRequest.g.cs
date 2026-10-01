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

namespace Amazon.AppRegistry.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssociatedResources operation. Lists all of
    /// the resources that are associated with the specified application. Results are paginated.
    /// <note> <para> If you share an application, and a consumer account associates a tag
    /// query to the application, all of the users who can access the application can also
    /// view the tag values in all accounts that are associated with it using this API. </para>
    /// </note>
    /// </summary>
    public partial class ListAssociatedResourcesRequest : AmazonAppRegistryRequest
    {
        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        ///  The name, ID, or ARN of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Application { get; set; }

        /// <summary>
        /// Checks to see if the Application property is set.
        /// </summary>
        internal bool IsSetApplication() => this.Application != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The upper bound of the number of results to return (cannot exceed 25). If this parameter
        /// is omitted, it defaults to 25. This value is optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next page of results after a previous API call. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
