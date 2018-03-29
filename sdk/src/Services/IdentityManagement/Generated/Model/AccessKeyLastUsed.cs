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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about the last time an AWS access key was used.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a>GetAccessKeyLastUsed</a> operation.
    /// </para>
    /// </summary>
    public partial class AccessKeyLastUsed
    {
        private DateTime? _lastUsedDate;
        private string _region;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property LastUsedDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the access key was most recently used. This field is null in the
        /// following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user does not have an access key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An access key exists but has never been used, at least not since IAM started tracking
        /// this information on April 22nd, 2015.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is no sign-in data associated with the user
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime LastUsedDate
        {
            get { return this._lastUsedDate.GetValueOrDefault(); }
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
        /// The AWS region where this access key was most recently used. This field is displays
        /// "N/A" in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user does not have an access key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An access key exists but has never been used, at least not since IAM started tracking
        /// this information on April 22nd, 2015.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is no sign-in data associated with the user
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about AWS regions, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a> in the Amazon Web Services General Reference.
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
        /// The name of the AWS service with which this access key was most recently used. This
        /// field displays "N/A" in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user does not have an access key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An access key exists but has never been used, at least not since IAM started tracking
        /// this information on April 22nd, 2015.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is no sign-in data associated with the user
        /// </para>
        ///  </li> </ul>
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