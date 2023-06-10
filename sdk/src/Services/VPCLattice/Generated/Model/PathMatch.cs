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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes the conditions that can be applied when matching a path for incoming requests.
    /// </summary>
    public partial class PathMatch
    {
        private bool? _caseSensitive;
        private PathMatchType _match;

        /// <summary>
        /// Gets and sets the property CaseSensitive. 
        /// <para>
        /// Indicates whether the match is case sensitive. Defaults to false.
        /// </para>
        /// </summary>
        public bool CaseSensitive
        {
            get { return this._caseSensitive.GetValueOrDefault(); }
            set { this._caseSensitive = value; }
        }

        // Check to see if CaseSensitive property is set
        internal bool IsSetCaseSensitive()
        {
            return this._caseSensitive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// The type of path match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PathMatchType Match
        {
            get { return this._match; }
            set { this._match = value; }
        }

        // Check to see if Match property is set
        internal bool IsSetMatch()
        {
            return this._match != null;
        }

    }
}