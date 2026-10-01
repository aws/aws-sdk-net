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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the status of a read replica.
    /// </summary>
    public partial class AwsRdsDbStatusInfo
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If the read replica is currently in an error state, provides the error details.
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
        /// Whether the read replica instance is operating normally.
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
        /// The status of the read replica instance.
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
        /// The type of status. For a read replica, the status type is read replication.
        /// </para>
        /// </summary>
        public string StatusType { get; set; }

        /// <summary>
        /// Checks to see if the StatusType property is set.
        /// </summary>
        internal bool IsSetStatusType() => this.StatusType != null;
    }
}
