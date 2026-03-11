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
    /// Represents custom colors for a published portal.
    /// </summary>
    public partial class CustomColors
    {
        private string _accentColor;
        private string _backgroundColor;
        private string _errorValidationColor;
        private string _headerColor;
        private string _navigationColor;
        private string _textColor;

        /// <summary>
        /// Gets and sets the property AccentColor. 
        /// <para>
        /// Represents the accent color.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string AccentColor
        {
            get { return this._accentColor; }
            set { this._accentColor = value; }
        }

        // Check to see if AccentColor property is set
        internal bool IsSetAccentColor()
        {
            return this._accentColor != null;
        }

        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// Represents the background color.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string BackgroundColor
        {
            get { return this._backgroundColor; }
            set { this._backgroundColor = value; }
        }

        // Check to see if BackgroundColor property is set
        internal bool IsSetBackgroundColor()
        {
            return this._backgroundColor != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorValidationColor. 
        /// <para>
        /// The errorValidationColor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string ErrorValidationColor
        {
            get { return this._errorValidationColor; }
            set { this._errorValidationColor = value; }
        }

        // Check to see if ErrorValidationColor property is set
        internal bool IsSetErrorValidationColor()
        {
            return this._errorValidationColor != null;
        }

        /// <summary>
        /// Gets and sets the property HeaderColor. 
        /// <para>
        /// Represents the header color.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string HeaderColor
        {
            get { return this._headerColor; }
            set { this._headerColor = value; }
        }

        // Check to see if HeaderColor property is set
        internal bool IsSetHeaderColor()
        {
            return this._headerColor != null;
        }

        /// <summary>
        /// Gets and sets the property NavigationColor. 
        /// <para>
        /// Represents the navigation color.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string NavigationColor
        {
            get { return this._navigationColor; }
            set { this._navigationColor = value; }
        }

        // Check to see if NavigationColor property is set
        internal bool IsSetNavigationColor()
        {
            return this._navigationColor != null;
        }

        /// <summary>
        /// Gets and sets the property TextColor. 
        /// <para>
        /// Represents the text color.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string TextColor
        {
            get { return this._textColor; }
            set { this._textColor = value; }
        }

        // Check to see if TextColor property is set
        internal bool IsSetTextColor()
        {
            return this._textColor != null;
        }

    }
}