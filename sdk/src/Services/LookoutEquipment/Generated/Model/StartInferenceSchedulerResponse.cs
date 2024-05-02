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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the StartInferenceScheduler operation.
    /// </summary>
    public partial class StartInferenceSchedulerResponse : AmazonWebServiceResponse
    {
        private string _inferenceSchedulerArn;
        private string _inferenceSchedulerName;
        private string _modelArn;
        private string _modelName;
        private InferenceSchedulerStatus _status;

        /// <summary>
        /// Gets and sets the property InferenceSchedulerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the inference scheduler being started. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string InferenceSchedulerArn
        {
            get { return this._inferenceSchedulerArn; }
            set { this._inferenceSchedulerArn = value; }
        }

        // Check to see if InferenceSchedulerArn property is set
        internal bool IsSetInferenceSchedulerArn()
        {
            return this._inferenceSchedulerArn != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceSchedulerName. 
        /// <para>
        /// The name of the inference scheduler being started. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string InferenceSchedulerName
        {
            get { return this._inferenceSchedulerName; }
            set { this._inferenceSchedulerName = value; }
        }

        // Check to see if InferenceSchedulerName property is set
        internal bool IsSetInferenceSchedulerName()
        {
            return this._inferenceSchedulerName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model being used by the inference
        /// scheduler. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the machine learning model being used by the inference scheduler. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the inference scheduler. 
        /// </para>
        /// </summary>
        public InferenceSchedulerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}