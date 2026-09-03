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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Information about scheduled execution timestamps.
    /// </summary>
    public partial class ScheduledExecutions
    {
        private DateTime? _lastExecutedAt;
        private DateTime? _nextExecutedAt;

        /// <summary>
        /// Gets and sets the property LastExecutedAt. 
        /// <para>
        /// The timestamp of the last successful scheduled execution. 
        /// </para>
        /// </summary>
        public DateTime? LastExecutedAt
        {
            get { return this._lastExecutedAt; }
            set { this._lastExecutedAt = value; }
        }

        // Check to see if LastExecutedAt property is set
        internal bool IsSetLastExecutedAt()
        {
            return this._lastExecutedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextExecutedAt. 
        /// <para>
        /// The timestamp of the next scheduled execution. 
        /// </para>
        /// </summary>
        public DateTime? NextExecutedAt
        {
            get { return this._nextExecutedAt; }
            set { this._nextExecutedAt = value; }
        }

        // Check to see if NextExecutedAt property is set
        internal bool IsSetNextExecutedAt()
        {
            return this._nextExecutedAt.HasValue; 
        }

    }
}