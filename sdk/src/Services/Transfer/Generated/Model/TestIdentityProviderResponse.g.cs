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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// This is the response object from the TestIdentityProvider operation.
    /// </summary>
    public partial class TestIdentityProviderResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that indicates whether the test was successful or not.
        /// </para>
        ///  <note> 
        /// <para>
        /// If an empty string is returned, the most likely cause is that the authentication failed
        /// due to an incorrect username or password.
        /// </para>
        ///  </note>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Response. 
        /// <para>
        /// The response that is returned from your API Gateway or your Lambda function.
        /// </para>
        /// </summary>
        public string Response { get; set; }

        /// <summary>
        /// Checks to see if the Response property is set.
        /// </summary>
        internal bool IsSetResponse() => this.Response != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code that is the response from your API Gateway or your Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The endpoint of the service used to authenticate a user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
