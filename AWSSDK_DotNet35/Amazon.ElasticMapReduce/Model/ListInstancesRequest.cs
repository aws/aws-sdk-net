/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstances operation.
    /// <para>Provides information about the cluster instances that Amazon EMR provisions on behalf of a user when it creates the cluster. For
    /// example, this operation indicates when the EC2 instances reach the Ready state, when instances become available to Amazon EMR to use for
    /// jobs, and the IP addresses for cluster instances, etc. </para>
    /// </summary>
    public partial class ListInstancesRequest : AmazonElasticMapReduceRequest
    {
        private string clusterId;
        private string instanceGroupId;
        private List<string> instanceGroupTypes = new List<string>();
        private string marker;


        /// <summary>
        /// The identifier of the cluster for which to list the instances.
        ///  
        /// </summary>
        public string ClusterId
        {
            get { return this.clusterId; }
            set { this.clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this.clusterId != null;
        }

        /// <summary>
        /// The identifier of the instance group for which to list the instances.
        ///  
        /// </summary>
        public string InstanceGroupId
        {
            get { return this.instanceGroupId; }
            set { this.instanceGroupId = value; }
        }

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this.instanceGroupId != null;
        }

        /// <summary>
        /// The type of instance group for which to list the instances.
        ///  
        /// </summary>
        public List<string> InstanceGroupTypes
        {
            get { return this.instanceGroupTypes; }
            set { this.instanceGroupTypes = value; }
        }

        // Check to see if InstanceGroupTypes property is set
        internal bool IsSetInstanceGroupTypes()
        {
            return this.instanceGroupTypes.Count > 0;
        }

        /// <summary>
        /// The pagination token is a random string indicating whether there are more results to fetch. Provide the pagination token from earlier API
        /// calls to retrieve the next page of results. When the value is null, all results have been returned.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

    }
}
    
