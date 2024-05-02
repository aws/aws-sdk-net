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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the DeleteWorkerConfiguration operation.
    /// </summary>
    public partial class DeleteWorkerConfigurationResponse : AmazonWebServiceResponse
    {
        private string _workerConfigurationArn;
        private WorkerConfigurationState _workerConfigurationState;

        /// <summary>
        /// Gets and sets the property WorkerConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the worker configuration that you requested to delete.
        /// </para>
        /// </summary>
        public string WorkerConfigurationArn
        {
            get { return this._workerConfigurationArn; }
            set { this._workerConfigurationArn = value; }
        }

        // Check to see if WorkerConfigurationArn property is set
        internal bool IsSetWorkerConfigurationArn()
        {
            return this._workerConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerConfigurationState. 
        /// <para>
        /// The state of the worker configuration.
        /// </para>
        /// </summary>
        public WorkerConfigurationState WorkerConfigurationState
        {
            get { return this._workerConfigurationState; }
            set { this._workerConfigurationState = value; }
        }

        // Check to see if WorkerConfigurationState property is set
        internal bool IsSetWorkerConfigurationState()
        {
            return this._workerConfigurationState != null;
        }

    }
}