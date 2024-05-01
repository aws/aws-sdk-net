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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for the information about an asynchronous operation.
    /// </summary>
    public partial class AsyncOperation
    {
        private DateTime? _creationTime;
        private AsyncOperationName _operation;
        private AsyncRequestParameters _requestParameters;
        private string _requestStatus;
        private string _requestTokenARN;
        private AsyncResponseDetails _responseDetails;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the request was sent to the service.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The specific operation for the asynchronous request.
        /// </para>
        /// </summary>
        public AsyncOperationName Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// The parameters associated with the request.
        /// </para>
        /// </summary>
        public AsyncRequestParameters RequestParameters
        {
            get { return this._requestParameters; }
            set { this._requestParameters = value; }
        }

        // Check to see if RequestParameters property is set
        internal bool IsSetRequestParameters()
        {
            return this._requestParameters != null;
        }

        /// <summary>
        /// Gets and sets the property RequestStatus. 
        /// <para>
        /// The current status of the request.
        /// </para>
        /// </summary>
        public string RequestStatus
        {
            get { return this._requestStatus; }
            set { this._requestStatus = value; }
        }

        // Check to see if RequestStatus property is set
        internal bool IsSetRequestStatus()
        {
            return this._requestStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RequestTokenARN. 
        /// <para>
        /// The request token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RequestTokenARN
        {
            get { return this._requestTokenARN; }
            set { this._requestTokenARN = value; }
        }

        // Check to see if RequestTokenARN property is set
        internal bool IsSetRequestTokenARN()
        {
            return this._requestTokenARN != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseDetails. 
        /// <para>
        /// The details of the response.
        /// </para>
        /// </summary>
        public AsyncResponseDetails ResponseDetails
        {
            get { return this._responseDetails; }
            set { this._responseDetails = value; }
        }

        // Check to see if ResponseDetails property is set
        internal bool IsSetResponseDetails()
        {
            return this._responseDetails != null;
        }

    }
}