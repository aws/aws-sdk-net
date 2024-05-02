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
    /// Container for the parameters to the CancelMLModelTransformJob operation.
    /// Cancels a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
    /// a trained model to generate new model artifacts</a>.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltransformjob">neptune-db:CancelMLModelTransformJob</a>
    /// IAM action in that cluster.
    /// </para>
    /// </summary>
    public partial class CancelMLModelTransformJobRequest : AmazonNeptunedataRequest
    {
        private bool? _clean;
        private string _id;
        private string _neptuneIamRoleArn;

        /// <summary>
        /// Gets and sets the property Clean. 
        /// <para>
        /// If this flag is set to <c>TRUE</c>, all Neptune ML S3 artifacts should be deleted
        /// when the job is stopped. The default is <c>FALSE</c>.
        /// </para>
        /// </summary>
        public bool? Clean
        {
            get { return this._clean; }
            set { this._clean = value; }
        }

        // Check to see if Clean property is set
        internal bool IsSetClean()
        {
            return this._clean.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the model transform job to be canceled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
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