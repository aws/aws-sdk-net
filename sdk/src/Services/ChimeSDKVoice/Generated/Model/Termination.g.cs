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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Termination settings enable SIP hosts to make outbound calls using an Amazon Chime
    /// SDK Voice Connector.
    /// </summary>
    public partial class Termination
    {
        /// <summary>
        /// Gets and sets the property CallingRegions. 
        /// <para>
        /// The countries to which calls are allowed, in ISO 3166-1 alpha-2 format. Required.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CallingRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CallingRegions property is set.
        /// </summary>
        internal bool IsSetCallingRegions() => this.CallingRegions != null && (this.CallingRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CidrAllowedList. 
        /// <para>
        /// The IP addresses allowed to make calls, in CIDR format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CidrAllowedList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CidrAllowedList property is set.
        /// </summary>
        internal bool IsSetCidrAllowedList() => this.CidrAllowedList != null && (this.CidrAllowedList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CpsLimit. 
        /// <para>
        /// The limit on calls per second. Max value based on account service quota. Default value
        /// of 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? CpsLimit { get; set; }

        /// <summary>
        /// Checks to see if the CpsLimit property is set.
        /// </summary>
        internal bool IsSetCpsLimit() => this.CpsLimit.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultPhoneNumber. 
        /// <para>
        /// The default outbound calling number.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DefaultPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DefaultPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDefaultPhoneNumber() => this.DefaultPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When termination is disabled, outbound calls cannot be made.
        /// </para>
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// Checks to see if the Disabled property is set.
        /// </summary>
        internal bool IsSetDisabled() => this.Disabled.HasValue;
    }
}
