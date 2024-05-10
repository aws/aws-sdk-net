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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The error code and error description associated with the resource.
    /// </summary>
    public partial class BatchDescribeModelPackageError
    {
        private string _errorCode;
        private string _errorResponse;

        /// <summary>
        /// Gets and sets the property ErrorCode.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorResponse.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ErrorResponse
        {
            get { return this._errorResponse; }
            set { this._errorResponse = value; }
        }

        // Check to see if ErrorResponse property is set
        internal bool IsSetErrorResponse()
        {
            return this._errorResponse != null;
        }

    }
}