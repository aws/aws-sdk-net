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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the last time an access key was used.
    /// 
    ///  <note> 
    /// <para>
    /// This object does not include data in the response of a <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_CreateBucketAccessKey.html">CreateBucketAccessKey</a>
    /// action.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AccessKeyLastUsed
    {
        private DateTime? _lastUsedDate;
        private string _region;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property LastUsedDate. 
        /// <para>
        /// The date and time when the access key was most recently used.
        /// </para>
        ///  
        /// <para>
        /// This value is null if the access key has not been used.
        /// </para>
        /// </summary>
        public DateTime? LastUsedDate
        {
            get { return this._lastUsedDate; }
            set { this._lastUsedDate = value; }
        }

        // Check to see if LastUsedDate property is set
        internal bool IsSetLastUsedDate()
        {
            return this._lastUsedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where this access key was most recently used.
        /// </para>
        ///  
        /// <para>
        /// This value is <c>N/A</c> if the access key has not been used.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Amazon Web Services service with which this access key was most recently
        /// used.
        /// </para>
        ///  
        /// <para>
        /// This value is <c>N/A</c> if the access key has not been used.
        /// </para>
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}