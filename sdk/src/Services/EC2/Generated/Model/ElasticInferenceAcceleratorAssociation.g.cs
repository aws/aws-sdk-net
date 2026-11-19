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
    /// Amazon Elastic Inference is no longer available.
    /// </para>
    ///  </note> 
    /// <para>
    ///  Describes the association between an instance and an elastic inference accelerator.
    /// 
    /// </para>
    /// </summary>
    public partial class ElasticInferenceAcceleratorAssociation
    {
        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the elastic inference accelerator. 
        /// </para>
        /// </summary>
        public string ElasticInferenceAcceleratorArn { get; set; }

        /// <summary>
        /// Checks to see if the ElasticInferenceAcceleratorArn property is set.
        /// </summary>
        internal bool IsSetElasticInferenceAcceleratorArn() => this.ElasticInferenceAcceleratorArn != null;

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorAssociationId. 
        /// <para>
        ///  The ID of the association. 
        /// </para>
        /// </summary>
        public string ElasticInferenceAcceleratorAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ElasticInferenceAcceleratorAssociationId property is set.
        /// </summary>
        internal bool IsSetElasticInferenceAcceleratorAssociationId() => this.ElasticInferenceAcceleratorAssociationId != null;

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorAssociationState. 
        /// <para>
        ///  The state of the elastic inference accelerator. 
        /// </para>
        /// </summary>
        public string ElasticInferenceAcceleratorAssociationState { get; set; }

        /// <summary>
        /// Checks to see if the ElasticInferenceAcceleratorAssociationState property is set.
        /// </summary>
        internal bool IsSetElasticInferenceAcceleratorAssociationState() => this.ElasticInferenceAcceleratorAssociationState != null;

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorAssociationTime. 
        /// <para>
        ///  The time at which the elastic inference accelerator is associated with an instance.
        /// 
        /// </para>
        /// </summary>
        public DateTime? ElasticInferenceAcceleratorAssociationTime { get; set; }

        /// <summary>
        /// Checks to see if the ElasticInferenceAcceleratorAssociationTime property is set.
        /// </summary>
        internal bool IsSetElasticInferenceAcceleratorAssociationTime() => this.ElasticInferenceAcceleratorAssociationTime.HasValue;
    }
}
