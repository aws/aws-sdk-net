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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// This is the response object from the CreateFunction operation.
    /// </summary>
    public partial class CreateFunctionResponse : AmazonWebServiceResponse
    {
        private string _eTag;
        private FunctionSummary _functionSummary;
        private string _location;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The version identifier for the current version of the CloudFront function.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionSummary. 
        /// <para>
        /// Contains configuration information and metadata about a CloudFront function.
        /// </para>
        /// </summary>
        public FunctionSummary FunctionSummary
        {
            get { return this._functionSummary; }
            set { this._functionSummary = value; }
        }

        // Check to see if FunctionSummary property is set
        internal bool IsSetFunctionSummary()
        {
            return this._functionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The URL of the CloudFront function. Use the URL to manage the function with the CloudFront
        /// API.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}