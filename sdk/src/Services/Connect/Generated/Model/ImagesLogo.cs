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
    /// Contains logo image configuration for workspace themes.
    /// </summary>
    public partial class ImagesLogo
    {
        private string _default;
        private string _favicon;

        /// <summary>
        /// Gets and sets the property Default. 
        /// <para>
        /// The default logo image displayed in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
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

        /// <summary>
        /// Gets and sets the property Favicon. 
        /// <para>
        /// The favicon image displayed in the browser tab.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
        public string Favicon
        {
            get { return this._favicon; }
            set { this._favicon = value; }
        }

        // Check to see if Favicon property is set
        internal bool IsSetFavicon()
        {
            return this._favicon != null;
        }

    }
}