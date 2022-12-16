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
    /// Container for the parameters to the TestFunction operation.
    /// Tests a CloudFront function.
    /// 
    ///  
    /// <para>
    /// To test a function, you provide an <i>event object</i> that represents an HTTP request
    /// or response that your CloudFront distribution could receive in production. CloudFront
    /// runs the function, passing it the event object that you provided, and returns the
    /// function's result (the modified event object) in the response. The response also contains
    /// function logs and error messages, if any exist. For more information about testing
    /// functions, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/managing-functions.html#test-function">Testing
    /// functions</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To test a function, you provide the function's name and version (<code>ETag</code>
    /// value) along with the event object. To get the function's name and version, you can
    /// use <code>ListFunctions</code> and <code>DescribeFunction</code>.
    /// </para>
    /// </summary>
    public partial class TestFunctionRequest : AmazonCloudFrontRequest
    {
        private MemoryStream _eventObject;
        private string _ifMatch;
        private string _name;
        private FunctionStage _stage;

        /// <summary>
        /// Gets and sets the property EventObject. 
        /// <para>
        /// The event object to test the function with. For more information about the structure
        /// of the event object, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/managing-functions.html#test-function">Testing
        /// functions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=40960)]
        public MemoryStream EventObject
        {
            get { return this._eventObject; }
            set { this._eventObject = value; }
        }

        // Check to see if EventObject property is set
        internal bool IsSetEventObject()
        {
            return this._eventObject != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<code>ETag</code> value) of the function that you are testing,
        /// which you can get using <code>DescribeFunction</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the function that you are testing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage of the function that you are testing, either <code>DEVELOPMENT</code> or
        /// <code>LIVE</code>.
        /// </para>
        /// </summary>
        public FunctionStage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

    }
}