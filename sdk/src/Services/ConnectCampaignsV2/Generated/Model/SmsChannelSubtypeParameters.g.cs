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

namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Parameters for the SMS Channel Subtype
    /// </summary>
    public partial class SmsChannelSubtypeParameters
    {
        /// <summary>
        /// Gets and sets the property ConnectSourcePhoneNumberArn.
        /// </summary>
        [AWSProperty(Min = 20, Max = 500)]
        public string ConnectSourcePhoneNumberArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectSourcePhoneNumberArn property is set.
        /// </summary>
        internal bool IsSetConnectSourcePhoneNumberArn() => this.ConnectSourcePhoneNumberArn != null;

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 20)]
        public string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDestinationPhoneNumber() => this.DestinationPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property TemplateArn.
        /// </summary>
        [AWSProperty(Min = 20, Max = 500)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property TemplateParameters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Dictionary<string, string> TemplateParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TemplateParameters property is set.
        /// </summary>
        internal bool IsSetTemplateParameters() => this.TemplateParameters != null && (this.TemplateParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
