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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCampaign operation.
    /// <important> 
    /// <para>
    ///  You incur campaign costs while it is active. To avoid unnecessary costs, make sure
    /// to delete the campaign when you are finished. For information about campaign costs,
    /// see <a href="https://aws.amazon.com/personalize/pricing/">Amazon Personalize pricing</a>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Creates a campaign that deploys a solution version. When a client calls the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetRecommendations.html">GetRecommendations</a>
    /// and <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_RS_GetPersonalizedRanking.html">GetPersonalizedRanking</a>
    /// APIs, a campaign is specified in the request.
    /// </para>
    ///  
    /// <para>
    ///  <b>Minimum Provisioned TPS and Auto-Scaling</b> 
    /// </para>
    ///  <important> 
    /// <para>
    ///  A high <c>minProvisionedTPS</c> will increase your cost. We recommend starting with
    /// 1 for <c>minProvisionedTPS</c> (the default). Track your usage using Amazon CloudWatch
    /// metrics, and increase the <c>minProvisionedTPS</c> as necessary.
    /// </para>
    ///  </important> 
    /// <para>
    ///  When you create an Amazon Personalize campaign, you can specify the minimum provisioned
    /// transactions per second (<c>minProvisionedTPS</c>) for the campaign. This is the baseline
    /// transaction throughput for the campaign provisioned by Amazon Personalize. It sets
    /// the minimum billing charge for the campaign while it is active. A transaction is a
    /// single <c>GetRecommendations</c> or <c>GetPersonalizedRanking</c> request. The default
    /// <c>minProvisionedTPS</c> is 1.
    /// </para>
    ///  
    /// <para>
    ///  If your TPS increases beyond the <c>minProvisionedTPS</c>, Amazon Personalize auto-scales
    /// the provisioned capacity up and down, but never below <c>minProvisionedTPS</c>. There's
    /// a short time delay while the capacity is increased that might cause loss of transactions.
    /// When your traffic reduces, capacity returns to the <c>minProvisionedTPS</c>. 
    /// </para>
    ///  
    /// <para>
    /// You are charged for the the minimum provisioned TPS or, if your requests exceed the
    /// <c>minProvisionedTPS</c>, the actual TPS. The actual TPS is the total number of recommendation
    /// requests you make. We recommend starting with a low <c>minProvisionedTPS</c>, track
    /// your usage using Amazon CloudWatch metrics, and then increase the <c>minProvisionedTPS</c>
    /// as necessary.
    /// </para>
    ///  
    /// <para>
    /// For more information about campaign costs, see <a href="https://aws.amazon.com/personalize/pricing/">Amazon
    /// Personalize pricing</a>.
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
    /// To get the campaign status, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeCampaign.html">DescribeCampaign</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Wait until the <c>status</c> of the campaign is <c>ACTIVE</c> before asking the campaign
    /// for recommendations.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListCampaigns.html">ListCampaigns</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeCampaign.html">DescribeCampaign</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_UpdateCampaign.html">UpdateCampaign</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteCampaign.html">DeleteCampaign</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateCampaignRequest : AmazonPersonalizeRequest
    {
        private CampaignConfig _campaignConfig;
        private int? _minProvisionedTPS;
        private string _name;
        private string _solutionVersionArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// that Amazon Personalize will support. A high <c>minProvisionedTPS</c> will increase
        /// your bill. We recommend starting with 1 for <c>minProvisionedTPS</c> (the default).
        /// Track your usage using Amazon CloudWatch metrics, and increase the <c>minProvisionedTPS</c>
        /// as necessary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MinProvisionedTPS
        {
            get { return this._minProvisionedTPS; }
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
        /// The Amazon Resource Name (ARN) of the trained model to deploy with the campaign. To
        /// specify the latest solution version of your solution, specify the ARN of your <i>solution</i>
        /// in <c>SolutionArn/$LATEST</c> format. You must use this format if you set <c>syncWithLatestSolutionVersion</c>
        /// to <c>True</c> in the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CampaignConfig.html">CampaignConfig</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  To deploy a model that isn't the latest solution version of your solution, specify
        /// the ARN of the solution version. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about automatic campaign updates, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/campaigns.html#create-campaign-automatic-latest-sv-update">Enabling
        /// automatic campaign updates</a>. 
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the campaign.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}