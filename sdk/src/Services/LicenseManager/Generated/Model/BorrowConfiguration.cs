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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Details about a borrow configuration.
    /// </summary>
    public partial class BorrowConfiguration
    {
        private bool? _allowEarlyCheckIn;
        private int? _maxTimeToLiveInMinutes;

        /// <summary>
        /// Gets and sets the property AllowEarlyCheckIn. 
        /// <para>
        /// Indicates whether early check-ins are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AllowEarlyCheckIn
        {
            get { return this._allowEarlyCheckIn; }
            set { this._allowEarlyCheckIn = value; }
        }

        // Check to see if AllowEarlyCheckIn property is set
        internal bool IsSetAllowEarlyCheckIn()
        {
            return this._allowEarlyCheckIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxTimeToLiveInMinutes. 
        /// <para>
        /// Maximum time for the borrow configuration, in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxTimeToLiveInMinutes
        {
            get { return this._maxTimeToLiveInMinutes; }
            set { this._maxTimeToLiveInMinutes = value; }
        }

        // Check to see if MaxTimeToLiveInMinutes property is set
        internal bool IsSetMaxTimeToLiveInMinutes()
        {
            return this._maxTimeToLiveInMinutes.HasValue; 
        }

    }
}