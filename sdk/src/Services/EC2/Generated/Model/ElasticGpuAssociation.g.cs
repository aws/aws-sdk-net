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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// Amazon Elastic Graphics reached end of life on January 8, 2024.
    /// </para>
    ///  </note> 
    /// <para>
    /// Describes the association between an instance and an Elastic Graphics accelerator.
    /// </para>
    /// </summary>
    public partial class ElasticGpuAssociation
    {
        /// <summary>
        /// Gets and sets the property ElasticGpuAssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string ElasticGpuAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ElasticGpuAssociationId property is set.
        /// </summary>
        internal bool IsSetElasticGpuAssociationId() => this.ElasticGpuAssociationId != null;

        /// <summary>
        /// Gets and sets the property ElasticGpuAssociationState. 
        /// <para>
        /// The state of the association between the instance and the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public string ElasticGpuAssociationState { get; set; }

        /// <summary>
        /// Checks to see if the ElasticGpuAssociationState property is set.
        /// </summary>
        internal bool IsSetElasticGpuAssociationState() => this.ElasticGpuAssociationState != null;

        /// <summary>
        /// Gets and sets the property ElasticGpuAssociationTime. 
        /// <para>
        /// The time the Elastic Graphics accelerator was associated with the instance.
        /// </para>
        /// </summary>
        public string ElasticGpuAssociationTime { get; set; }

        /// <summary>
        /// Checks to see if the ElasticGpuAssociationTime property is set.
        /// </summary>
        internal bool IsSetElasticGpuAssociationTime() => this.ElasticGpuAssociationTime != null;

        /// <summary>
        /// Gets and sets the property ElasticGpuId. 
        /// <para>
        /// The ID of the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public string ElasticGpuId { get; set; }

        /// <summary>
        /// Checks to see if the ElasticGpuId property is set.
        /// </summary>
        internal bool IsSetElasticGpuId() => this.ElasticGpuId != null;
    }
}
