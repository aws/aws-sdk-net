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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Defines the theme for a portal.
    /// </summary>
    public partial class PortalTheme
    {
        private CustomColors _customColors;
        private DateTime? _logoLastUploaded;

        /// <summary>
        /// Gets and sets the property CustomColors. 
        /// <para>
        /// Defines custom color values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomColors CustomColors
        {
            get { return this._customColors; }
            set { this._customColors = value; }
        }

        // Check to see if CustomColors property is set
        internal bool IsSetCustomColors()
        {
            return this._customColors != null;
        }

        /// <summary>
        /// Gets and sets the property LogoLastUploaded. 
        /// <para>
        /// The timestamp when the logo was last uploaded.
        /// </para>
        /// </summary>
        public DateTime? LogoLastUploaded
        {
            get { return this._logoLastUploaded; }
            set { this._logoLastUploaded = value; }
        }

        // Check to see if LogoLastUploaded property is set
        internal bool IsSetLogoLastUploaded()
        {
            return this._logoLastUploaded.HasValue; 
        }

    }
}