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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListSecurityControlDefinitions operation. Lists
    /// all of the security controls that apply to a specified standard.
    /// </summary>
    public partial class ListSecurityControlDefinitionsRequest : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  An optional parameter that limits the total results of the API response to the specified
        /// number. If this parameter isn't provided in the request, the results include the first
        /// 25 security controls that apply to the specified standard. The results also include
        /// a <c>NextToken</c> parameter that you can use in a subsequent API call to get the
        /// next 25 controls. This repeats until all controls for the standard are returned. 
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
        ///  Optional pagination parameter. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Providers. 
        /// <para>
        /// A list of cloud providers to filter the security control definitions by. For example,
        /// specify <c>Azure</c> to return only controls that evaluate Azure resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Providers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Providers property is set.
        /// </summary>
        internal bool IsSetProviders() => this.Providers != null && (this.Providers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the standard that you want to view controls for.
        /// 
        /// </para>
        /// </summary>
        public string StandardsArn { get; set; }

        /// <summary>
        /// Checks to see if the StandardsArn property is set.
        /// </summary>
        internal bool IsSetStandardsArn() => this.StandardsArn != null;
    }
}
