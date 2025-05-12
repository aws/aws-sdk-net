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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
        private DataIntegrationFlowDatasetTargetConfiguration _datasetTarget;
        private DataIntegrationFlowS3TargetConfiguration _s3Target;
        private DataIntegrationFlowTargetType _targetType;

        /// <summary>
        /// Gets and sets the property DatasetTarget. 
        /// <para>
        /// The dataset DataIntegrationFlow target. Note that for AWS Supply Chain dataset under
        /// <b>asc</b> namespace, it has a connection_id internal field that is not allowed to
        /// be provided by client directly, they will be auto populated.
        /// </para>
        /// </summary>
        public DataIntegrationFlowDatasetTargetConfiguration DatasetTarget
        {
            get { return this._datasetTarget; }
            set { this._datasetTarget = value; }
        }

        // Check to see if DatasetTarget property is set
        internal bool IsSetDatasetTarget()
        {
            return this._datasetTarget != null;
        }

        /// <summary>
        /// Gets and sets the property S3Target. 
        /// <para>
        /// The S3 DataIntegrationFlow target.
        /// </para>
        /// </summary>
        public DataIntegrationFlowS3TargetConfiguration S3Target
        {
            get { return this._s3Target; }
            set { this._s3Target = value; }
        }

        // Check to see if S3Target property is set
        internal bool IsSetS3Target()
        {
            return this._s3Target != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The DataIntegrationFlow target type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationFlowTargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}