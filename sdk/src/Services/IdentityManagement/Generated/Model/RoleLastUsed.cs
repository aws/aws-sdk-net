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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about the last time that an IAM role was used. This includes
    /// the date and time and the Region in which the role was last used. Activity is only
    /// reported for the trailing 400 days. This period can be shorter if your Region began
    /// supporting these features within the last year. The role might have been used more
    /// than 400 days ago. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
    /// where data is tracked</a> in the <i>IAM user Guide</i>.
    /// 
    ///  
    /// <para>
    /// This data type is returned as a response element in the <a>GetRole</a> and <a>GetAccountAuthorizationDetails</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class RoleLastUsed
    {
        private DateTime? _lastUsedDate;
        private string _region;

        /// <summary>
        /// Gets and sets the property LastUsedDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a> that the role was last used.
        /// </para>
        ///  
        /// <para>
        /// This field is null if the role has not been used within the IAM tracking period. For
        /// more information about the tracking period, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
        /// where data is tracked</a> in the <i>IAM User Guide</i>. 
        /// </para>
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
        /// The name of the Amazon Web Services Region in which the role was last used.
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

    }
}