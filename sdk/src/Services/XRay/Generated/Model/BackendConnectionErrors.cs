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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BackendConnectionErrors
    {
        private int? _connectionRefusedCount;
        private int? _httpCode4XXCount;
        private int? _httpCode5XXCount;
        private int? _otherCount;
        private int? _timeoutCount;
        private int? _unknownHostCount;

        /// <summary>
        /// Gets and sets the property ConnectionRefusedCount.
        /// </summary>
        public int? ConnectionRefusedCount
        {
            get { return this._connectionRefusedCount; }
            set { this._connectionRefusedCount = value; }
        }

        // Check to see if ConnectionRefusedCount property is set
        internal bool IsSetConnectionRefusedCount()
        {
            return this._connectionRefusedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HTTPCode4XXCount.
        /// </summary>
        public int? HTTPCode4XXCount
        {
            get { return this._httpCode4XXCount; }
            set { this._httpCode4XXCount = value; }
        }

        // Check to see if HTTPCode4XXCount property is set
        internal bool IsSetHTTPCode4XXCount()
        {
            return this._httpCode4XXCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HTTPCode5XXCount.
        /// </summary>
        public int? HTTPCode5XXCount
        {
            get { return this._httpCode5XXCount; }
            set { this._httpCode5XXCount = value; }
        }

        // Check to see if HTTPCode5XXCount property is set
        internal bool IsSetHTTPCode5XXCount()
        {
            return this._httpCode5XXCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OtherCount.
        /// </summary>
        public int? OtherCount
        {
            get { return this._otherCount; }
            set { this._otherCount = value; }
        }

        // Check to see if OtherCount property is set
        internal bool IsSetOtherCount()
        {
            return this._otherCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutCount.
        /// </summary>
        public int? TimeoutCount
        {
            get { return this._timeoutCount; }
            set { this._timeoutCount = value; }
        }

        // Check to see if TimeoutCount property is set
        internal bool IsSetTimeoutCount()
        {
            return this._timeoutCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnknownHostCount.
        /// </summary>
        public int? UnknownHostCount
        {
            get { return this._unknownHostCount; }
            set { this._unknownHostCount = value; }
        }

        // Check to see if UnknownHostCount property is set
        internal bool IsSetUnknownHostCount()
        {
            return this._unknownHostCount.HasValue; 
        }

    }
}