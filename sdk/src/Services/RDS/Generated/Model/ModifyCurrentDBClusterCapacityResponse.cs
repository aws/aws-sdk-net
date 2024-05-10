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
    /// This is the response object from the ModifyCurrentDBClusterCapacity operation.
    /// </summary>
    public partial class ModifyCurrentDBClusterCapacityResponse : AmazonWebServiceResponse
    {
        private int? _currentCapacity;
        private string _dbClusterIdentifier;
        private int? _pendingCapacity;
        private int? _secondsBeforeTimeout;
        private string _timeoutAction;

        /// <summary>
        /// Gets and sets the property CurrentCapacity. 
        /// <para>
        /// The current capacity of the DB cluster.
        /// </para>
        /// </summary>
        public int? CurrentCapacity
        {
            get { return this._currentCapacity; }
            set { this._currentCapacity = value; }
        }

        // Check to see if CurrentCapacity property is set
        internal bool IsSetCurrentCapacity()
        {
            return this._currentCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// A user-supplied DB cluster identifier. This identifier is the unique key that identifies
        /// a DB cluster.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property PendingCapacity. 
        /// <para>
        /// A value that specifies the capacity that the DB cluster scales to next.
        /// </para>
        /// </summary>
        public int? PendingCapacity
        {
            get { return this._pendingCapacity; }
            set { this._pendingCapacity = value; }
        }

        // Check to see if PendingCapacity property is set
        internal bool IsSetPendingCapacity()
        {
            return this._pendingCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecondsBeforeTimeout. 
        /// <para>
        /// The number of seconds before a call to <c>ModifyCurrentDBClusterCapacity</c> times
        /// out.
        /// </para>
        /// </summary>
        public int? SecondsBeforeTimeout
        {
            get { return this._secondsBeforeTimeout; }
            set { this._secondsBeforeTimeout = value; }
        }

        // Check to see if SecondsBeforeTimeout property is set
        internal bool IsSetSecondsBeforeTimeout()
        {
            return this._secondsBeforeTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutAction. 
        /// <para>
        /// The timeout action of a call to <c>ModifyCurrentDBClusterCapacity</c>, either <c>ForceApplyCapacityChange</c>
        /// or <c>RollbackCapacityChange</c>.
        /// </para>
        /// </summary>
        public string TimeoutAction
        {
            get { return this._timeoutAction; }
            set { this._timeoutAction = value; }
        }

        // Check to see if TimeoutAction property is set
        internal bool IsSetTimeoutAction()
        {
            return this._timeoutAction != null;
        }

    }
}