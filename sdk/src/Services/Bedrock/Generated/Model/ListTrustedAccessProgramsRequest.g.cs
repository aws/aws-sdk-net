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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListTrustedAccessPrograms operation. Lists all
    /// trusted access programs visible to your account, ordered by program ID. Amazon Bedrock
    /// resolves participation for your account and its current organization. If you specify
    /// a project, Amazon Bedrock resolves participation for the project, including inheritance
    /// from the account and organization. Archived projects remain readable until they expire.
    /// Amazon Bedrock returns all visible programs in one response.
    /// </summary>
    public partial class ListTrustedAccessProgramsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Reserved for future pagination support. Currently ignored; the response includes all
        /// visible programs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Reserved for future pagination support. Omit this field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The ID or ARN of a named Bedrock project owned by the calling account in this Region.
        /// When omitted, resolves participation for the calling account, including participation
        /// inherited from its current organization. When specified, resolves participation for
        /// the project, including participation inherited from the account and its current organization.
        /// You cannot specify the default project. Omit this field to resolve its inherited participation.
        /// An ARN from another account, Region, or partition returns ValidationException. A project
        /// that does not exist in the calling account returns ResourceNotFoundException.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetProjectIdentifier() => this.ProjectIdentifier != null;
    }
}
