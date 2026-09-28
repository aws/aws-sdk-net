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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Configuration information about the compute workers that perform the transform job.
    /// </summary>
    public partial class WorkerComputeConfiguration
    {
        /// <summary>
        /// Gets and sets the property Number. 
        /// <para>
        /// The number of compute workers that are used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 1024)]
        public int? Number { get; set; }

        /// <summary>
        /// Checks to see if the Number property is set.
        /// </summary>
        internal bool IsSetNumber() => this.Number.HasValue;

        /// <summary>
        /// Gets and sets the property Properties.
        /// </summary>
        public WorkerComputeConfigurationProperties Properties { get; set; }

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The instance type of the compute workers that are used.
        /// </para>
        /// </summary>
        public WorkerComputeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
