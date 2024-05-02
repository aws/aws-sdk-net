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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about Amazon ECS cluster runtime coverage details.
    /// </summary>
    public partial class CoverageEcsClusterDetails
    {
        private string _clusterName;
        private ContainerInstanceDetails _containerInstanceDetails;
        private FargateDetails _fargateDetails;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon ECS cluster.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerInstanceDetails. 
        /// <para>
        /// Information about the Amazon ECS container running on Amazon EC2 instance.
        /// </para>
        /// </summary>
        public ContainerInstanceDetails ContainerInstanceDetails
        {
            get { return this._containerInstanceDetails; }
            set { this._containerInstanceDetails = value; }
        }

        // Check to see if ContainerInstanceDetails property is set
        internal bool IsSetContainerInstanceDetails()
        {
            return this._containerInstanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property FargateDetails. 
        /// <para>
        /// Information about the Fargate details associated with the Amazon ECS cluster.
        /// </para>
        /// </summary>
        public FargateDetails FargateDetails
        {
            get { return this._fargateDetails; }
            set { this._fargateDetails = value; }
        }

        // Check to see if FargateDetails property is set
        internal bool IsSetFargateDetails()
        {
            return this._fargateDetails != null;
        }

    }
}