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
    /// Contains theme configuration for a workspace, supporting both light and dark modes.
    /// </summary>
    public partial class WorkspaceTheme
    {
        private WorkspaceThemeConfig _dark;
        private WorkspaceThemeConfig _light;

        /// <summary>
        /// Gets and sets the property Dark. 
        /// <para>
        /// The theme configuration for dark mode.
        /// </para>
        /// </summary>
        public WorkspaceThemeConfig Dark
        {
            get { return this._dark; }
            set { this._dark = value; }
        }

        // Check to see if Dark property is set
        internal bool IsSetDark()
        {
            return this._dark != null;
        }

        /// <summary>
        /// Gets and sets the property Light. 
        /// <para>
        /// The theme configuration for light mode.
        /// </para>
        /// </summary>
        public WorkspaceThemeConfig Light
        {
            get { return this._light; }
            set { this._light = value; }
        }

        // Check to see if Light property is set
        internal bool IsSetLight()
        {
            return this._light != null;
        }

    }
}