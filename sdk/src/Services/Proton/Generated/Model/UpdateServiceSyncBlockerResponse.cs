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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the UpdateServiceSyncBlocker operation.
    /// </summary>
    public partial class UpdateServiceSyncBlockerResponse : AmazonWebServiceResponse
    {
        private string _serviceInstanceName;
        private string _serviceName;
        private SyncBlocker _serviceSyncBlocker;

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that you want to update the service sync blocker
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ServiceInstanceName
        {
            get { return this._serviceInstanceName; }
            set { this._serviceInstanceName = value; }
        }

        // Check to see if ServiceInstanceName property is set
        internal bool IsSetServiceInstanceName()
        {
            return this._serviceInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that you want to update the service sync blocker for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceSyncBlocker. 
        /// <para>
        /// The detailed data on the service sync blocker that was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SyncBlocker ServiceSyncBlocker
        {
            get { return this._serviceSyncBlocker; }
            set { this._serviceSyncBlocker = value; }
        }

        // Check to see if ServiceSyncBlocker property is set
        internal bool IsSetServiceSyncBlocker()
        {
            return this._serviceSyncBlocker != null;
        }

    }
}