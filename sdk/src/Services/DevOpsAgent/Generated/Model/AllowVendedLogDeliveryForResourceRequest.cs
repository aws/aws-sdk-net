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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the AllowVendedLogDeliveryForResource operation.
    /// Authorize Ingestion Hub subscription operation.
    /// </summary>
    public partial class AllowVendedLogDeliveryForResourceRequest : AmazonDevOpsAgentRequest
    {
        private string _deliverySourceArn;
        private string _logType;
        private string _resourceArnBeingAuthorized;

        /// <summary>
        /// Gets and sets the property DeliverySourceArn. 
        /// <para>
        /// The ARN of the delivery source for vended log delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeliverySourceArn
        {
            get { return this._deliverySourceArn; }
            set { this._deliverySourceArn = value; }
        }

        // Check to see if DeliverySourceArn property is set
        internal bool IsSetDeliverySourceArn()
        {
            return this._deliverySourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// The type of log to be delivered.
        /// </para>
        /// </summary>
        public string LogType
        {
            get { return this._logType; }
            set { this._logType = value; }
        }

        // Check to see if LogType property is set
        internal bool IsSetLogType()
        {
            return this._logType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArnBeingAuthorized. 
        /// <para>
        /// The ARN of the resource being authorized for vended log delivery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArnBeingAuthorized
        {
            get { return this._resourceArnBeingAuthorized; }
            set { this._resourceArnBeingAuthorized = value; }
        }

        // Check to see if ResourceArnBeingAuthorized property is set
        internal bool IsSetResourceArnBeingAuthorized()
        {
            return this._resourceArnBeingAuthorized != null;
        }

    }
}