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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private List<string> _include = new List<string>();

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        /// A list of up to 100 cluster names or full cluster Amazon Resource Name (ARN) entries.
        /// If you do not specify a cluster, the default cluster is assumed.
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

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Determines whether to include additional information about the clusters in the response.
        /// If this field is omitted, this information isn't included.
        /// </para>
        ///  
        /// <para>
        /// If <code>ATTACHMENTS</code> is specified, the attachments for the container instances
        /// or tasks within the cluster are included, for example the capacity providers.
        /// </para>
        ///  
        /// <para>
        /// If <code>SETTINGS</code> is specified, the settings for the cluster are included.
        /// </para>
        ///  
        /// <para>
        /// If <code>CONFIGURATIONS</code> is specified, the configuration for the cluster is
        /// included.
        /// </para>
        ///  
        /// <para>
        /// If <code>STATISTICS</code> is specified, the task and service count is included, separated
        /// by launch type.
        /// </para>
        ///  
        /// <para>
        /// If <code>TAGS</code> is specified, the metadata tags associated with the cluster are
        /// included.
        /// </para>
        /// </summary>
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && this._include.Count > 0; 
        }

    }
}