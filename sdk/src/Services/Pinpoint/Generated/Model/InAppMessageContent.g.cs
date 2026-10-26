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
    /// The configuration for the message content.
    /// </summary>
    public partial class InAppMessageContent
    {
        /// <summary>
        /// Gets and sets the property BackgroundColor. 
        /// <para>
        /// The background color for the message.
        /// </para>
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Checks to see if the BackgroundColor property is set.
        /// </summary>
        internal bool IsSetBackgroundColor() => this.BackgroundColor != null;

        /// <summary>
        /// Gets and sets the property BodyConfig. 
        /// <para>
        /// The configuration for the message body.
        /// </para>
        /// </summary>
        public InAppMessageBodyConfig BodyConfig { get; set; }

        /// <summary>
        /// Checks to see if the BodyConfig property is set.
        /// </summary>
        internal bool IsSetBodyConfig() => this.BodyConfig != null;

        /// <summary>
        /// Gets and sets the property HeaderConfig. 
        /// <para>
        /// The configuration for the message header.
        /// </para>
        /// </summary>
        public InAppMessageHeaderConfig HeaderConfig { get; set; }

        /// <summary>
        /// Checks to see if the HeaderConfig property is set.
        /// </summary>
        internal bool IsSetHeaderConfig() => this.HeaderConfig != null;

        /// <summary>
        /// Gets and sets the property ImageUrl. 
        /// <para>
        /// The image url for the background of message.
        /// </para>
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImageUrl property is set.
        /// </summary>
        internal bool IsSetImageUrl() => this.ImageUrl != null;

        /// <summary>
        /// Gets and sets the property PrimaryBtn. 
        /// <para>
        /// The first button inside the message.
        /// </para>
        /// </summary>
        public InAppMessageButton PrimaryBtn { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryBtn property is set.
        /// </summary>
        internal bool IsSetPrimaryBtn() => this.PrimaryBtn != null;

        /// <summary>
        /// Gets and sets the property SecondaryBtn. 
        /// <para>
        /// The second button inside message.
        /// </para>
        /// </summary>
        public InAppMessageButton SecondaryBtn { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryBtn property is set.
        /// </summary>
        internal bool IsSetSecondaryBtn() => this.SecondaryBtn != null;
    }
}
