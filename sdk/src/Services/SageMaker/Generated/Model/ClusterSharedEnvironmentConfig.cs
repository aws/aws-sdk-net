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
    /// The shared environment configuration for the restricted instance groups (RIG).
    /// </summary>
    public partial class ClusterSharedEnvironmentConfig
    {
        private FSxLustreConfig _fSxLustreConfig;
        private ClusterFSxLustreDeletionPolicy _fSxLustreDeletionPolicy;

        /// <summary>
        /// Gets and sets the property FSxLustreConfig. 
        /// <para>
        /// Configuration settings for an Amazon FSx for Lustre file system in the shared environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FSxLustreConfig FSxLustreConfig
        {
            get { return this._fSxLustreConfig; }
            set { this._fSxLustreConfig = value; }
        }

        // Check to see if FSxLustreConfig property is set
        internal bool IsSetFSxLustreConfig()
        {
            return this._fSxLustreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property FSxLustreDeletionPolicy. 
        /// <para>
        /// The deletion policy for the Amazon FSx for Lustre file system in the shared environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterFSxLustreDeletionPolicy FSxLustreDeletionPolicy
        {
            get { return this._fSxLustreDeletionPolicy; }
            set { this._fSxLustreDeletionPolicy = value; }
        }

        // Check to see if FSxLustreDeletionPolicy property is set
        internal bool IsSetFSxLustreDeletionPolicy()
        {
            return this._fSxLustreDeletionPolicy != null;
        }

    }
}