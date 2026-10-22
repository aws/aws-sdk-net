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

namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents custom colors for a published portal.
    /// </summary>
    public partial class CustomColors
    {
        /// <summary>
        /// Gets and sets the property AccentColor. 
        /// <para>
        /// Represents the accent color.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public string AccentColor { get; set; }

        /// <summary>
        /// Checks to see if the AccentColor property is set.
        /// </summary>
        internal bool IsSetAccentColor() => this.AccentColor != null;

        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// Represents the background color.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property ErrorValidationColor. 
        /// <para>
        /// The errorValidationColor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public string ErrorValidationColor { get; set; }

        /// <summary>
        /// Checks to see if the ErrorValidationColor property is set.
        /// </summary>
        internal bool IsSetErrorValidationColor() => this.ErrorValidationColor != null;

        /// <summary>
        /// Gets and sets the property HeaderColor. 
        /// <para>
        /// Represents the header color.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public string HeaderColor { get; set; }

        /// <summary>
        /// Checks to see if the HeaderColor property is set.
        /// </summary>
        internal bool IsSetHeaderColor() => this.HeaderColor != null;

        /// <summary>
        /// Gets and sets the property NavigationColor. 
        /// <para>
        /// Represents the navigation color.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public string NavigationColor { get; set; }

        /// <summary>
        /// Checks to see if the NavigationColor property is set.
        /// </summary>
        internal bool IsSetNavigationColor() => this.NavigationColor != null;

        /// <summary>
        /// Gets and sets the property TextColor. 
        /// <para>
        /// Represents the text color.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public string TextColor { get; set; }

        /// <summary>
        /// Checks to see if the TextColor property is set.
        /// </summary>
        internal bool IsSetTextColor() => this.TextColor != null;
    }
}
