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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCampaign operation.
    /// Creates a campaign by deploying a solution version. When a client calls the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// and <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetPersonalizedRanking.html">GetPersonalizedRanking</a>
    /// APIs, a campaign is specified in the request.
    /// 
    ///  
    /// <para>
    ///  <b>Minimum Provisioned TPS and Auto-Scaling</b> 
    /// </para>
    ///  
    /// <para>
    /// A transaction is a single <code>GetRecommendations</code> or <code>GetPersonalizedRanking</code>
    /// call. Transactions per second (TPS) is the throughput and unit of billing for Amazon
    /// Personalize. The minimum provisioned TPS (<code>minProvisionedTPS</code>) specifies
    /// the baseline throughput provisioned by Amazon Personalize, and thus, the minimum billing
    /// charge. If your TPS increases beyond <code>minProvisionedTPS</code>, Amazon Personalize
    /// auto-scales the provisioned capacity up and down, but never below <code>minProvisionedTPS</code>,
    /// to maintain a 70% utilization. There's a short time delay while the capacity is increased
    /// that might cause loss of transactions. It's recommended to start with a low <code>minProvisionedTPS</code>,
    /// track your usage using Amazon CloudWatch metrics, and then increase the <code>minProvisionedTPS</code>
    /// as necessary.
    /// </para>
    ///  
    /// <para>
    ///  <b>Status</b> 
    /// </para>
    ///  
    /// <para>
    /// A campaign can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DELETE PENDING &gt; DELETE IN_PROGRESS
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the campaign status, call <a>DescribeCampaign</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Wait until the <code>status</code> of the campaign is <code>ACTIVE</code> before asking
    /// the campaign for recommendations.
    /// </para>
    ///  </note> <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListCampaigns</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeCampaign</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateCampaign</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteCampaign</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateCampaignRequest : AmazonPersonalizeRequest
    {
        private CampaignConfig _campaignConfig;
        private int? _minProvisionedTPS;
        private string _name;
        private string _solutionVersionArn;

        /// <summary>
        /// Gets and sets the property CampaignConfig. 
        /// <para>
        /// The configuration details of a campaign.
        /// </para>
        /// </summary>
        public CampaignConfig CampaignConfig
        {
            get { return this._campaignConfig; }
            set { this._campaignConfig = value; }
        }

        // Check to see if CampaignConfig property is set
        internal bool IsSetCampaignConfig()
        {
            return this._campaignConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MinProvisionedTPS. 
        /// <para>
        /// Specifies the requested minimum provisioned transactions (recommendations) per second
        /// that Amazon Personalize will support.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int MinProvisionedTPS
        {
            get { return this._minProvisionedTPS.GetValueOrDefault(); }
            set { this._minProvisionedTPS = value; }
        }

        // Check to see if MinProvisionedTPS property is set
        internal bool IsSetMinProvisionedTPS()
        {
            return this._minProvisionedTPS.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the new campaign. The campaign name must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the solution version to deploy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string SolutionVersionArn
        {
            get { return this._solutionVersionArn; }
            set { this._solutionVersionArn = value; }
        }

        // Check to see if SolutionVersionArn property is set
        internal bool IsSetSolutionVersionArn()
        {
            return this._solutionVersionArn != null;
        }

    }
}