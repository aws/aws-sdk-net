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
    /// Container for the parameters to the PutConfigurationSetTrackingOptions operation.
    /// Specify a custom domain to use for open and click tracking elements in email that
    /// you send using Amazon Pinpoint.
    /// </summary>
    public partial class PutConfigurationSetTrackingOptionsRequest : AmazonPinpointEmailRequest
    {
        private string _configurationSetName;
        private string _customRedirectDomain;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that you want to add a custom tracking domain to.
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
        /// Gets and sets the property CustomRedirectDomain. 
        /// <para>
        /// The domain that you want to use to track open and click events.
        /// </para>
        /// </summary>
        public string CustomRedirectDomain
        {
            get { return this._customRedirectDomain; }
            set { this._customRedirectDomain = value; }
        }

        // Check to see if CustomRedirectDomain property is set
        internal bool IsSetCustomRedirectDomain()
        {
            return this._customRedirectDomain != null;
        }

    }
}