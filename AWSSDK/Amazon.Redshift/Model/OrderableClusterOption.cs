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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes an orderable cluster option.
    /// </summary>
    public partial class OrderableClusterOption
    {
        private List<AvailabilityZone> _availabilityZones = new List<AvailabilityZone>();
        private string _clusterType;
        private string _clusterVersion;
        private string _nodeType;


        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///             A list of availability zones for the orderable cluster.         
        /// </para>
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZones property
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableClusterOption WithAvailabilityZones(params AvailabilityZone[] availabilityZones)
        {
            foreach (var element in availabilityZones)
            {
                this._availabilityZones.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AvailabilityZones property
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableClusterOption WithAvailabilityZones(IEnumerable<AvailabilityZone> availabilityZones)
        {
            foreach (var element in availabilityZones)
            {
                this._availabilityZones.Add(element);
            }
            return this;
        }
        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        ///             The cluster type, for example <code>multi-node</code>.        
        /// </para>
        /// </summary>
        public string ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }


        /// <summary>
        /// Sets the ClusterType property
        /// </summary>
        /// <param name="clusterType">The value to set for the ClusterType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableClusterOption WithClusterType(string clusterType)
        {
            this._clusterType = clusterType;
            return this;
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }


        /// <summary>
        /// Gets and sets the property ClusterVersion. 
        /// <para>
        ///             The version of the orderable cluster.        
        /// </para>
        /// </summary>
        public string ClusterVersion
        {
            get { return this._clusterVersion; }
            set { this._clusterVersion = value; }
        }


        /// <summary>
        /// Sets the ClusterVersion property
        /// </summary>
        /// <param name="clusterVersion">The value to set for the ClusterVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableClusterOption WithClusterVersion(string clusterVersion)
        {
            this._clusterVersion = clusterVersion;
            return this;
        }

        // Check to see if ClusterVersion property is set
        internal bool IsSetClusterVersion()
        {
            return this._clusterVersion != null;
        }


        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        ///             The node type for the orderable cluster.         
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }


        /// <summary>
        /// Sets the NodeType property
        /// </summary>
        /// <param name="nodeType">The value to set for the NodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableClusterOption WithNodeType(string nodeType)
        {
            this._nodeType = nodeType;
            return this;
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

    }
}