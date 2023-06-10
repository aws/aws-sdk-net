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
    /// Describes a path match type. Each rule can include only one of the following types
    /// of paths.
    /// </summary>
    public partial class PathMatchType
    {
        private string _exact;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Exact. 
        /// <para>
        /// An exact match of the path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Exact
        {
            get { return this._exact; }
            set { this._exact = value; }
        }

        // Check to see if Exact property is set
        internal bool IsSetExact()
        {
            return this._exact != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A prefix match of the path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}