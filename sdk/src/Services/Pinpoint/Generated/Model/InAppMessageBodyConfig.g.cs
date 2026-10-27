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
    /// Text config for Message Body.
    /// </summary>
    public partial class InAppMessageBodyConfig
    {
        /// <summary>
        /// Gets and sets the property Alignment. 
        /// <para>
        /// The alignment of the text. Valid values: LEFT, CENTER, RIGHT.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Alignment Alignment { get; set; }

        /// <summary>
        /// Checks to see if the Alignment property is set.
        /// </summary>
        internal bool IsSetAlignment() => this.Alignment != null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// Message Body.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property TextColor. 
        /// <para>
        /// The text color.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TextColor { get; set; }

        /// <summary>
        /// Checks to see if the TextColor property is set.
        /// </summary>
        internal bool IsSetTextColor() => this.TextColor != null;
    }
}
