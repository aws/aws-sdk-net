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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The background configuration for sheets.
    /// </summary>
    public partial class SheetBackgroundStyle
    {
        private string _color;
        private string _gradient;

        /// <summary>
        /// Gets and sets the property Color. 
        /// <para>
        /// The solid color background option for sheets.
        /// </para>
        /// </summary>
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        // Check to see if Color property is set
        internal bool IsSetColor()
        {
            return this._color != null;
        }

        /// <summary>
        /// Gets and sets the property Gradient. 
        /// <para>
        /// The gradient background option for sheets.
        /// </para>
        /// </summary>
        public string Gradient
        {
            get { return this._gradient; }
            set { this._gradient = value; }
        }

        // Check to see if Gradient property is set
        internal bool IsSetGradient()
        {
            return this._gradient != null;
        }

    }
}