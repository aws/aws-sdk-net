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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// MFA configuration and sycnronization status for an approver
    /// </summary>
    public partial class MfaMethod
    {
        private MfaSyncStatus _syncStatus;
        private MfaType _type;

        /// <summary>
        /// Gets and sets the property SyncStatus. 
        /// <para>
        /// Indicates if the approver's MFA device is in-sync with the Identity Source
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MfaSyncStatus SyncStatus
        {
            get { return this._syncStatus; }
            set { this._syncStatus = value; }
        }

        // Check to see if SyncStatus property is set
        internal bool IsSetSyncStatus()
        {
            return this._syncStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of MFA configuration used by the approver
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MfaType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}