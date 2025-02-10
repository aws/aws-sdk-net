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
    /// The navigation bar style.
    /// </summary>
    public partial class NavbarStyle
    {
        private Palette _contextualNavbar;
        private Palette _globalNavbar;

        /// <summary>
        /// Gets and sets the property ContextualNavbar. 
        /// <para>
        /// The contextual navigation bar style.
        /// </para>
        /// </summary>
        public Palette ContextualNavbar
        {
            get { return this._contextualNavbar; }
            set { this._contextualNavbar = value; }
        }

        // Check to see if ContextualNavbar property is set
        internal bool IsSetContextualNavbar()
        {
            return this._contextualNavbar != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalNavbar. 
        /// <para>
        /// The global navigation bar style.
        /// </para>
        /// </summary>
        public Palette GlobalNavbar
        {
            get { return this._globalNavbar; }
            set { this._globalNavbar = value; }
        }

        // Check to see if GlobalNavbar property is set
        internal bool IsSetGlobalNavbar()
        {
            return this._globalNavbar != null;
        }

    }
}