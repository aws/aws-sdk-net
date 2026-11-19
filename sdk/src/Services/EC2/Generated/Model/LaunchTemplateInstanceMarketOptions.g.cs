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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The market (purchasing) option for the instances.
    /// </summary>
    public partial class LaunchTemplateInstanceMarketOptions
    {
        /// <summary>
        /// Gets and sets the property MarketType. 
        /// <para>
        /// The market type.
        /// </para>
        /// </summary>
        public MarketType MarketType { get; set; }

        /// <summary>
        /// Checks to see if the MarketType property is set.
        /// </summary>
        internal bool IsSetMarketType() => this.MarketType != null;

        /// <summary>
        /// Gets and sets the property SpotOptions. 
        /// <para>
        /// The options for Spot Instances.
        /// </para>
        /// </summary>
        public LaunchTemplateSpotMarketOptions SpotOptions { get; set; }

        /// <summary>
        /// Checks to see if the SpotOptions property is set.
        /// </summary>
        internal bool IsSetSpotOptions() => this.SpotOptions != null;
    }
}
