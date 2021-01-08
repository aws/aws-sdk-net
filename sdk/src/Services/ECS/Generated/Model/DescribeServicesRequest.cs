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
    /// Container for the parameters to the DescribeServices operation.
    /// Describes the specified services running in your cluster.
    /// </summary>
    public partial class DescribeServicesRequest : AmazonECSRequest
    {
        private string _cluster;
        private List<string> _include = new List<string>();
        private List<string> _services = new List<string>();

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN)the cluster that hosts the service
        /// to describe. If you do not specify a cluster, the default cluster is assumed. This
        /// parameter is required if the service or services you are describing were launched
        /// in any cluster other than the default cluster.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// Specifies whether you want to see the resource tags for the service. If <code>TAGS</code>
        /// is specified, the tags are included in the response. If this field is omitted, tags
        /// are not included in the response.
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

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// A list of services to describe. You may specify up to 10 services to describe in a
        /// single operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && this._services.Count > 0; 
        }

    }
}