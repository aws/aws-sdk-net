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

namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the ListBlueprints operation. Lists all existing Amazon
    /// Bedrock Data Automation Blueprints
    /// </summary>
    public partial class ListBlueprintsRequest : AmazonBedrockDataAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property BlueprintArn.
        /// </summary>
        [AWSProperty(Max = 128)]
        public string BlueprintArn { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintArn property is set.
        /// </summary>
        internal bool IsSetBlueprintArn() => this.BlueprintArn != null;

        /// <summary>
        /// Gets and sets the property BlueprintStageFilter.
        /// </summary>
        public BlueprintStageFilter BlueprintStageFilter { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintStageFilter property is set.
        /// </summary>
        internal bool IsSetBlueprintStageFilter() => this.BlueprintStageFilter != null;

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProjectFilter.
        /// </summary>
        public DataAutomationProjectFilter ProjectFilter { get; set; }

        /// <summary>
        /// Checks to see if the ProjectFilter property is set.
        /// </summary>
        internal bool IsSetProjectFilter() => this.ProjectFilter != null;

        /// <summary>
        /// Gets and sets the property ResourceOwner.
        /// </summary>
        public ResourceOwner ResourceOwner { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwner property is set.
        /// </summary>
        internal bool IsSetResourceOwner() => this.ResourceOwner != null;
    }
}
