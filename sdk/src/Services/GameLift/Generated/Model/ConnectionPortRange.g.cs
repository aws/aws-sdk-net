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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// The set of port numbers to open on each instance in a container fleet. Connection
    /// ports are used by inbound traffic to connect with processes that are running in containers
    /// on the fleet.
    /// 
    ///  
    /// <para>
    /// The port range must not overlap with the Amazon GameLift Servers reserved port range
    /// <c>4092-4191</c>. This range is reserved for internal Amazon GameLift Servers services.
    /// </para>
    /// </summary>
    public partial class ConnectionPortRange
    {
        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// Starting value for the port range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 60000)]
        public int? FromPort { get; set; }

        /// <summary>
        /// Checks to see if the FromPort property is set.
        /// </summary>
        internal bool IsSetFromPort() => this.FromPort.HasValue;

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// Ending value for the port. Port numbers are end-inclusive. This value must be equal
        /// to or greater than <c>FromPort</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 60000)]
        public int? ToPort { get; set; }

        /// <summary>
        /// Checks to see if the ToPort property is set.
        /// </summary>
        internal bool IsSetToPort() => this.ToPort.HasValue;
    }
}
