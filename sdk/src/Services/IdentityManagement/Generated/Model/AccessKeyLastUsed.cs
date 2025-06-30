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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about the last time an Amazon Web Services access key was used
    /// since IAM began tracking this information on April 22, 2015.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccessKeyLastUsed.html">GetAccessKeyLastUsed</a>
    /// operation.
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
        /// An access key exists but has not been used since IAM began tracking this information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is no sign-in data associated with the user.
        /// </para>
        ///  </li> </ul>
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
        /// The Amazon Web Services Region where this access key was most recently used. The value
        /// for this field is "N/A" in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user does not have an access key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An access key exists but has not been used since IAM began tracking this information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is no sign-in data associated with the user.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about Amazon Web Services Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and endpoints</a> in the Amazon Web Services General Reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// used. The value of this field is "N/A" in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The user does not have an access key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An access key exists but has not been used since IAM started tracking this information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is no sign-in data associated with the user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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