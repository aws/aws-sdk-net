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

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the ListArtifacts operation. Returns a list of end-to-end
    /// testing artifacts for a specified app, branch, and job. <para> To return the build
    /// artifacts, use the <a href="https://docs.aws.amazon.com/amplify/latest/APIReference/API_GetJob.html">GetJob</a>
    /// API. </para> <para> For more information about Amplify testing support, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/running-tests.html">Setting
    /// up end-to-end Cypress tests for your Amplify application</a> in the <i>Amplify Hosting
    /// User Guide</i>. </para>
    /// </summary>
    public partial class ListArtifactsRequest : AmazonAmplifyRequest
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        /// The name of a branch that is part of an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string BranchName { get; set; }

        /// <summary>
        /// Checks to see if the BranchName property is set.
        /// </summary>
        internal bool IsSetBranchName() => this.BranchName != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique ID for a job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to list in a single response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token. Set to null to start listing artifacts from start. If a non-null
        /// pagination token is returned in a result, pass its value in here to list more artifacts.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
