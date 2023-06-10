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
    /// Describes criteria that can be applied to incoming requests.
    /// </summary>
    public partial class HttpMatch
    {
        private List<HeaderMatch> _headerMatches = new List<HeaderMatch>();
        private string _method;
        private PathMatch _pathMatch;

        /// <summary>
        /// Gets and sets the property HeaderMatches. 
        /// <para>
        /// The header matches. Matches incoming requests with rule based on request header value
        /// before applying rule action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<HeaderMatch> HeaderMatches
        {
            get { return this._headerMatches; }
            set { this._headerMatches = value; }
        }

        // Check to see if HeaderMatches property is set
        internal bool IsSetHeaderMatches()
        {
            return this._headerMatches != null && this._headerMatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The HTTP method type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public string Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

        /// <summary>
        /// Gets and sets the property PathMatch. 
        /// <para>
        /// The path match.
        /// </para>
        /// </summary>
        public PathMatch PathMatch
        {
            get { return this._pathMatch; }
            set { this._pathMatch = value; }
        }

        // Check to see if PathMatch property is set
        internal bool IsSetPathMatch()
        {
            return this._pathMatch != null;
        }

    }
}