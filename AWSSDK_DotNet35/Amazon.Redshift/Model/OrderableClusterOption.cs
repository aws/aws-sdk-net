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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Describes an orderable cluster option. </para>
    /// </summary>
    public class OrderableClusterOption
    {
        
        private string clusterVersion;
        private string clusterType;
        private string nodeType;
        private List<AvailabilityZone> availabilityZones = new List<AvailabilityZone>();


        /// <summary>
        /// The version of the orderable cluster.
        ///  
        /// </summary>
        public string ClusterVersion
        {
            get { return this.clusterVersion; }
            set { this.clusterVersion = value; }
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this.clusterVersion != null;
        }

        /// <summary>
        /// The cluster type, for example <c>multi-node</c>.
        ///  
        /// </summary>
        public string ClusterType
        {
            get { return this.clusterType; }
            set { this.clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this.clusterType != null;
        }

        /// <summary>
        /// The node type for the orderable cluster.
        ///  
        /// </summary>
        public string NodeType
        {
            get { return this.nodeType; }
            set { this.nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this.nodeType != null;
        }

        /// <summary>
        /// A list of availability zones for the orderable cluster.
        ///  
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this.availabilityZones; }
            set { this.availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this.availabilityZones.Count > 0;
        }
    }
}
