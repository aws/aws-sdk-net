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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the GetContactMetrics operation.
    /// Gets the real-time metrics of the specified contact.
    /// 
    ///  
    /// <para>
    ///  <b>Use cases</b> 
    /// </para>
    ///  
    /// <para>
    /// Following are common uses cases for this API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can use this API to retrieve the position of the contact in the queue.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect endpoints and quotas</a>.
    /// </para>
    /// </summary>
    public partial class GetContactMetricsRequest : AmazonConnectRequest
    {
        private string _contactId;
        private string _instanceId;
        private List<ContactMetricInfo> _metrics = AWSConfigs.InitializeCollections ? new List<ContactMetricInfo>() : null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Amazon Connect. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A list of contact-level metrics to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<ContactMetricInfo> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}