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
        
        private string clusterVersion;
        private string clusterParameterGroupFamily;
        private string description;

        /// <summary>
        /// The version number used by the cluster.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.clusterVersion; }
            set { this.clusterVersion = value; }
        }
        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public ClusterVersion WithName(string name)
        {
            this.clusterVersion = name;
            return this;
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.clusterVersion != null;
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

        /// <summary>
        /// Sets the ClusterParameterGroupFamily property
        /// </summary>
        /// <param name="clusterParameterGroupFamily">The value to set for the ClusterParameterGroupFamily property </param>
        /// <returns>this instance</returns>
        public ClusterVersion WithClusterParameterGroupFamily(string clusterParameterGroupFamily)
        {
            this.clusterParameterGroupFamily = clusterParameterGroupFamily;
            return this;
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

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public ClusterVersion WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
    }
}
