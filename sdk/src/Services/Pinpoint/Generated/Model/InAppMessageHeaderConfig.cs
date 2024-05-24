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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
    /// Text config for Message Header.
    /// </summary>
    public partial class InAppMessageHeaderConfig
    {
        private Alignment _alignment;
        private string _header;
        private string _textColor;

        /// <summary>
        /// Gets and sets the property Alignment. 
        /// <para>
        /// The alignment of the text. Valid values: LEFT, CENTER, RIGHT.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Alignment Alignment
        {
            get { return this._alignment; }
            set { this._alignment = value; }
        }

        // Check to see if Alignment property is set
        internal bool IsSetAlignment()
        {
            return this._alignment != null;
        }

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// Message Header.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null;
        }

        /// <summary>
        /// Gets and sets the property TextColor. 
        /// <para>
        /// The text color.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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