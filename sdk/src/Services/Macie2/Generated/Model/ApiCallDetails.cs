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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about an API operation that an entity invoked for an affected
    /// resource.
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
        /// The name of the operation that was invoked most recently and produced the finding.
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
        /// The URL of the Amazon Web Services service that provides the operation, for example:
        /// s3.amazonaws.com.
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
        /// The first date and time, in UTC and extended ISO 8601 format, when any operation was
        /// invoked and produced the finding.
        /// </para>
        /// </summary>
        public DateTime? FirstSeen
        {
            get { return this._firstSeen; }
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
        /// The most recent date and time, in UTC and extended ISO 8601 format, when the specified
        /// operation (api) was invoked and produced the finding.
        /// </para>
        /// </summary>
        public DateTime? LastSeen
        {
            get { return this._lastSeen; }
            set { this._lastSeen = value; }
        }

        // Check to see if LastSeen property is set
        internal bool IsSetLastSeen()
        {
            return this._lastSeen.HasValue; 
        }

    }
}