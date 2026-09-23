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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// </summary>
    public partial class BackendConnectionErrors
    {
        /// <summary>
        /// Gets and sets the property ConnectionRefusedCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? ConnectionRefusedCount { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionRefusedCount property is set.
        /// </summary>
        internal bool IsSetConnectionRefusedCount() => this.ConnectionRefusedCount.HasValue;

        /// <summary>
        /// Gets and sets the property HTTPCode4XXCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? HTTPCode4XXCount { get; set; }

        /// <summary>
        /// Checks to see if the HTTPCode4XXCount property is set.
        /// </summary>
        internal bool IsSetHTTPCode4XXCount() => this.HTTPCode4XXCount.HasValue;

        /// <summary>
        /// Gets and sets the property HTTPCode5XXCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? HTTPCode5XXCount { get; set; }

        /// <summary>
        /// Checks to see if the HTTPCode5XXCount property is set.
        /// </summary>
        internal bool IsSetHTTPCode5XXCount() => this.HTTPCode5XXCount.HasValue;

        /// <summary>
        /// Gets and sets the property OtherCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? OtherCount { get; set; }

        /// <summary>
        /// Checks to see if the OtherCount property is set.
        /// </summary>
        internal bool IsSetOtherCount() => this.OtherCount.HasValue;

        /// <summary>
        /// Gets and sets the property TimeoutCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? TimeoutCount { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutCount property is set.
        /// </summary>
        internal bool IsSetTimeoutCount() => this.TimeoutCount.HasValue;

        /// <summary>
        /// Gets and sets the property UnknownHostCount. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int? UnknownHostCount { get; set; }

        /// <summary>
        /// Checks to see if the UnknownHostCount property is set.
        /// </summary>
        internal bool IsSetUnknownHostCount() => this.UnknownHostCount.HasValue;
    }
}
