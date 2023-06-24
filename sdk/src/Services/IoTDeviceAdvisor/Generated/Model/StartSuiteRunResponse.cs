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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// This is the response object from the StartSuiteRun operation.
    /// </summary>
    public partial class StartSuiteRunResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _endpoint;
        private string _suiteRunArn;
        private string _suiteRunId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Starts a Device Advisor test suite run based on suite create time.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The response of an Device Advisor test endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=45, Max=75)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteRunArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the started suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SuiteRunArn
        {
            get { return this._suiteRunArn; }
            set { this._suiteRunArn = value; }
        }

        // Check to see if SuiteRunArn property is set
        internal bool IsSetSuiteRunArn()
        {
            return this._suiteRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteRunId. 
        /// <para>
        /// Suite Run ID of the started suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string SuiteRunId
        {
            get { return this._suiteRunId; }
            set { this._suiteRunId = value; }
        }

        // Check to see if SuiteRunId property is set
        internal bool IsSetSuiteRunId()
        {
            return this._suiteRunId != null;
        }

    }
}