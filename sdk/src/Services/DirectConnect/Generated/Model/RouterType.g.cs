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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about the virtual router.
    /// </summary>
    public partial class RouterType
    {
        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The virtual interface router platform.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property RouterTypeIdentifier. 
        /// <para>
        /// Identifies the router by a combination of vendor, platform, and software version.
        /// For example, <c>CiscoSystemsInc-2900SeriesRouters-IOS124</c>.
        /// </para>
        /// </summary>
        public string RouterTypeIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RouterTypeIdentifier property is set.
        /// </summary>
        internal bool IsSetRouterTypeIdentifier() => this.RouterTypeIdentifier != null;

        /// <summary>
        /// Gets and sets the property Software. 
        /// <para>
        /// The router software. 
        /// </para>
        /// </summary>
        public string Software { get; set; }

        /// <summary>
        /// Checks to see if the Software property is set.
        /// </summary>
        internal bool IsSetSoftware() => this.Software != null;

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The vendor for the virtual interface's router.
        /// </para>
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// Checks to see if the Vendor property is set.
        /// </summary>
        internal bool IsSetVendor() => this.Vendor != null;

        /// <summary>
        /// Gets and sets the property XsltTemplateName. 
        /// <para>
        /// The template for the virtual interface's router.
        /// </para>
        /// </summary>
        public string XsltTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the XsltTemplateName property is set.
        /// </summary>
        internal bool IsSetXsltTemplateName() => this.XsltTemplateName != null;

        /// <summary>
        /// Gets and sets the property XsltTemplateNameForMacSec. 
        /// <para>
        /// The MAC Security (MACsec) template for the virtual interface's router.
        /// </para>
        /// </summary>
        public string XsltTemplateNameForMacSec { get; set; }

        /// <summary>
        /// Checks to see if the XsltTemplateNameForMacSec property is set.
        /// </summary>
        internal bool IsSetXsltTemplateNameForMacSec() => this.XsltTemplateNameForMacSec != null;
    }
}
