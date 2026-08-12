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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the GetAgentRecommendationGeneration operation.
    /// Retrieves information about a recommendation generation process, including its status,
    /// progress, and results. Recommendation generation is asynchronous: poll this operation
    /// until status reaches a terminal value of COMPLETED (results are ready) or ERROR (see
    /// errorDetails). Intermediate values are QUEUED and IN_PROGRESS.
    /// </summary>
    public partial class GetAgentRecommendationGenerationRequest : AmazonWellArchitectedRequest
    {
        private string _generationId;
        private string _profileArn;

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The unique identifier of the recommendation generation to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GenerationId
        {
            get { return this._generationId; }
            set { this._generationId = value; }
        }

        // Check to see if GenerationId property is set
        internal bool IsSetGenerationId()
        {
            return this._generationId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The ARN of the optimization profile associated with this generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ProfileArn
        {
            get { return this._profileArn; }
            set { this._profileArn = value; }
        }

        // Check to see if ProfileArn property is set
        internal bool IsSetProfileArn()
        {
            return this._profileArn != null;
        }

    }
}