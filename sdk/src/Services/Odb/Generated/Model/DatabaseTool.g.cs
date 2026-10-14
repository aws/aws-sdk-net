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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about a database management tool for an Autonomous Database.
    /// </summary>
    public partial class DatabaseTool
    {
        /// <summary>
        /// Gets and sets the property ComputeCount. 
        /// <para>
        /// The compute capacity allocated to the database management tool.
        /// </para>
        /// </summary>
        public double? ComputeCount { get; set; }

        /// <summary>
        /// Checks to see if the ComputeCount property is set.
        /// </summary>
        internal bool IsSetComputeCount() => this.ComputeCount.HasValue;

        /// <summary>
        /// Gets and sets the property IsEnabled. 
        /// <para>
        /// Indicates whether the database management tool is enabled.
        /// </para>
        /// </summary>
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsEnabled property is set.
        /// </summary>
        internal bool IsSetIsEnabled() => this.IsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property MaxIdleTimeInMinutes. 
        /// <para>
        /// The maximum amount of time, in minutes, that the database management tool can be idle
        /// before it is shut down.
        /// </para>
        /// </summary>
        public int? MaxIdleTimeInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the MaxIdleTimeInMinutes property is set.
        /// </summary>
        internal bool IsSetMaxIdleTimeInMinutes() => this.MaxIdleTimeInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the database management tool.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
