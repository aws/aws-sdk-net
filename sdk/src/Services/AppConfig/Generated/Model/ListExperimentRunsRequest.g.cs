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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the ListExperimentRuns operation. Lists the experiment
    /// runs for a specified experiment definition. You can filter by status.
    /// </summary>
    public partial class ListExperimentRunsRequest : AmazonAppConfigRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The application ID or name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationIdentifier property is set.
        /// </summary>
        internal bool IsSetApplicationIdentifier() => this.ApplicationIdentifier != null;

        /// <summary>
        /// Gets and sets the property ExperimentDefinitionIdentifier. 
        /// <para>
        /// The experiment definition ID or name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ExperimentDefinitionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentDefinitionIdentifier property is set.
        /// </summary>
        internal bool IsSetExperimentDefinitionIdentifier() => this.ExperimentDefinitionIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list from a previously truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A filter for the experiment run status.
        /// </para>
        /// </summary>
        public ExperimentRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
