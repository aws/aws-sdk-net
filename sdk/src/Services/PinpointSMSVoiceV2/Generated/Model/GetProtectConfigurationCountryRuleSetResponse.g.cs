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
    /// This is the response object from the GetProtectConfigurationCountryRuleSet operation.
    /// </summary>
    public partial class GetProtectConfigurationCountryRuleSetResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CountryRuleSet. 
        /// <para>
        /// A map of ProtectConfigurationCountryRuleSetInformation objects that contain the details
        /// for the requested NumberCapability. The Key is the two-letter ISO country code. For
        /// a list of supported ISO country codes, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-sms-by-country.html">Supported
        /// countries and regions (SMS channel)</a> in the End User Messaging SMS User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public Dictionary<string, ProtectConfigurationCountryRuleSetInformation> CountryRuleSet { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ProtectConfigurationCountryRuleSetInformation>() : null;

        /// <summary>
        /// Checks to see if the CountryRuleSet property is set.
        /// </summary>
        internal bool IsSetCountryRuleSet() => this.CountryRuleSet != null && (this.CountryRuleSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberCapability. 
        /// <para>
        /// The capability type associated with the returned ProtectConfigurationCountryRuleSetInformation
        /// objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NumberCapability NumberCapability { get; set; }

        /// <summary>
        /// Checks to see if the NumberCapability property is set.
        /// </summary>
        internal bool IsSetNumberCapability() => this.NumberCapability != null;

        /// <summary>
        /// Gets and sets the property ProtectConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ProtectConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ProtectConfigurationArn property is set.
        /// </summary>
        internal bool IsSetProtectConfigurationArn() => this.ProtectConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ProtectConfigurationId. 
        /// <para>
        /// The unique identifier for the protect configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProtectConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ProtectConfigurationId property is set.
        /// </summary>
        internal bool IsSetProtectConfigurationId() => this.ProtectConfigurationId != null;
    }
}
