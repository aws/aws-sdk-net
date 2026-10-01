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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The DataIntegrationFlow target parameters.
    /// </summary>
    public partial class DataIntegrationFlowTarget
    {
        /// <summary>
        /// Gets and sets the property DatasetTarget. 
        /// <para>
        /// The dataset DataIntegrationFlow target. Note that for AWS Supply Chain dataset under
        /// <b>asc</b> namespace, it has a connection_id internal field that is not allowed to
        /// be provided by client directly, they will be auto populated.
        /// </para>
        /// </summary>
        public DataIntegrationFlowDatasetTargetConfiguration DatasetTarget { get; set; }

        /// <summary>
        /// Checks to see if the DatasetTarget property is set.
        /// </summary>
        internal bool IsSetDatasetTarget() => this.DatasetTarget != null;

        /// <summary>
        /// Gets and sets the property S3Target. 
        /// <para>
        /// The S3 DataIntegrationFlow target.
        /// </para>
        /// </summary>
        public DataIntegrationFlowS3TargetConfiguration S3Target { get; set; }

        /// <summary>
        /// Checks to see if the S3Target property is set.
        /// </summary>
        internal bool IsSetS3Target() => this.S3Target != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The DataIntegrationFlow target type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataIntegrationFlowTargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}
