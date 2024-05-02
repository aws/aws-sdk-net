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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the ListMLModelTrainingJobs operation.
    /// Lists Neptune ML model-training jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
    /// training using the <c>modeltraining</c> command</a>.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#neptune-db:listmlmodeltrainingjobs">neptune-db:neptune-db:ListMLModelTrainingJobs</a>
    /// IAM action in that cluster.
    /// </para>
    /// </summary>
    public partial class ListMLModelTrainingJobsRequest : AmazonNeptunedataRequest
    {
        private int? _maxItems;
        private string _neptuneIamRoleArn;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The maximum number of items to return (from 1 to 1024; the default is 10).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NeptuneIamRoleArn. 
        /// <para>
        /// The ARN of an IAM role that provides Neptune access to SageMaker and Amazon S3 resources.
        /// This must be listed in your DB cluster parameter group or an error will occur.
        /// </para>
        /// </summary>
        public string NeptuneIamRoleArn
        {
            get { return this._neptuneIamRoleArn; }
            set { this._neptuneIamRoleArn = value; }
        }

        // Check to see if NeptuneIamRoleArn property is set
        internal bool IsSetNeptuneIamRoleArn()
        {
            return this._neptuneIamRoleArn != null;
        }

    }
}