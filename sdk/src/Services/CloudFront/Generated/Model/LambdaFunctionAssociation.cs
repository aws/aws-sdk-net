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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that contains a Lambda@Edge function association.
    /// </summary>
    public partial class LambdaFunctionAssociation
    {
        private EventType _eventType;
        private bool? _includeBody;
        private string _lambdaFunctionARN;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// Specifies the event type that triggers a Lambda@Edge function invocation. You can
        /// specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>viewer-request</code>: The function executes when CloudFront receives a request
        /// from a viewer and before it checks to see whether the requested object is in the edge
        /// cache.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>origin-request</code>: The function executes only when CloudFront sends a request
        /// to your origin. When the requested object is in the edge cache, the function doesn't
        /// execute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>origin-response</code>: The function executes after CloudFront receives a response
        /// from the origin and before it caches the object in the response. When the requested
        /// object is in the edge cache, the function doesn't execute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>viewer-response</code>: The function executes before CloudFront returns the
        /// requested object to the viewer. The function executes regardless of whether the object
        /// was already in the edge cache.
        /// </para>
        ///  
        /// <para>
        /// If the origin returns an HTTP status code other than HTTP 200 (OK), the function doesn't
        /// execute.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeBody. 
        /// <para>
        /// A flag that allows a Lambda@Edge function to have read access to the body content.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/lambda-include-body-access.html">Accessing
        /// the Request Body by Choosing the Include Body Option</a> in the Amazon CloudFront
        /// Developer Guide.
        /// </para>
        /// </summary>
        public bool IncludeBody
        {
            get { return this._includeBody.GetValueOrDefault(); }
            set { this._includeBody = value; }
        }

        // Check to see if IncludeBody property is set
        internal bool IsSetIncludeBody()
        {
            return this._includeBody.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionARN. 
        /// <para>
        /// The ARN of the Lambda@Edge function. You must specify the ARN of a function version;
        /// you can't specify an alias or $LATEST.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LambdaFunctionARN
        {
            get { return this._lambdaFunctionARN; }
            set { this._lambdaFunctionARN = value; }
        }

        // Check to see if LambdaFunctionARN property is set
        internal bool IsSetLambdaFunctionARN()
        {
            return this._lambdaFunctionARN != null;
        }

    }
}