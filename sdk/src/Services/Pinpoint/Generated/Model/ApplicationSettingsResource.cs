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
    /// Provides information about an application, including the default settings for an application.
    /// </summary>
    public partial class ApplicationSettingsResource
    {
        private string _applicationId;
        private CampaignHook _campaignHook;
        private ApplicationSettingsJourneyLimits _journeyLimits;
        private string _lastModifiedDate;
        private CampaignLimits _limits;
        private QuietTime _quietTime;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application. This identifier is displayed as the <b>Project
        /// ID</b> on the Amazon Pinpoint console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property CampaignHook. 
        /// <para>
        /// The settings for the AWS Lambda function to invoke by default as a code hook for campaigns
        /// in the application. You can use this hook to customize segments that are used by campaigns
        /// in the application.
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the application's settings were last modified.
        /// </para>
        /// </summary>
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The default sending limits for campaigns in the application.
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