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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains statistics about the execution of the protected job.
    /// </summary>
    public partial class ProtectedJobStatistics
    {
        private BilledJobResourceUtilization _billedResourceUtilization;
        private long? _totalDurationInMillis;

        /// <summary>
        /// Gets and sets the property BilledResourceUtilization. 
        /// <para>
        ///  The billed resource utilization for the protected job.
        /// </para>
        /// </summary>
        public BilledJobResourceUtilization BilledResourceUtilization
        {
            get { return this._billedResourceUtilization; }
            set { this._billedResourceUtilization = value; }
        }

        // Check to see if BilledResourceUtilization property is set
        internal bool IsSetBilledResourceUtilization()
        {
            return this._billedResourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property TotalDurationInMillis. 
        /// <para>
        /// The duration of the protected job, from creation until job completion, in milliseconds.
        /// </para>
        /// </summary>
        public long? TotalDurationInMillis
        {
            get { return this._totalDurationInMillis; }
            set { this._totalDurationInMillis = value; }
        }

        // Check to see if TotalDurationInMillis property is set
        internal bool IsSetTotalDurationInMillis()
        {
            return this._totalDurationInMillis.HasValue; 
        }

    }
}