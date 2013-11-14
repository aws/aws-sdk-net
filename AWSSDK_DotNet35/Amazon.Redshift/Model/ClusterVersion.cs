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
    /// <para>Describes a cluster version, including the parameter group family and description of the version.</para>
    /// </summary>
    public class ClusterVersion
    {
        
        private string version;
        private string clusterParameterGroupFamily;
        private string description;


        /// <summary>
        /// The version number used by the cluster.
        ///  
        /// </summary>
        public string Version
        {
            get { return this.version; }
            set { this.version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this.version != null;
        }

        /// <summary>
        /// The name of the cluster parameter group family for the cluster.
        ///  
        /// </summary>
        public string ClusterParameterGroupFamily
        {
            get { return this.clusterParameterGroupFamily; }
            set { this.clusterParameterGroupFamily = value; }
        }

        // Check to see if ClusterParameterGroupFamily property is set
        internal bool IsSetClusterParameterGroupFamily()
        {
            return this.clusterParameterGroupFamily != null;
        }

        /// <summary>
        /// The description of the cluster version.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
