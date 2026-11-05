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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Default button configuration.
    /// </summary>
    public partial class DefaultButtonConfiguration
    {
        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color of the button.
        /// </para>
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property BorderRadius. 
        /// <para>
        /// The border radius of the button.
        /// </para>
        /// </summary>
        public int? BorderRadius { get; set; }

        /// <summary>
        /// Checks to see if the BorderRadius property is set.
        /// </summary>
        internal bool IsSetBorderRadius() => this.BorderRadius.HasValue;

        /// <summary>
        /// Gets and sets the property ButtonAction. 
        /// <para>
        /// Action triggered by the button.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ButtonAction ButtonAction { get; set; }

        /// <summary>
        /// Checks to see if the ButtonAction property is set.
        /// </summary>
        internal bool IsSetButtonAction() => this.ButtonAction != null;

        /// <summary>
        /// Gets and sets the property Link. 
        /// <para>
        /// Button destination.
        /// </para>
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Checks to see if the Link property is set.
        /// </summary>
        internal bool IsSetLink() => this.Link != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Button text.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property TextColor. 
        /// <para>
        /// The text color of the button.
        /// </para>
        /// </summary>
        public string TextColor { get; set; }

        /// <summary>
        /// Checks to see if the TextColor property is set.
        /// </summary>
        internal bool IsSetTextColor() => this.TextColor != null;
    }
}
