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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information for an endpoint.
    /// </summary>
    public partial class EndpointSummary
    {
        private DateTime? _creationTime;
        private string _endpointArn;
        private string _endpointName;
        private EndpointStatus _endpointStatus;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointStatus. 
        /// <para>
        /// The status of the endpoint.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>OutOfService</code>: Endpoint is not available to take incoming requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Creating</code>: <a>CreateEndpoint</a> is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Updating</code>: <a>UpdateEndpoint</a> or <a>UpdateEndpointWeightsAndCapacities</a>
        /// is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SystemUpdating</code>: Endpoint is undergoing maintenance and cannot be updated
        /// or deleted or re-scaled until it has completed. This maintenance operation does not
        /// change any customer-specified values such as VPC config, KMS encryption, model, instance
        /// type, or instance count.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RollingBack</code>: Endpoint fails to scale up or down or change its variant
        /// weight and is in the process of rolling back to its previous configuration. Once the
        /// rollback completes, endpoint returns to an <code>InService</code> status. This transitional
        /// status only applies to an endpoint that has autoscaling enabled and is undergoing
        /// variant weight or capacity changes as part of an <a>UpdateEndpointWeightsAndCapacities</a>
        /// call or when the <a>UpdateEndpointWeightsAndCapacities</a> operation is called explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InService</code>: Endpoint is available to process incoming requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Deleting</code>: <a>DeleteEndpoint</a> is executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Failed</code>: Endpoint could not be created, updated, or re-scaled. Use <a>DescribeEndpointOutput$FailureReason</a>
        /// for information about the failure. <a>DeleteEndpoint</a> is the only operation that
        /// can be performed on a failed endpoint.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get a list of endpoints with a specified status, use the <a>ListEndpointsInput$StatusEquals</a>
        /// filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointStatus EndpointStatus
        {
            get { return this._endpointStatus; }
            set { this._endpointStatus = value; }
        }

        // Check to see if EndpointStatus property is set
        internal bool IsSetEndpointStatus()
        {
            return this._endpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that shows when the endpoint was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}