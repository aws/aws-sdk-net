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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private FSxLustreConfig _currentFSxLustreConfig;
        private ClusterFSxLustreDeletionPolicy _currentFSxLustreDeletionPolicy;
        private FSxLustreConfig _desiredFSxLustreConfig;
        private ClusterFSxLustreDeletionPolicy _desiredFSxLustreDeletionPolicy;

        /// <summary>
        /// Gets and sets the property CurrentFSxLustreConfig. 
        /// <para>
        /// The current Amazon FSx for Lustre file system configuration in the shared environment.
        /// </para>
        /// </summary>
        public FSxLustreConfig CurrentFSxLustreConfig
        {
            get { return this._currentFSxLustreConfig; }
            set { this._currentFSxLustreConfig = value; }
        }

        // Check to see if CurrentFSxLustreConfig property is set
        internal bool IsSetCurrentFSxLustreConfig()
        {
            return this._currentFSxLustreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentFSxLustreDeletionPolicy. 
        /// <para>
        /// The current deletion policy for the Amazon FSx for Lustre file system in the shared
        /// environment.
        /// </para>
        /// </summary>
        public ClusterFSxLustreDeletionPolicy CurrentFSxLustreDeletionPolicy
        {
            get { return this._currentFSxLustreDeletionPolicy; }
            set { this._currentFSxLustreDeletionPolicy = value; }
        }

        // Check to see if CurrentFSxLustreDeletionPolicy property is set
        internal bool IsSetCurrentFSxLustreDeletionPolicy()
        {
            return this._currentFSxLustreDeletionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredFSxLustreConfig. 
        /// <para>
        /// The desired Amazon FSx for Lustre file system configuration in the shared environment.
        /// </para>
        /// </summary>
        public FSxLustreConfig DesiredFSxLustreConfig
        {
            get { return this._desiredFSxLustreConfig; }
            set { this._desiredFSxLustreConfig = value; }
        }

        // Check to see if DesiredFSxLustreConfig property is set
        internal bool IsSetDesiredFSxLustreConfig()
        {
            return this._desiredFSxLustreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DesiredFSxLustreDeletionPolicy. 
        /// <para>
        /// The desired deletion policy for the Amazon FSx for Lustre file system in the shared
        /// environment.
        /// </para>
        /// </summary>
        public ClusterFSxLustreDeletionPolicy DesiredFSxLustreDeletionPolicy
        {
            get { return this._desiredFSxLustreDeletionPolicy; }
            set { this._desiredFSxLustreDeletionPolicy = value; }
        }

        // Check to see if DesiredFSxLustreDeletionPolicy property is set
        internal bool IsSetDesiredFSxLustreDeletionPolicy()
        {
            return this._desiredFSxLustreDeletionPolicy != null;
        }

    }
}