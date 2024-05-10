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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the match method. Specify one of the match values.
    /// </summary>
    public partial class GrpcRouteMetadataMatchMethod
    {
        private string _exact;
        private string _prefix;
        private MatchRange _range;
        private string _regex;
        private string _suffix;

        /// <summary>
        /// Gets and sets the property Exact. 
        /// <para>
        /// The value sent by the client must match the specified value exactly.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The value sent by the client must begin with the specified characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// An object that represents the range of values to match on.
        /// </para>
        /// </summary>
        public MatchRange Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The value sent by the client must include the specified characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// The value sent by the client must end with the specified characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Suffix
        {
            get { return this._suffix; }
            set { this._suffix = value; }
        }

        // Check to see if Suffix property is set
        internal bool IsSetSuffix()
        {
            return this._suffix != null;
        }

    }
}