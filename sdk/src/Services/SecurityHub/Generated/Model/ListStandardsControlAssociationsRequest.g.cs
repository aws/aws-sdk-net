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
    /// Container for the parameters to the ListStandardsControlAssociations operation. Specifies
    /// whether a control is currently enabled or disabled in each enabled standard in the
    /// calling account. <para> This operation omits standards control associations for standard
    /// subscriptions where <c>StandardsControlsUpdatable</c> has value <c>NOT_READY_FOR_UPDATES</c>.
    /// </para>
    /// </summary>
    public partial class ListStandardsControlAssociationsRequest : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  An optional parameter that limits the total results of the API response to the specified
        /// number. If this parameter isn't provided in the request, the results include the first
        /// 25 standard and control associations. The results also include a <c>NextToken</c>
        /// parameter that you can use in a subsequent API call to get the next 25 associations.
        /// This repeats until all associations for the specified control are returned. The number
        /// of results is limited by the number of supported Security Hub CSPM standards that
        /// you've enabled in the calling account. 
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
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The identifier of the control (identified with <c>SecurityControlId</c>, <c>SecurityControlArn</c>,
        /// or a mix of both parameters) that you want to determine the enablement status of in
        /// each enabled standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecurityControlId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityControlId property is set.
        /// </summary>
        internal bool IsSetSecurityControlId() => this.SecurityControlId != null;
    }
}
