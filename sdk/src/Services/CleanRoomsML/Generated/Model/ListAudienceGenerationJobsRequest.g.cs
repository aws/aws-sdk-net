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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the ListAudienceGenerationJobs operation. Returns
    /// a list of audience generation jobs.
    /// </summary>
    public partial class ListAudienceGenerationJobsRequest : AmazonCleanRoomsMLRequest
    {
        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The identifier of the collaboration that contains the audience generation jobs that
        /// you are interested in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string CollaborationId { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationId property is set.
        /// </summary>
        internal bool IsSetCollaborationId() => this.CollaborationId != null;

        /// <summary>
        /// Gets and sets the property ConfiguredAudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured audience model that was used for
        /// the audience generation jobs that you are interested in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ConfiguredAudienceModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredAudienceModelArn property is set.
        /// </summary>
        internal bool IsSetConfiguredAudienceModelArn() => this.ConfiguredAudienceModelArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum size of the results that is returned per call.
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
        /// The token value retrieved from a previous call to access the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
