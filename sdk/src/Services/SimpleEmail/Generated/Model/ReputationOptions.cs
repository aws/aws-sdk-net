/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Contains information about the reputation settings for a configuration set.
    /// </summary>
    public partial class ReputationOptions
    {
        private DateTime? _lastFreshStart;
        private bool? _reputationMetricsEnabled;
        private bool? _sendingEnabled;

        /// <summary>
        /// Gets and sets the property LastFreshStart. 
        /// <para>
        /// The date and time at which the reputation metrics for the configuration set were last
        /// reset. Resetting these metrics is known as a <i>fresh start</i>.
        /// </para>
        ///  
        /// <para>
        /// When you disable email sending for a configuration set using <a>UpdateConfigurationSetSendingEnabled</a>
        /// and later re-enable it, the reputation metrics for the configuration set (but not
        /// for the entire Amazon SES account) are reset.
        /// </para>
        ///  
        /// <para>
        /// If email sending for the configuration set has never been disabled and later re-enabled,
        /// the value of this attribute is <code>null</code>.
        /// </para>
        /// </summary>
        public DateTime LastFreshStart
        {
            get { return this._lastFreshStart.GetValueOrDefault(); }
            set { this._lastFreshStart = value; }
        }

        // Check to see if LastFreshStart property is set
        internal bool IsSetLastFreshStart()
        {
            return this._lastFreshStart.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReputationMetricsEnabled. 
        /// <para>
        /// Describes whether or not Amazon SES publishes reputation metrics for the configuration
        /// set, such as bounce and complaint rates, to Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// If the value is <code>true</code>, reputation metrics are published. If the value
        /// is <code>false</code>, reputation metrics are not published. The default value is
        /// <code>false</code>.
        /// </para>
        /// </summary>
        public bool ReputationMetricsEnabled
        {
            get { return this._reputationMetricsEnabled.GetValueOrDefault(); }
            set { this._reputationMetricsEnabled = value; }
        }

        // Check to see if ReputationMetricsEnabled property is set
        internal bool IsSetReputationMetricsEnabled()
        {
            return this._reputationMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SendingEnabled. 
        /// <para>
        /// Describes whether email sending is enabled or disabled for the configuration set.
        /// If the value is <code>true</code>, then Amazon SES will send emails that use the configuration
        /// set. If the value is <code>false</code>, Amazon SES will not send emails that use
        /// the configuration set. The default value is <code>true</code>. You can change this
        /// setting using <a>UpdateConfigurationSetSendingEnabled</a>.
        /// </para>
        /// </summary>
        public bool SendingEnabled
        {
            get { return this._sendingEnabled.GetValueOrDefault(); }
            set { this._sendingEnabled = value; }
        }

        // Check to see if SendingEnabled property is set
        internal bool IsSetSendingEnabled()
        {
            return this._sendingEnabled.HasValue; 
        }

    }
}