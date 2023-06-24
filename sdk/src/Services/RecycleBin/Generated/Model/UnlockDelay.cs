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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RecycleBin.Model
{
    /// <summary>
    /// Information about the retention rule unlock delay. The unlock delay is the period
    /// after which a retention rule can be modified or edited after it has been unlocked
    /// by a user with the required permissions. The retention rule can't be modified or deleted
    /// during the unlock delay.
    /// </summary>
    public partial class UnlockDelay
    {
        private UnlockDelayUnit _unlockDelayUnit;
        private int? _unlockDelayValue;

        /// <summary>
        /// Gets and sets the property UnlockDelayUnit. 
        /// <para>
        /// The unit of time in which to measure the unlock delay. Currently, the unlock delay
        /// can be measure only in days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UnlockDelayUnit UnlockDelayUnit
        {
            get { return this._unlockDelayUnit; }
            set { this._unlockDelayUnit = value; }
        }

        // Check to see if UnlockDelayUnit property is set
        internal bool IsSetUnlockDelayUnit()
        {
            return this._unlockDelayUnit != null;
        }

        /// <summary>
        /// Gets and sets the property UnlockDelayValue. 
        /// <para>
        /// The unlock delay period, measured in the unit specified for <b> UnlockDelayUnit</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=30)]
        public int UnlockDelayValue
        {
            get { return this._unlockDelayValue.GetValueOrDefault(); }
            set { this._unlockDelayValue = value; }
        }

        // Check to see if UnlockDelayValue property is set
        internal bool IsSetUnlockDelayValue()
        {
            return this._unlockDelayValue.HasValue; 
        }

    }
}