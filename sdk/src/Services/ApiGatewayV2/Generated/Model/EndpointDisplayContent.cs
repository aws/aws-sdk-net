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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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
namespace Amazon.ApiGatewayV2.Model
{
    /// <summary>
    /// Represents the endpoint display content.
    /// </summary>
    public partial class EndpointDisplayContent
    {
        private None _none;
        private DisplayContentOverrides _overrides;

        /// <summary>
        /// Gets and sets the property None. 
        /// <para>
        /// If your product REST endpoint contains no overrides, the none object is returned.
        /// </para>
        /// </summary>
        public None None
        {
            get { return this._none; }
            set { this._none = value; }
        }

        // Check to see if None property is set
        internal bool IsSetNone()
        {
            return this._none != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// The overrides for endpoint display content.
        /// </para>
        /// </summary>
        public DisplayContentOverrides Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null;
        }

    }
}