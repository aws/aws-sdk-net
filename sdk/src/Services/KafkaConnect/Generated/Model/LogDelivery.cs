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
    /// Details about log delivery.
    /// </summary>
    public partial class LogDelivery
    {
        private WorkerLogDelivery _workerLogDelivery;

        /// <summary>
        /// Gets and sets the property WorkerLogDelivery. 
        /// <para>
        /// The workers can send worker logs to different destination types. This configuration
        /// specifies the details of these destinations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkerLogDelivery WorkerLogDelivery
        {
            get { return this._workerLogDelivery; }
            set { this._workerLogDelivery = value; }
        }

        // Check to see if WorkerLogDelivery property is set
        internal bool IsSetWorkerLogDelivery()
        {
            return this._workerLogDelivery != null;
        }

    }
}