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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configurations that SageMaker uses when updating the AMI versions.
    /// </summary>
    public partial class RollingDeploymentPolicy
    {
        private CapacitySizeConfig _maximumBatchSize;
        private CapacitySizeConfig _rollbackMaximumBatchSize;

        /// <summary>
        /// Gets and sets the property MaximumBatchSize. 
        /// <para>
        /// The maximum amount of instances in the cluster that SageMaker can update at a time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacitySizeConfig MaximumBatchSize
        {
            get { return this._maximumBatchSize; }
            set { this._maximumBatchSize = value; }
        }

        // Check to see if MaximumBatchSize property is set
        internal bool IsSetMaximumBatchSize()
        {
            return this._maximumBatchSize != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackMaximumBatchSize. 
        /// <para>
        /// The maximum amount of instances in the cluster that SageMaker can roll back at a time.
        /// </para>
        /// </summary>
        public CapacitySizeConfig RollbackMaximumBatchSize
        {
            get { return this._rollbackMaximumBatchSize; }
            set { this._rollbackMaximumBatchSize = value; }
        }

        // Check to see if RollbackMaximumBatchSize property is set
        internal bool IsSetRollbackMaximumBatchSize()
        {
            return this._rollbackMaximumBatchSize != null;
        }

    }
}