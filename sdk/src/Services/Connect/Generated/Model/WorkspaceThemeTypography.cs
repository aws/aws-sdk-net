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
    /// Contains typography configuration for a workspace theme.
    /// </summary>
    public partial class WorkspaceThemeTypography
    {
        private FontFamily _fontFamily;

        /// <summary>
        /// Gets and sets the property FontFamily. 
        /// <para>
        /// The font family configuration for text in the workspace.
        /// </para>
        /// </summary>
        public FontFamily FontFamily
        {
            get { return this._fontFamily; }
            set { this._fontFamily = value; }
        }

        // Check to see if FontFamily property is set
        internal bool IsSetFontFamily()
        {
            return this._fontFamily != null;
        }

    }
}