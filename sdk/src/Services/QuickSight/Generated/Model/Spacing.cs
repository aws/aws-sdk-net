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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration of spacing (often a margin or padding).
    /// </summary>
    public partial class Spacing
    {
        private string _bottom;
        private string _left;
        private string _right;
        private string _top;

        /// <summary>
        /// Gets and sets the property Bottom. 
        /// <para>
        /// Define the bottom spacing.
        /// </para>
        /// </summary>
        public string Bottom
        {
            get { return this._bottom; }
            set { this._bottom = value; }
        }

        // Check to see if Bottom property is set
        internal bool IsSetBottom()
        {
            return this._bottom != null;
        }

        /// <summary>
        /// Gets and sets the property Left. 
        /// <para>
        /// Define the left spacing.
        /// </para>
        /// </summary>
        public string Left
        {
            get { return this._left; }
            set { this._left = value; }
        }

        // Check to see if Left property is set
        internal bool IsSetLeft()
        {
            return this._left != null;
        }

        /// <summary>
        /// Gets and sets the property Right. 
        /// <para>
        /// Define the right spacing.
        /// </para>
        /// </summary>
        public string Right
        {
            get { return this._right; }
            set { this._right = value; }
        }

        // Check to see if Right property is set
        internal bool IsSetRight()
        {
            return this._right != null;
        }

        /// <summary>
        /// Gets and sets the property Top. 
        /// <para>
        /// Define the top spacing.
        /// </para>
        /// </summary>
        public string Top
        {
            get { return this._top; }
            set { this._top = value; }
        }

        // Check to see if Top property is set
        internal bool IsSetTop()
        {
            return this._top != null;
        }

    }
}