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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// This is the response object from the GetTheme operation.
    /// </summary>
    public partial class GetThemeResponse : AmazonWebServiceResponse
    {
        private Theme _theme;

        /// <summary>
        /// Gets and sets the property Theme. 
        /// <para>
        /// Represents the configuration settings for the theme.
        /// </para>
        /// </summary>
        public Theme Theme
        {
            get { return this._theme; }
            set { this._theme = value; }
        }

        // Check to see if Theme property is set
        internal bool IsSetTheme()
        {
            return this._theme != null;
        }

    }
}