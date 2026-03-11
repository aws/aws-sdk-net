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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains primary color configuration for a workspace theme.
    /// </summary>
    public partial class PalettePrimary
    {
        private string _active;
        private string _contrastText;
        private string _default;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// The primary color used for active states.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active != null;
        }

        /// <summary>
        /// Gets and sets the property ContrastText. 
        /// <para>
        /// The text color that contrasts with the primary color for readability.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ContrastText
        {
            get { return this._contrastText; }
            set { this._contrastText = value; }
        }

        // Check to see if ContrastText property is set
        internal bool IsSetContrastText()
        {
            return this._contrastText != null;
        }

        /// <summary>
        /// Gets and sets the property Default. 
        /// <para>
        /// The default primary color used throughout the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string Default
        {
            get { return this._default; }
            set { this._default = value; }
        }

        // Check to see if Default property is set
        internal bool IsSetDefault()
        {
            return this._default != null;
        }

    }
}