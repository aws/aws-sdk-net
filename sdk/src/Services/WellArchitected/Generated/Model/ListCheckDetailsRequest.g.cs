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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the ListCheckDetails operation. List of Trusted Advisor
    /// check details by account related to the workload.
    /// </summary>
    public partial class ListCheckDetailsRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property ChoiceId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ChoiceId { get; set; }

        /// <summary>
        /// Checks to see if the ChoiceId property is set.
        /// </summary>
        internal bool IsSetChoiceId() => this.ChoiceId != null;

        /// <summary>
        /// Gets and sets the property LensArn. 
        /// <para>
        /// Well-Architected Lens ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LensArn { get; set; }

        /// <summary>
        /// Checks to see if the LensArn property is set.
        /// </summary>
        internal bool IsSetLensArn() => this.LensArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PillarId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PillarId { get; set; }

        /// <summary>
        /// Checks to see if the PillarId property is set.
        /// </summary>
        internal bool IsSetPillarId() => this.PillarId != null;

        /// <summary>
        /// Gets and sets the property QuestionId.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string QuestionId { get; set; }

        /// <summary>
        /// Checks to see if the QuestionId property is set.
        /// </summary>
        internal bool IsSetQuestionId() => this.QuestionId != null;

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;
    }
}
