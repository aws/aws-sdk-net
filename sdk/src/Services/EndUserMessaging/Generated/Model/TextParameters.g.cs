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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// The delivery parameters for the text channel, which delivers over SMS or RCS.
    /// </summary>
    public partial class TextParameters
    {
        /// <summary>
        /// Gets and sets the property DestinationCountryParameters. 
        /// <para>
        /// A map of country-specific parameters that control one-time passcode delivery.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, string> DestinationCountryParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DestinationCountryParameters property is set.
        /// </summary>
        internal bool IsSetDestinationCountryParameters() => this.DestinationCountryParameters != null && (this.DestinationCountryParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InlineTemplateBody. 
        /// <para>
        /// The freeform message template used to render the one-time passcode for the SMS or
        /// RCS channels. The template must contain the code placeholder.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 6000)]
        public string InlineTemplateBody { get; set; }

        /// <summary>
        /// Checks to see if the InlineTemplateBody property is set.
        /// </summary>
        internal bool IsSetInlineTemplateBody() => this.InlineTemplateBody != null;
    }
}
