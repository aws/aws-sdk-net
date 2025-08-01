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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies the order of a service environment for a job queue. This determines the
    /// priority order when multiple service environments are associated with the same job
    /// queue.
    /// </summary>
    public partial class ServiceEnvironmentOrder
    {
        private int? _order;
        private string _serviceEnvironment;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order of the service environment. Job queues with a higher priority are evaluated
        /// first when associated with the same service environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceEnvironment. 
        /// <para>
        /// The name or ARN of the service environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceEnvironment
        {
            get { return this._serviceEnvironment; }
            set { this._serviceEnvironment = value; }
        }

        // Check to see if ServiceEnvironment property is set
        internal bool IsSetServiceEnvironment()
        {
            return this._serviceEnvironment != null;
        }

    }
}