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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains details for Aurora Limitless Database.
    /// </summary>
    public partial class LimitlessDatabase
    {
        private double? _minRequiredACU;
        private LimitlessDatabaseStatus _status;

        /// <summary>
        /// Gets and sets the property MinRequiredACU. 
        /// <para>
        /// The minimum required capacity for Aurora Limitless Database in Aurora capacity units
        /// (ACUs).
        /// </para>
        /// </summary>
        public double? MinRequiredACU
        {
            get { return this._minRequiredACU; }
            set { this._minRequiredACU = value; }
        }

        // Check to see if MinRequiredACU property is set
        internal bool IsSetMinRequiredACU()
        {
            return this._minRequiredACU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of Aurora Limitless Database.
        /// </para>
        /// </summary>
        public LimitlessDatabaseStatus Status
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