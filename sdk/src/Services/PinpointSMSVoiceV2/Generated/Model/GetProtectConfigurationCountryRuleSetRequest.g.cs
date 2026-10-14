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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetProtectConfigurationCountryRuleSet operation.
    /// Retrieve the CountryRuleSet for the specified NumberCapability from a protect configuration.
    /// </summary>
    public partial class GetProtectConfigurationCountryRuleSetRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property NumberCapability. 
        /// <para>
        /// The capability type to return the CountryRuleSet for. Valid values are <c>SMS</c>,
        /// <c>VOICE</c>, or <c>MMS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NumberCapability NumberCapability { get; set; }

        /// <summary>
        /// Checks to see if the NumberCapability property is set.
        /// </summary>
        internal bool IsSetNumberCapability() => this.NumberCapability != null;

        /// <summary>
        /// Gets and sets the property ProtectConfigurationId. 
        /// <para>
        /// The unique identifier for the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ProtectConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ProtectConfigurationId property is set.
        /// </summary>
        internal bool IsSetProtectConfigurationId() => this.ProtectConfigurationId != null;
    }
}
