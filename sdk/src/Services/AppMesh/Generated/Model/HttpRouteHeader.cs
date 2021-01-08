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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the HTTP header in the request.
    /// </summary>
    public partial class HttpRouteHeader
    {
        private bool? _invert;
        private HeaderMatchMethod _match;
        private string _name;

        /// <summary>
        /// Gets and sets the property Invert. 
        /// <para>
        /// Specify <code>True</code> to match anything except the match criteria. The default
        /// value is <code>False</code>.
        /// </para>
        /// </summary>
        public bool Invert
        {
            get { return this._invert.GetValueOrDefault(); }
            set { this._invert = value; }
        }

        // Check to see if Invert property is set
        internal bool IsSetInvert()
        {
            return this._invert.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// The <code>HeaderMatchMethod</code> object.
        /// </para>
        /// </summary>
        public HeaderMatchMethod Match
        {
            get { return this._match; }
            set { this._match = value; }
        }

        // Check to see if Match property is set
        internal bool IsSetMatch()
        {
            return this._match != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the HTTP header in the client request that will be matched on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}