/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Information about the errors that are returned for each failed resource. This information
    /// can include <code>InternalServiceException</code> and <code>InvalidParameterException</code>
    /// errors. It can also include any valid error code returned by the AWS service that
    /// hosts the resource that the ARN key represents.
    /// 
    ///  
    /// <para>
    /// The following are common error codes that you might receive from other AWS services:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>InternalServiceException</b> – This can mean that the Resource Groups Tagging
    /// API didn't receive a response from another AWS service. It can also mean the the resource
    /// type in the request is not supported by the Resource Groups Tagging API. In these
    /// cases, it's safe to retry the request and then call <a href="http://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html">GetResources</a>
    /// to verify the changes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>AccessDeniedException</b> – This can mean that you need permission to calling
    /// tagging operations in the AWS service that contains the resource. For example, to
    /// use the Resource Groups Tagging API to tag a CloudWatch alarm resource, you need permission
    /// to call <a href="http://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_TagResources.html">
    /// <code>TagResources</code> </a> <i>and</i> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_TagResource.html">
    /// <code>TagResource</code> </a> in the CloudWatch API. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information on errors that are generated from other AWS services, see the
    /// documentation for that service. 
    /// </para>
    /// </summary>
    public partial class FailureInfo
    {
        private ErrorCode _errorCode;
        private string _errorMessage;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The code of the common error. Valid values include <code>InternalServiceException</code>,
        /// <code>InvalidParameterException</code>, and any valid error code returned by the AWS
        /// service that hosts the resource that you want to tag.
        /// </para>
        /// </summary>
        public ErrorCode ErrorCode
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
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The message of the common error.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code of the common error.
        /// </para>
        /// </summary>
        public int StatusCode
        {
            get { return this._statusCode.GetValueOrDefault(); }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}