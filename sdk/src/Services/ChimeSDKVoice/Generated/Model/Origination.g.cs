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
    /// Origination settings enable your SIP hosts to receive inbound calls using your Amazon
    /// Chime SDK Voice Connector.
    /// 
    ///  <note> 
    /// <para>
    /// The parameters listed below are not required, but you must use at least one.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Origination
    {
        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When origination settings are disabled, inbound calls are not enabled for your Amazon
        /// Chime SDK Voice Connector. This parameter is not required, but you must specify this
        /// parameter or <c>Routes</c>.
        /// </para>
        /// </summary>
        public bool? Disabled { get; set; }

        /// <summary>
        /// Checks to see if the Disabled property is set.
        /// </summary>
        internal bool IsSetDisabled() => this.Disabled.HasValue;

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// The call distribution properties defined for your SIP hosts. Valid range: Minimum
        /// value of 1. Maximum value of 20. This parameter is not required, but you must specify
        /// this parameter or <c>Disabled</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OriginationRoute> Routes { get; set; } = AWSConfigs.InitializeCollections ? new List<OriginationRoute>() : null;

        /// <summary>
        /// Checks to see if the Routes property is set.
        /// </summary>
        internal bool IsSetRoutes() => this.Routes != null && (this.Routes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
