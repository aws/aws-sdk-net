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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// An object that contains information about the estimated monthly cost to analyze an
    /// Amazon Web Services resource. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/cost-estimate.html">Estimate
    /// your Amazon DevOps Guru costs</a> and <a href="http://aws.amazon.com/devops-guru/pricing/">Amazon
    /// DevOps Guru pricing</a>.
    /// </summary>
    public partial class ServiceResourceCost
    {
        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// The total estimated monthly cost to analyze the active resources for this resource.
        /// </para>
        /// </summary>
        public double? Cost { get; set; }

        /// <summary>
        /// Checks to see if the Cost property is set.
        /// </summary>
        internal bool IsSetCost() => this.Cost.HasValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of active resources analyzed for this service to create a monthly cost
        /// estimate.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the resource. The resource is <c>ACTIVE</c> if it produces metrics, events,
        /// or logs within an hour, otherwise it is <c>INACTIVE</c>. You pay for the number of
        /// active Amazon Web Services resource hours analyzed for each resource. Inactive resources
        /// are not charged. 
        /// </para>
        /// </summary>
        public CostEstimationServiceResourceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UnitCost. 
        /// <para>
        /// The price per hour to analyze the resources in the service. For more information,
        /// see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/cost-estimate.html">Estimate
        /// your Amazon DevOps Guru costs</a> and <a href="http://aws.amazon.com/devops-guru/pricing/">Amazon
        /// DevOps Guru pricing</a>.
        /// </para>
        /// </summary>
        public double? UnitCost { get; set; }

        /// <summary>
        /// Checks to see if the UnitCost property is set.
        /// </summary>
        internal bool IsSetUnitCost() => this.UnitCost.HasValue;
    }
}
