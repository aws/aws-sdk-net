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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the configuration of the bot control Web Application Firewall (WAF) rule
    /// group.
    /// </summary>
    public partial class WafBotControlConfig
    {
        /// <summary>
        /// Gets and sets the property InspectionLevel. 
        /// <para>
        /// The inspection level of the bot control rule group.
        /// </para>
        ///  
        /// <para>
        /// The following inspection levels are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMMON</c> – Detects a variety of bots that identify themselves, such as web scraping
        /// frameworks, search engines, and automated browsers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TARGETED</c> – Includes the <c>COMMON</c> protections, and adds detection for
        /// sophisticated bots that don't identify themselves. This level uses rate limiting,
        /// CAPTCHA, and background browser challenges.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WafInspectionLevelEnum InspectionLevel { get; set; }

        /// <summary>
        /// Checks to see if the InspectionLevel property is set.
        /// </summary>
        internal bool IsSetInspectionLevel() => this.InspectionLevel != null;
    }
}
