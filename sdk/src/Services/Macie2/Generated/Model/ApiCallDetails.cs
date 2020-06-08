/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Reserved for future use.
    /// </summary>
    public partial class ApiCallDetails
    {
        private string _api;
        private string _apiServiceName;
        private DateTime? _firstSeen;
        private DateTime? _lastSeen;

        /// <summary>
        /// Gets and sets the property Api. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string Api
        {
            get { return this._api; }
            set { this._api = value; }
        }

        // Check to see if Api property is set
        internal bool IsSetApi()
        {
            return this._api != null;
        }

        /// <summary>
        /// Gets and sets the property ApiServiceName. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string ApiServiceName
        {
            get { return this._apiServiceName; }
            set { this._apiServiceName = value; }
        }

        // Check to see if ApiServiceName property is set
        internal bool IsSetApiServiceName()
        {
            return this._apiServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property FirstSeen. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public DateTime FirstSeen
        {
            get { return this._firstSeen.GetValueOrDefault(); }
            set { this._firstSeen = value; }
        }

        // Check to see if FirstSeen property is set
        internal bool IsSetFirstSeen()
        {
            return this._firstSeen.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSeen. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public DateTime LastSeen
        {
            get { return this._lastSeen.GetValueOrDefault(); }
            set { this._lastSeen = value; }
        }

        // Check to see if LastSeen property is set
        internal bool IsSetLastSeen()
        {
            return this._lastSeen.HasValue; 
        }

    }
}