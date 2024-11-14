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
    /// The color palette.
    /// </summary>
    public partial class Palette
    {
        private string _background;
        private string _foreground;

        /// <summary>
        /// Gets and sets the property Background. 
        /// <para>
        /// The background color.
        /// </para>
        /// </summary>
        public string Background
        {
            get { return this._background; }
            set { this._background = value; }
        }

        // Check to see if Background property is set
        internal bool IsSetBackground()
        {
            return this._background != null;
        }

        /// <summary>
        /// Gets and sets the property Foreground. 
        /// <para>
        /// The foreground color.
        /// </para>
        /// </summary>
        public string Foreground
        {
            get { return this._foreground; }
            set { this._foreground = value; }
        }

        // Check to see if Foreground property is set
        internal bool IsSetForeground()
        {
            return this._foreground != null;
        }

    }
}