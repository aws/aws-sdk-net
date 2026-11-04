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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Provides a list of status information for a DB instance.
    /// </summary>
    public partial class DBInstanceStatusInfo
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Details of the error if there is an error for the instance. If the instance isn't
        /// in an error state, this value is blank.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Normal. 
        /// <para>
        /// Indicates whether the instance is operating normally (TRUE) or is in an error state
        /// (FALSE).
        /// </para>
        /// </summary>
        public bool? Normal { get; set; }

        /// <summary>
        /// Checks to see if the Normal property is set.
        /// </summary>
        internal bool IsSetNormal() => this.Normal.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB instance. For a StatusType of read replica, the values can be
        /// replicating, replication stop point set, replication stop point reached, error, stopped,
        /// or terminated.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusType. 
        /// <para>
        /// This value is currently "read replication."
        /// </para>
        /// </summary>
        public string StatusType { get; set; }

        /// <summary>
        /// Checks to see if the StatusType property is set.
        /// </summary>
        internal bool IsSetStatusType() => this.StatusType != null;
    }
}
