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
    /// This output contains the description of the cluster.
    /// </summary>
    public partial class DescribeClusterResult
    {
        private Cluster _cluster;


        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// This output contains the details for the requested cluster.
        /// </para>
        /// </summary>
        public Cluster Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }


        /// <summary>
        /// Sets the Cluster property
        /// </summary>
        /// <param name="cluster">The value to set for the Cluster property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeClusterResult WithCluster(Cluster cluster)
        {
            this._cluster = cluster;
            return this;
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

    }
}