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
    /// Amazon Elastic Graphics reached end of life on January 8, 2024.
    /// </para>
    ///  </note> 
    /// <para>
    /// Describes the association between an instance and an Elastic Graphics accelerator.
    /// </para>
    /// </summary>
    public partial class ElasticGpuAssociation
    {
        private string _elasticGpuAssociationId;
        private string _elasticGpuAssociationState;
        private string _elasticGpuAssociationTime;
        private string _elasticGpuId;

        /// <summary>
        /// Gets and sets the property ElasticGpuAssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string ElasticGpuAssociationId
        {
            get { return this._elasticGpuAssociationId; }
            set { this._elasticGpuAssociationId = value; }
        }

        // Check to see if ElasticGpuAssociationId property is set
        internal bool IsSetElasticGpuAssociationId()
        {
            return this._elasticGpuAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticGpuAssociationState. 
        /// <para>
        /// The state of the association between the instance and the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public string ElasticGpuAssociationState
        {
            get { return this._elasticGpuAssociationState; }
            set { this._elasticGpuAssociationState = value; }
        }

        // Check to see if ElasticGpuAssociationState property is set
        internal bool IsSetElasticGpuAssociationState()
        {
            return this._elasticGpuAssociationState != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticGpuAssociationTime. 
        /// <para>
        /// The time the Elastic Graphics accelerator was associated with the instance.
        /// </para>
        /// </summary>
        public string ElasticGpuAssociationTime
        {
            get { return this._elasticGpuAssociationTime; }
            set { this._elasticGpuAssociationTime = value; }
        }

        // Check to see if ElasticGpuAssociationTime property is set
        internal bool IsSetElasticGpuAssociationTime()
        {
            return this._elasticGpuAssociationTime != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticGpuId. 
        /// <para>
        /// The ID of the Elastic Graphics accelerator.
        /// </para>
        /// </summary>
        public string ElasticGpuId
        {
            get { return this._elasticGpuId; }
            set { this._elasticGpuId = value; }
        }

        // Check to see if ElasticGpuId property is set
        internal bool IsSetElasticGpuId()
        {
            return this._elasticGpuId != null;
        }

    }
}