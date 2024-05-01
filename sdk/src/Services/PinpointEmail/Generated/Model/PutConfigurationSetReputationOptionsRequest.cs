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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
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
namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the PutConfigurationSetReputationOptions operation.
    /// Enable or disable collection of reputation metrics for emails that you send using
    /// a particular configuration set in a specific AWS Region.
    /// </summary>
    public partial class PutConfigurationSetReputationOptionsRequest : AmazonPinpointEmailRequest
    {
        private string _configurationSetName;
        private bool? _reputationMetricsEnabled;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that you want to enable or disable reputation metric
        /// tracking for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property ReputationMetricsEnabled. 
        /// <para>
        /// If <c>true</c>, tracking of reputation metrics is enabled for the configuration set.
        /// If <c>false</c>, tracking of reputation metrics is disabled for the configuration
        /// set.
        /// </para>
        /// </summary>
        public bool? ReputationMetricsEnabled
        {
            get { return this._reputationMetricsEnabled; }
            set { this._reputationMetricsEnabled = value; }
        }

        // Check to see if ReputationMetricsEnabled property is set
        internal bool IsSetReputationMetricsEnabled()
        {
            return this._reputationMetricsEnabled.HasValue; 
        }

    }
}