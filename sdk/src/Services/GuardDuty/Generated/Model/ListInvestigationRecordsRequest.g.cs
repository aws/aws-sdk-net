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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the ListInvestigationRecords operation. This API is
    /// currently available as a preview. This feature is available in the following Amazon
    /// Web Services Regions: US East (N. Virginia), US East (Ohio), US West (Oregon), Canada
    /// (Central), Europe (Frankfurt), Europe (Ireland), Europe (London), Europe (Paris),
    /// Europe (Stockholm), and Asia Pacific (Tokyo). <para> Returns the records for a specific
    /// GuardDuty investigation. Each record is one step in the reasoning that GuardDuty followed
    /// to reach the results of the investigation. </para> <para> An administrator account
    /// can list the records of any investigation within the organization. Member accounts
    /// can only list the records of investigations that belong to them. </para>
    /// </summary>
    public partial class ListInvestigationRecordsRequest : AmazonGuardDutyRequest
    {
        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the GuardDuty detector associated with the investigation.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The unique identifier of the investigation whose records you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string InvestigationId { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationId property is set.
        /// </summary>
        internal bool IsSetInvestigationId() => this.InvestigationId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of records to return in a single response. Valid values are 1 to
        /// 50. The default value is 20. A response can contain fewer records than this value,
        /// or no records, and still include a <c>NextToken</c>.
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
        /// You can use this parameter when paginating results. Set the value of this parameter
        /// to null on your first call to the list action. For subsequent calls to the action,
        /// fill nextToken in the request with the value of NextToken from the previous response
        /// to continue listing data. Use the same <c>InvestigationId</c> and <c>RecordTypes</c>
        /// values that you used in the previous request.
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter for an investigation whose status isn't <c>COMPLETED</c>,
        /// the operation returns a <c>BadRequestException</c>. A <c>NextToken</c> expires 24
        /// hours after it's returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RecordTypes. 
        /// <para>
        /// The types of records to return. Possible values are <c>UPDATE</c>, <c>FETCH</c>, <c>OBSERVATION</c>,
        /// <c>ANALYSIS</c>, and <c>METADATA</c>. If you don't specify this parameter, GuardDuty
        /// returns records of all types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> RecordTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecordTypes property is set.
        /// </summary>
        internal bool IsSetRecordTypes() => this.RecordTypes != null && (this.RecordTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
