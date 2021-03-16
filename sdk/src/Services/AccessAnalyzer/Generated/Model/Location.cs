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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// A location in a policy that is represented as a path through the JSON representation
    /// and a corresponding span.
    /// </summary>
    public partial class Location
    {
        private List<PathElement> _path = new List<PathElement>();
        private Span _span;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// A path in a policy, represented as a sequence of path elements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PathElement> Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null && this._path.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Span. 
        /// <para>
        /// A span in a policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Span Span
        {
            get { return this._span; }
            set { this._span = value; }
        }

        // Check to see if Span property is set
        internal bool IsSetSpan()
        {
            return this._span != null;
        }

    }
}