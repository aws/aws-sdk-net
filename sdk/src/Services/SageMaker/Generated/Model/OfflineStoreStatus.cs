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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The status of <c>OfflineStore</c>.
    /// </summary>
    public partial class OfflineStoreStatus
    {
        private string _blockedReason;
        private OfflineStoreStatusValue _status;

        /// <summary>
        /// Gets and sets the property BlockedReason. 
        /// <para>
        /// The justification for why the OfflineStoreStatus is Blocked (if applicable).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string BlockedReason
        {
            get { return this._blockedReason; }
            set { this._blockedReason = value; }
        }

        // Check to see if BlockedReason property is set
        internal bool IsSetBlockedReason()
        {
            return this._blockedReason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An <c>OfflineStore</c> status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OfflineStoreStatusValue Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}