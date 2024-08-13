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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
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
namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// Contains the resource id (<c>rid</c>) and the time it took to process the request
    /// (<c>timems</c>).
    /// </summary>
    public partial class SuggestStatus
    {
        private string _rid;
        private long? _timems;

        /// <summary>
        /// Gets and sets the property Rid. 
        /// <para>
        /// The encrypted resource ID for the request.
        /// </para>
        /// </summary>
        public string Rid
        {
            get { return this._rid; }
            set { this._rid = value; }
        }

        // Check to see if Rid property is set
        internal bool IsSetRid()
        {
            return this._rid != null;
        }

        /// <summary>
        /// Gets and sets the property Timems. 
        /// <para>
        /// How long it took to process the request, in milliseconds.
        /// </para>
        /// </summary>
        public long? Timems
        {
            get { return this._timems; }
            set { this._timems = value; }
        }

        // Check to see if Timems property is set
        internal bool IsSetTimems()
        {
            return this._timems.HasValue; 
        }

    }
}