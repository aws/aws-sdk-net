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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _elasticInferenceAcceleratorArn;
        private string _elasticInferenceAcceleratorAssociationId;
        private string _elasticInferenceAcceleratorAssociationState;
        private DateTime? _elasticInferenceAcceleratorAssociationTime;

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the elastic inference accelerator. 
        /// </para>
        /// </summary>
        public string ElasticInferenceAcceleratorArn
        {
            get { return this._elasticInferenceAcceleratorArn; }
            set { this._elasticInferenceAcceleratorArn = value; }
        }

        // Check to see if ElasticInferenceAcceleratorArn property is set
        internal bool IsSetElasticInferenceAcceleratorArn()
        {
            return this._elasticInferenceAcceleratorArn != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorAssociationId. 
        /// <para>
        ///  The ID of the association. 
        /// </para>
        /// </summary>
        public string ElasticInferenceAcceleratorAssociationId
        {
            get { return this._elasticInferenceAcceleratorAssociationId; }
            set { this._elasticInferenceAcceleratorAssociationId = value; }
        }

        // Check to see if ElasticInferenceAcceleratorAssociationId property is set
        internal bool IsSetElasticInferenceAcceleratorAssociationId()
        {
            return this._elasticInferenceAcceleratorAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorAssociationState. 
        /// <para>
        ///  The state of the elastic inference accelerator. 
        /// </para>
        /// </summary>
        public string ElasticInferenceAcceleratorAssociationState
        {
            get { return this._elasticInferenceAcceleratorAssociationState; }
            set { this._elasticInferenceAcceleratorAssociationState = value; }
        }

        // Check to see if ElasticInferenceAcceleratorAssociationState property is set
        internal bool IsSetElasticInferenceAcceleratorAssociationState()
        {
            return this._elasticInferenceAcceleratorAssociationState != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorAssociationTime. 
        /// <para>
        ///  The time at which the elastic inference accelerator is associated with an instance.
        /// 
        /// </para>
        /// </summary>
        public DateTime? ElasticInferenceAcceleratorAssociationTime
        {
            get { return this._elasticInferenceAcceleratorAssociationTime; }
            set { this._elasticInferenceAcceleratorAssociationTime = value; }
        }

        // Check to see if ElasticInferenceAcceleratorAssociationTime property is set
        internal bool IsSetElasticInferenceAcceleratorAssociationTime()
        {
            return this._elasticInferenceAcceleratorAssociationTime.HasValue; 
        }

    }
}