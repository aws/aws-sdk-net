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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the ListIncidentFindings operation. Retrieves a list
    /// of the IDs of findings, plus their last modified times, that have been identified
    /// for a specified incident. A finding represents a recent application environment change
    /// made by an CloudFormation stack creation or update or an CodeDeploy deployment that
    /// can be investigated as a potential cause of the incident.
    /// </summary>
    public partial class ListIncidentFindingsRequest : AmazonSSMIncidentsRequest
    {
        /// <summary>
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident for which you want to view associated
        /// findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string IncidentRecordArn { get; set; }

        /// <summary>
        /// Checks to see if the IncidentRecordArn property is set.
        /// </summary>
        internal bool IsSetIncidentRecordArn() => this.IncidentRecordArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of findings to retrieve per call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token for the next set of items to return. (You received this token
        /// from a previous call.)
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
