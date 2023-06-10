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
    /// Container for the parameters to the UpdateCampaign operation.
    /// Updates a campaign by either deploying a new solution or changing the value of the
    /// campaign's <code>minProvisionedTPS</code> parameter.
    /// 
    ///  
    /// <para>
    /// To update a campaign, the campaign status must be ACTIVE or CREATE FAILED. Check the
    /// campaign status using the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeCampaign.html">DescribeCampaign</a>
    /// operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can still get recommendations from a campaign while an update is in progress.
    /// The campaign will use the previous solution version and campaign configuration to
    /// generate recommendations until the latest campaign update status is <code>Active</code>.
    /// 
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information on campaigns, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateCampaign.html">CreateCampaign</a>.
    /// </para>
    /// </summary>
    public partial class UpdateCampaignRequest : AmazonPersonalizeRequest
    {
        private string _campaignArn;
        private CampaignConfig _campaignConfig;
        private int? _minProvisionedTPS;
        private string _solutionVersionArn;

        /// <summary>
        /// Gets and sets the property CampaignArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string CampaignArn
        {
            get { return this._campaignArn; }
            set { this._campaignArn = value; }
        }

        // Check to see if CampaignArn property is set
        internal bool IsSetCampaignArn()
        {
            return this._campaignArn != null;
        }

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
        /// that Amazon Personalize will support. A high <code>minProvisionedTPS</code> will increase
        /// your bill. We recommend starting with 1 for <code>minProvisionedTPS</code> (the default).
        /// Track your usage using Amazon CloudWatch metrics, and increase the <code>minProvisionedTPS</code>
        /// as necessary.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property SolutionVersionArn. 
        /// <para>
        /// The ARN of a new solution version to deploy.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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