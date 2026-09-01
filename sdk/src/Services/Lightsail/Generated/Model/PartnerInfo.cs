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
    /// An object that contains information about the Lightsail partner program membership
    /// of an Amazon Lightsail account.
    /// </summary>
    public partial class PartnerInfo
    {
        private DateTime? _enrolledAt;
        private PartnerStatus _status;
        private TierName _tierName;

        /// <summary>
        /// Gets and sets the property EnrolledAt. 
        /// <para>
        /// The timestamp when the account was enrolled in the Lightsail partner program.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EnrolledAt
        {
            get { return this._enrolledAt; }
            set { this._enrolledAt = value; }
        }

        // Check to see if EnrolledAt property is set
        internal bool IsSetEnrolledAt()
        {
            return this._enrolledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the partner membership.
        /// </para>
        ///  
        /// <para>
        /// The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Active</c> – The membership is active, and the benefits of the current tier are
        /// available to the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Suspended</c> – The membership is suspended, and the benefits of the tier are
        /// not available to the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PartnerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TierName. 
        /// <para>
        /// The tier of the partner membership.
        /// </para>
        /// </summary>
        public TierName TierName
        {
            get { return this._tierName; }
            set { this._tierName = value; }
        }

        // Check to see if TierName property is set
        internal bool IsSetTierName()
        {
            return this._tierName != null;
        }

    }
}