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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePlaybackRestrictionPolicy operation. Updates
    /// a specified playback restriction policy.
    /// </summary>
    public partial class UpdatePlaybackRestrictionPolicyRequest : AmazonIVSRequest
    {
        /// <summary>
        /// Gets and sets the property AllowedCountries. 
        /// <para>
        /// A list of country codes that control geoblocking restriction. Allowed values are the
        /// officially assigned <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a> codes. Default: All countries (an empty array).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedCountries { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedCountries property is set.
        /// </summary>
        internal bool IsSetAllowedCountries() => this.AllowedCountries != null && (this.AllowedCountries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedOrigins. 
        /// <para>
        /// A list of origin sites that control CORS restriction. Allowed values are the same
        /// as valid values of the Origin header defined at <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Origin">https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Origin</a>.
        /// Default: All origins (an empty array).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedOrigins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedOrigins property is set.
        /// </summary>
        internal bool IsSetAllowedOrigins() => this.AllowedOrigins != null && (this.AllowedOrigins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the playback-restriction-policy to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property EnableStrictOriginEnforcement. 
        /// <para>
        /// Whether channel playback is constrained by origin site. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableStrictOriginEnforcement { get; set; }

        /// <summary>
        /// Checks to see if the EnableStrictOriginEnforcement property is set.
        /// </summary>
        internal bool IsSetEnableStrictOriginEnforcement() => this.EnableStrictOriginEnforcement.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Playback-restriction-policy name. The value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
