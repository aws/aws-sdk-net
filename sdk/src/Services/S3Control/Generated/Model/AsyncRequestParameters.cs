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
    /// A container for the request parameters associated with an asynchronous request.
    /// </summary>
    public partial class AsyncRequestParameters
    {
        private CreateMultiRegionAccessPointInput _createMultiRegionAccessPointRequest;
        private DeleteMultiRegionAccessPointInput _deleteMultiRegionAccessPointRequest;
        private PutMultiRegionAccessPointPolicyInput _putMultiRegionAccessPointPolicyRequest;

        /// <summary>
        /// Gets and sets the property CreateMultiRegionAccessPointRequest. 
        /// <para>
        /// A container of the parameters for a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
        /// request.
        /// </para>
        /// </summary>
        public CreateMultiRegionAccessPointInput CreateMultiRegionAccessPointRequest
        {
            get { return this._createMultiRegionAccessPointRequest; }
            set { this._createMultiRegionAccessPointRequest = value; }
        }

        // Check to see if CreateMultiRegionAccessPointRequest property is set
        internal bool IsSetCreateMultiRegionAccessPointRequest()
        {
            return this._createMultiRegionAccessPointRequest != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteMultiRegionAccessPointRequest. 
        /// <para>
        /// A container of the parameters for a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteMultiRegionAccessPoint.html">DeleteMultiRegionAccessPoint</a>
        /// request.
        /// </para>
        /// </summary>
        public DeleteMultiRegionAccessPointInput DeleteMultiRegionAccessPointRequest
        {
            get { return this._deleteMultiRegionAccessPointRequest; }
            set { this._deleteMultiRegionAccessPointRequest = value; }
        }

        // Check to see if DeleteMultiRegionAccessPointRequest property is set
        internal bool IsSetDeleteMultiRegionAccessPointRequest()
        {
            return this._deleteMultiRegionAccessPointRequest != null;
        }

        /// <summary>
        /// Gets and sets the property PutMultiRegionAccessPointPolicyRequest. 
        /// <para>
        /// A container of the parameters for a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_PutMultiRegionAccessPoint.html">PutMultiRegionAccessPoint</a>
        /// request.
        /// </para>
        /// </summary>
        public PutMultiRegionAccessPointPolicyInput PutMultiRegionAccessPointPolicyRequest
        {
            get { return this._putMultiRegionAccessPointPolicyRequest; }
            set { this._putMultiRegionAccessPointPolicyRequest = value; }
        }

        // Check to see if PutMultiRegionAccessPointPolicyRequest property is set
        internal bool IsSetPutMultiRegionAccessPointPolicyRequest()
        {
            return this._putMultiRegionAccessPointPolicyRequest != null;
        }

    }
}