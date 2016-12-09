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
 * Do not modify this file. This file is generated from the cloudfront-2016-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that contains a Lambda function association.
    /// </summary>
    public partial class LambdaFunctionAssociation
    {
        private EventType _eventType;
        private string _lambdaFunctionARN;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// Specifies the event type that triggers a Lambda function invocation. Valid values
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>viewer-request</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>origin-request</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>viewer-response</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>origin-response</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property LambdaFunctionARN. 
        /// <para>
        /// The ARN of the Lambda function.
        /// </para>
        /// </summary>
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