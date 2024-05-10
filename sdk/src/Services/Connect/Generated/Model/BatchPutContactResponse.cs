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
    /// This is the response object from the BatchPutContact operation.
    /// </summary>
    public partial class BatchPutContactResponse : AmazonWebServiceResponse
    {
        private List<FailedRequest> _failedRequestList = AWSConfigs.InitializeCollections ? new List<FailedRequest>() : null;
        private List<SuccessfulRequest> _successfulRequestList = AWSConfigs.InitializeCollections ? new List<SuccessfulRequest>() : null;

        /// <summary>
        /// Gets and sets the property FailedRequestList. 
        /// <para>
        /// List of requests for which contact creation failed.
        /// </para>
        /// </summary>
        public List<FailedRequest> FailedRequestList
        {
            get { return this._failedRequestList; }
            set { this._failedRequestList = value; }
        }

        // Check to see if FailedRequestList property is set
        internal bool IsSetFailedRequestList()
        {
            return this._failedRequestList != null && (this._failedRequestList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulRequestList. 
        /// <para>
        /// List of requests for which contact was successfully created.
        /// </para>
        /// </summary>
        public List<SuccessfulRequest> SuccessfulRequestList
        {
            get { return this._successfulRequestList; }
            set { this._successfulRequestList = value; }
        }

        // Check to see if SuccessfulRequestList property is set
        internal bool IsSetSuccessfulRequestList()
        {
            return this._successfulRequestList != null && (this._successfulRequestList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}