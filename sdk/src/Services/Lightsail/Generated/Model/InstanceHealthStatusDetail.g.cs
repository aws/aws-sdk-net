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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the instance status.
    /// </summary>
    public partial class InstanceHealthStatusDetail
    {
        /// <summary>
        /// Gets and sets the property ImpairedSince. 
        /// <para>
        /// The time when a status check failed. For an instance that was launched and impaired,
        /// this is the time when the instance was launched.
        /// </para>
        /// </summary>
        public DateTime? ImpairedSince { get; set; }

        /// <summary>
        /// Checks to see if the ImpairedSince property is set.
        /// </summary>
        internal bool IsSetImpairedSince() => this.ImpairedSince.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The type of instance status. The only possible value is <c>reachability</c>.
        /// </para>
        /// </summary>
        public InstanceHealthStatusDetailName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        ///  
        /// <para>
        /// The following values are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>passed</c> - The check passed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> - The check failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>initializing</c> - The check is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>insufficient-data</c> - There isn't enough data yet to determine the result.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceHealthStatusDetailValue Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
