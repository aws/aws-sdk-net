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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that overrides, for a single email sending request, the engagement tracking
    /// settings that would otherwise apply. Use these overrides to turn open tracking or
    /// click tracking on or off for an individual message, for example to suppress tracking
    /// in a transactional message that you send from an account or a configuration set that
    /// has tracking enabled.
    /// 
    ///  
    /// <para>
    /// Without an override, engagement tracking is determined by your account-level <c>EngagementMetrics</c>
    /// setting, which you configure using the <c>PutAccountVdmAttributes</c> operation, by
    /// the <c>EngagementMetrics</c> setting of the configuration set that the message uses,
    /// which you configure using the <c>PutConfigurationSetVdmOptions</c> operation, and
    /// by whether that configuration set has an event destination whose <c>MatchingEventTypes</c>
    /// include the <c>OPEN</c> or <c>CLICK</c> event types.
    /// </para>
    ///  
    /// <para>
    /// For more information about tracking open and click events, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/event-publishing.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class TrackingConfigurationOverrides
    {
        private FeatureStatus _clickTrackingEnabled;
        private FeatureStatus _openTrackingEnabled;

        /// <summary>
        /// Gets and sets the property ClickTrackingEnabled. 
        /// <para>
        /// Specifies whether Amazon SES tracks when the recipient clicks a link in this message.
        /// Can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – Amazon SES tracks clicks for this message, even when your account-level
        /// and configuration set settings don't enable click tracking.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Amazon SES doesn't track clicks for this message, even when your
        /// account-level or configuration set settings enable click tracking. Amazon SES doesn't
        /// rewrite the links in the message.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify this value, Amazon SES uses the click tracking setting that would
        /// otherwise apply to the message.
        /// </para>
        ///  <note> 
        /// <para>
        /// Enabling open or click tracking with an override doesn't create an event destination.
        /// Amazon SES records the resulting open and click events in VDM, where you can review
        /// them using VDM metrics and Message Insights. To also receive these events at a destination
        /// that you own, the configuration set that the message uses must have an event destination
        /// that publishes open and click events.
        /// </para>
        ///  </note>
        /// </summary>
        public FeatureStatus ClickTrackingEnabled
        {
            get { return this._clickTrackingEnabled; }
            set { this._clickTrackingEnabled = value; }
        }

        // Check to see if ClickTrackingEnabled property is set
        internal bool IsSetClickTrackingEnabled()
        {
            return this._clickTrackingEnabled != null;
        }

        /// <summary>
        /// Gets and sets the property OpenTrackingEnabled. 
        /// <para>
        /// Specifies whether Amazon SES tracks when the recipient opens this message. Can be
        /// one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – Amazon SES tracks opens for this message, even when your account-level
        /// and configuration set settings don't enable open tracking.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Amazon SES doesn't track opens for this message, even when your
        /// account-level or configuration set settings enable open tracking. Amazon SES doesn't
        /// add the tracking image to the message.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify this value, Amazon SES uses the open tracking setting that would
        /// otherwise apply to the message.
        /// </para>
        /// </summary>
        public FeatureStatus OpenTrackingEnabled
        {
            get { return this._openTrackingEnabled; }
            set { this._openTrackingEnabled = value; }
        }

        // Check to see if OpenTrackingEnabled property is set
        internal bool IsSetOpenTrackingEnabled()
        {
            return this._openTrackingEnabled != null;
        }

    }
}