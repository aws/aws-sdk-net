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
    /// Contains information about the Amazon EC2 instance that is running the Amazon ECS
    /// container.
    /// </summary>
    public partial class ContainerInstanceDetails
    {
        private long? _compatibleContainerInstances;
        private long? _coveredContainerInstances;

        /// <summary>
        /// Gets and sets the property CompatibleContainerInstances. 
        /// <para>
        /// Represents total number of nodes in the Amazon ECS cluster.
        /// </para>
        /// </summary>
        public long? CompatibleContainerInstances
        {
            get { return this._compatibleContainerInstances; }
            set { this._compatibleContainerInstances = value; }
        }

        // Check to see if CompatibleContainerInstances property is set
        internal bool IsSetCompatibleContainerInstances()
        {
            return this._compatibleContainerInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CoveredContainerInstances. 
        /// <para>
        /// Represents the nodes in the Amazon ECS cluster that has a <c>HEALTHY</c> coverage
        /// status.
        /// </para>
        /// </summary>
        public long? CoveredContainerInstances
        {
            get { return this._coveredContainerInstances; }
            set { this._coveredContainerInstances = value; }
        }

        // Check to see if CoveredContainerInstances property is set
        internal bool IsSetCoveredContainerInstances()
        {
            return this._coveredContainerInstances.HasValue; 
        }

    }
}