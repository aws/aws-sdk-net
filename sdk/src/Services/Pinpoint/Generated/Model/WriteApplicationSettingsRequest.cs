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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the default settings for an application.
    /// </summary>
    public partial class WriteApplicationSettingsRequest
    {
        private CampaignHook _campaignHook;
        private bool? _cloudWatchMetricsEnabled;
        private bool? _eventTaggingEnabled;
        private ApplicationSettingsJourneyLimits _journeyLimits;
        private CampaignLimits _limits;
        private QuietTime _quietTime;

        /// <summary>
        /// Gets and sets the property CampaignHook. 
        /// <para>
        /// The settings for the AWS Lambda function to invoke by default as a code hook for campaigns
        /// in the application. You can use this hook to customize segments that are used by campaigns
        /// in the application.
        /// </para>
        ///  
        /// <para>
        /// To override these settings and define custom settings for a specific campaign, use
        /// the CampaignHook object of the <link  linkend="apps-application-id-campaigns-campaign-id">Campaign</link>
        /// resource.
        /// </para>
        /// </summary>
        public CampaignHook CampaignHook
        {
            get { return this._campaignHook; }
            set { this._campaignHook = value; }
        }

        // Check to see if CampaignHook property is set
        internal bool IsSetCampaignHook()
        {
            return this._campaignHook != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        /// Specifies whether to enable application-related alarms in Amazon CloudWatch.
        /// </para>
        /// </summary>
        public bool? CloudWatchMetricsEnabled
        {
            get { return this._cloudWatchMetricsEnabled; }
            set { this._cloudWatchMetricsEnabled = value; }
        }

        // Check to see if CloudWatchMetricsEnabled property is set
        internal bool IsSetCloudWatchMetricsEnabled()
        {
            return this._cloudWatchMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventTaggingEnabled.
        /// </summary>
        public bool? EventTaggingEnabled
        {
            get { return this._eventTaggingEnabled; }
            set { this._eventTaggingEnabled = value; }
        }

        // Check to see if EventTaggingEnabled property is set
        internal bool IsSetEventTaggingEnabled()
        {
            return this._eventTaggingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JourneyLimits. 
        /// <para>
        /// The default sending limits for journeys in the application. These limits apply to
        /// each journey for the application but can be overridden, on a per journey basis, with
        /// the JourneyLimits resource.
        /// </para>
        /// </summary>
        public ApplicationSettingsJourneyLimits JourneyLimits
        {
            get { return this._journeyLimits; }
            set { this._journeyLimits = value; }
        }

        // Check to see if JourneyLimits property is set
        internal bool IsSetJourneyLimits()
        {
            return this._journeyLimits != null;
        }

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The default sending limits for campaigns in the application. To override these limits
        /// and define custom limits for a specific campaign or journey, use the <link  linkend="apps-application-id-campaigns-campaign-id">Campaign</link>
        /// resource or the <link  linkend="apps-application-id-journeys-journey-id">Journey</link>
        /// resource, respectively.
        /// </para>
        /// </summary>
        public CampaignLimits Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null;
        }

        /// <summary>
        /// Gets and sets the property QuietTime. 
        /// <para>
        /// The default quiet time for campaigns in the application. Quiet time is a specific
        /// time range when messages aren't sent to endpoints, if all the following conditions
        /// are met:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// The EndpointDemographic.Timezone property of the endpoint is set to a valid value.
        /// </para>
        /// </li> <li>
        /// <para>
        /// The current time in the endpoint's time zone is later than or equal to the time specified
        /// by the QuietTime.Start property for the application (or a campaign or journey that
        /// has custom quiet time settings).
        /// </para>
        /// </li> <li>
        /// <para>
        /// The current time in the endpoint's time zone is earlier than or equal to the time
        /// specified by the QuietTime.End property for the application (or a campaign or journey
        /// that has custom quiet time settings).
        /// </para>
        /// </li></ul> 
        /// <para>
        /// If any of the preceding conditions isn't met, the endpoint will receive messages from
        /// a campaign or journey, even if quiet time is enabled.
        /// </para>
        ///  
        /// <para>
        /// To override the default quiet time settings for a specific campaign or journey, use
        /// the <link  linkend="apps-application-id-campaigns-campaign-id">Campaign</link> resource
        /// or the <link  linkend="apps-application-id-journeys-journey-id">Journey</link> resource
        /// to define a custom quiet time for the campaign or journey.
        /// </para>
        /// </summary>
        public QuietTime QuietTime
        {
            get { return this._quietTime; }
            set { this._quietTime = value; }
        }

        // Check to see if QuietTime property is set
        internal bool IsSetQuietTime()
        {
            return this._quietTime != null;
        }

    }
}