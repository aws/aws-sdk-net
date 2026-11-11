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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the request was sent to the service.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The specific operation for the asynchronous request.
        /// </para>
        /// </summary>
        public AsyncOperationName Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// The parameters associated with the request.
        /// </para>
        /// </summary>
        public AsyncRequestParameters RequestParameters { get; set; }

        /// <summary>
        /// Checks to see if the RequestParameters property is set.
        /// </summary>
        internal bool IsSetRequestParameters() => this.RequestParameters != null;

        /// <summary>
        /// Gets and sets the property RequestStatus. 
        /// <para>
        /// The current status of the request.
        /// </para>
        /// </summary>
        public string RequestStatus { get; set; }

        /// <summary>
        /// Checks to see if the RequestStatus property is set.
        /// </summary>
        internal bool IsSetRequestStatus() => this.RequestStatus != null;

        /// <summary>
        /// Gets and sets the property RequestTokenARN. 
        /// <para>
        /// The request token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RequestTokenARN { get; set; }

        /// <summary>
        /// Checks to see if the RequestTokenARN property is set.
        /// </summary>
        internal bool IsSetRequestTokenARN() => this.RequestTokenARN != null;

        /// <summary>
        /// Gets and sets the property ResponseDetails. 
        /// <para>
        /// The details of the response.
        /// </para>
        /// </summary>
        public AsyncResponseDetails ResponseDetails { get; set; }

        /// <summary>
        /// Checks to see if the ResponseDetails property is set.
        /// </summary>
        internal bool IsSetResponseDetails() => this.ResponseDetails != null;
    }
}
