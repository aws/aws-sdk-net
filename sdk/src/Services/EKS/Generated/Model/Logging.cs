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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing the logging configuration for resources in your cluster.
    /// </summary>
    public partial class Logging
    {
        private List<LogSetup> _clusterLogging = AWSConfigs.InitializeCollections ? new List<LogSetup>() : null;

        /// <summary>
        /// Gets and sets the property ClusterLogging. 
        /// <para>
        /// The cluster control plane logging configuration for your cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogSetup> ClusterLogging
        {
            get { return this._clusterLogging; }
            set { this._clusterLogging = value; }
        }

        // Check to see if ClusterLogging property is set
        internal bool IsSetClusterLogging()
        {
            return this._clusterLogging != null && (this._clusterLogging.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}