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
    /// Contains color configuration for canvas elements in a workspace theme.
    /// </summary>
    public partial class PaletteCanvas
    {
        private string _activeBackground;
        private string _containerBackground;
        private string _pageBackground;

        /// <summary>
        /// Gets and sets the property ActiveBackground. 
        /// <para>
        /// The background color for active elements.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ActiveBackground
        {
            get { return this._activeBackground; }
            set { this._activeBackground = value; }
        }

        // Check to see if ActiveBackground property is set
        internal bool IsSetActiveBackground()
        {
            return this._activeBackground != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerBackground. 
        /// <para>
        /// The background color for container elements.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ContainerBackground
        {
            get { return this._containerBackground; }
            set { this._containerBackground = value; }
        }

        // Check to see if ContainerBackground property is set
        internal bool IsSetContainerBackground()
        {
            return this._containerBackground != null;
        }

        /// <summary>
        /// Gets and sets the property PageBackground. 
        /// <para>
        /// The background color for page elements.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string PageBackground
        {
            get { return this._pageBackground; }
            set { this._pageBackground = value; }
        }

        // Check to see if PageBackground property is set
        internal bool IsSetPageBackground()
        {
            return this._pageBackground != null;
        }

    }
}