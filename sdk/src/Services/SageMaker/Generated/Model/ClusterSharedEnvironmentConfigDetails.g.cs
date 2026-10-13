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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The shared environment configuration details for the restricted instance groups (RIG).
    /// </summary>
    public partial class ClusterSharedEnvironmentConfigDetails
    {
        /// <summary>
        /// Gets and sets the property CurrentFSxLustreConfig. 
        /// <para>
        /// The current Amazon FSx for Lustre file system configuration in the shared environment.
        /// </para>
        /// </summary>
        public FSxLustreConfig CurrentFSxLustreConfig { get; set; }

        /// <summary>
        /// Checks to see if the CurrentFSxLustreConfig property is set.
        /// </summary>
        internal bool IsSetCurrentFSxLustreConfig() => this.CurrentFSxLustreConfig != null;

        /// <summary>
        /// Gets and sets the property CurrentFSxLustreDeletionPolicy. 
        /// <para>
        /// The current deletion policy for the Amazon FSx for Lustre file system in the shared
        /// environment.
        /// </para>
        /// </summary>
        public ClusterFSxLustreDeletionPolicy CurrentFSxLustreDeletionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the CurrentFSxLustreDeletionPolicy property is set.
        /// </summary>
        internal bool IsSetCurrentFSxLustreDeletionPolicy() => this.CurrentFSxLustreDeletionPolicy != null;

        /// <summary>
        /// Gets and sets the property DesiredFSxLustreConfig. 
        /// <para>
        /// The desired Amazon FSx for Lustre file system configuration in the shared environment.
        /// </para>
        /// </summary>
        public FSxLustreConfig DesiredFSxLustreConfig { get; set; }

        /// <summary>
        /// Checks to see if the DesiredFSxLustreConfig property is set.
        /// </summary>
        internal bool IsSetDesiredFSxLustreConfig() => this.DesiredFSxLustreConfig != null;

        /// <summary>
        /// Gets and sets the property DesiredFSxLustreDeletionPolicy. 
        /// <para>
        /// The desired deletion policy for the Amazon FSx for Lustre file system in the shared
        /// environment.
        /// </para>
        /// </summary>
        public ClusterFSxLustreDeletionPolicy DesiredFSxLustreDeletionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DesiredFSxLustreDeletionPolicy property is set.
        /// </summary>
        internal bool IsSetDesiredFSxLustreDeletionPolicy() => this.DesiredFSxLustreDeletionPolicy != null;
    }
}
