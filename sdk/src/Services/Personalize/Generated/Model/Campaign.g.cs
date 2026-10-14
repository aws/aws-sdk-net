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

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// An object that describes the deployment of a solution version. For more information
    /// on campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
    /// </summary>
    public partial class Campaign
    {
        /// <summary>
        /// Gets and sets the property CampaignArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the campaign. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CampaignArn { get; set; }

        /// <summary>
        /// Checks to see if the CampaignArn property is set.
        /// </summary>
        internal bool IsSetCampaignArn() => this.CampaignArn != null;

        /// <summary>
        /// Gets and sets the property CampaignConfig. 
        /// <para>
        /// The configuration details of a campaign.
        /// </para>
        /// </summary>
        public CampaignConfig CampaignConfig { get; set; }

        /// <summary>
        /// Checks to see if the CampaignConfig property is set.
        /// </summary>
        internal bool IsSetCampaignConfig() => this.CampaignConfig != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the campaign was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If a campaign fails, the reason behind the failure.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time (in Unix format) that the campaign was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestCampaignUpdate. 
        /// <para>
        /// Provides a summary of the properties of a campaign update. For a complete listing,
        /// call the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeCampaign.html">DescribeCampaign</a>
        /// API.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>latestCampaignUpdate</c> field is only returned when the campaign has had at
        /// least one <c>UpdateCampaign</c> call. 
        /// </para>
        ///  </note>
        /// </summary>
        public CampaignUpdateSummary LatestCampaignUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LatestCampaignUpdate property is set.
        /// </summary>
        internal bool IsSetLatestCampaignUpdate() => this.LatestCampaignUpdate != null;

        /// <summary>
        /// Gets and sets the property MinProvisionedTPS. 
        /// <para>
        /// Specifies the requested minimum provisioned transactions (recommendations) per second.
        /// A high <c>minProvisionedTPS</c> will increase your bill. We recommend starting with
        /// 1 for <c>minProvisionedTPS</c> (the default). Track your usage using Amazon CloudWatch
        /// metrics, and increase the <c>minProvisionedTPS</c> as necessary.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MinProvisionedTPS { get; set; }

        /// <summary>
        /// Checks to see if the MinProvisionedTPS property is set.
        /// </summary>
        internal bool IsSetMinProvisionedTPS() => this.MinProvisionedTPS.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution version the campaign uses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SolutionVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SolutionVersionArn property is set.
        /// </summary>
        internal bool IsSetSolutionVersionArn() => this.SolutionVersionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the campaign.
        /// </para>
        ///  
        /// <para>
        /// A campaign can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING > CREATE IN_PROGRESS > ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE PENDING > DELETE IN_PROGRESS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
