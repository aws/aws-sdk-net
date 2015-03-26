/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusters operation.
    /// Describes one or more of your clusters.
    /// </summary>
    public partial class DescribeClustersRequest : AmazonECSRequest
    {
        private List<string> _clusters = new List<string>();

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        /// A space-separated list of cluster names or full cluster Amazon Resource Name (ARN)
        /// entries. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public List<string> Clusters
        {
            get { return this._clusters; }
            set { this._clusters = value; }
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this._clusters != null && this._clusters.Count > 0; 
        }

    }
}