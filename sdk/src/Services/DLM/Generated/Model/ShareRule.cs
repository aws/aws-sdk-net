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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Specifies a rule for sharing snapshots across AWS accounts.
    /// </summary>
    public partial class ShareRule
    {
        private List<string> _targetAccounts = new List<string>();
        private int? _unshareInterval;
        private RetentionIntervalUnitValues _unshareIntervalUnit;

        /// <summary>
        /// Gets and sets the property TargetAccounts. 
        /// <para>
        /// The IDs of the AWS accounts with which to share the snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> TargetAccounts
        {
            get { return this._targetAccounts; }
            set { this._targetAccounts = value; }
        }

        // Check to see if TargetAccounts property is set
        internal bool IsSetTargetAccounts()
        {
            return this._targetAccounts != null && this._targetAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnshareInterval. 
        /// <para>
        /// The period after which snapshots that are shared with other AWS accounts are automatically
        /// unshared.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int UnshareInterval
        {
            get { return this._unshareInterval.GetValueOrDefault(); }
            set { this._unshareInterval = value; }
        }

        // Check to see if UnshareInterval property is set
        internal bool IsSetUnshareInterval()
        {
            return this._unshareInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnshareIntervalUnit. 
        /// <para>
        /// The unit of time for the automatic unsharing interval.
        /// </para>
        /// </summary>
        public RetentionIntervalUnitValues UnshareIntervalUnit
        {
            get { return this._unshareIntervalUnit; }
            set { this._unshareIntervalUnit = value; }
        }

        // Check to see if UnshareIntervalUnit property is set
        internal bool IsSetUnshareIntervalUnit()
        {
            return this._unshareIntervalUnit != null;
        }

    }
}