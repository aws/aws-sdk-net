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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
        private string _platform;
        private string _routerTypeIdentifier;
        private string _software;
        private string _vendor;
        private string _xsltTemplateName;
        private string _xsltTemplateNameForMacSec;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The virtual interface router platform.
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property RouterTypeIdentifier. 
        /// <para>
        /// Identifies the router by a combination of vendor, platform, and software version.
        /// For example, <c>CiscoSystemsInc-2900SeriesRouters-IOS124</c>.
        /// </para>
        /// </summary>
        public string RouterTypeIdentifier
        {
            get { return this._routerTypeIdentifier; }
            set { this._routerTypeIdentifier = value; }
        }

        // Check to see if RouterTypeIdentifier property is set
        internal bool IsSetRouterTypeIdentifier()
        {
            return this._routerTypeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Software. 
        /// <para>
        /// The router software. 
        /// </para>
        /// </summary>
        public string Software
        {
            get { return this._software; }
            set { this._software = value; }
        }

        // Check to see if Software property is set
        internal bool IsSetSoftware()
        {
            return this._software != null;
        }

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The vendor for the virtual interface's router.
        /// </para>
        /// </summary>
        public string Vendor
        {
            get { return this._vendor; }
            set { this._vendor = value; }
        }

        // Check to see if Vendor property is set
        internal bool IsSetVendor()
        {
            return this._vendor != null;
        }

        /// <summary>
        /// Gets and sets the property XsltTemplateName. 
        /// <para>
        /// The template for the virtual interface's router.
        /// </para>
        /// </summary>
        public string XsltTemplateName
        {
            get { return this._xsltTemplateName; }
            set { this._xsltTemplateName = value; }
        }

        // Check to see if XsltTemplateName property is set
        internal bool IsSetXsltTemplateName()
        {
            return this._xsltTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property XsltTemplateNameForMacSec. 
        /// <para>
        /// The MAC Security (MACsec) template for the virtual interface's router.
        /// </para>
        /// </summary>
        public string XsltTemplateNameForMacSec
        {
            get { return this._xsltTemplateNameForMacSec; }
            set { this._xsltTemplateNameForMacSec = value; }
        }

        // Check to see if XsltTemplateNameForMacSec property is set
        internal bool IsSetXsltTemplateNameForMacSec()
        {
            return this._xsltTemplateNameForMacSec != null;
        }

    }
}