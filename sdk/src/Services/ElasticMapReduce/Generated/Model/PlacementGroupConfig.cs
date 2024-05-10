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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Placement group configuration for an Amazon EMR cluster. The configuration specifies
    /// the placement strategy that can be applied to instance roles during cluster creation.
    /// 
    ///  
    /// <para>
    /// To use this configuration, consider attaching managed policy AmazonElasticMapReducePlacementGroupPolicy
    /// to the Amazon EMR role.
    /// </para>
    /// </summary>
    public partial class PlacementGroupConfig
    {
        private InstanceRoleType _instanceRole;
        private PlacementGroupStrategy _placementStrategy;

        /// <summary>
        /// Gets and sets the property InstanceRole. 
        /// <para>
        /// Role of the instance in the cluster.
        /// </para>
        ///  
        /// <para>
        /// Starting with Amazon EMR release 5.23.0, the only supported instance role is <c>MASTER</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceRoleType InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this._instanceRole != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementStrategy. 
        /// <para>
        /// Amazon EC2 Placement Group strategy associated with instance role.
        /// </para>
        ///  
        /// <para>
        /// Starting with Amazon EMR release 5.23.0, the only supported placement strategy is
        /// <c>SPREAD</c> for the <c>MASTER</c> instance role.
        /// </para>
        /// </summary>
        public PlacementGroupStrategy PlacementStrategy
        {
            get { return this._placementStrategy; }
            set { this._placementStrategy = value; }
        }

        // Check to see if PlacementStrategy property is set
        internal bool IsSetPlacementStrategy()
        {
            return this._placementStrategy != null;
        }

    }
}