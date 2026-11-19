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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the TestFunction operation. Tests a CloudFront function.
    /// <para> To test a function, you provide an <i>event object</i> that represents an HTTP
    /// request or response that your CloudFront distribution could receive in production.
    /// CloudFront runs the function, passing it the event object that you provided, and returns
    /// the function's result (the modified event object) in the response. The response also
    /// contains function logs and error messages, if any exist. For more information about
    /// testing functions, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/managing-functions.html#test-function">Testing
    /// functions</a> in the <i>Amazon CloudFront Developer Guide</i>. </para> <para> To test
    /// a function, you provide the function's name and version (<c>ETag</c> value) along
    /// with the event object. To get the function's name and version, you can use <c>ListFunctions</c>
    /// and <c>DescribeFunction</c>. </para>
    /// </summary>
    public partial class TestFunctionRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property EventObject. 
        /// <para>
        /// The event object to test the function with. For more information about the structure
        /// of the event object, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/managing-functions.html#test-function">Testing
        /// functions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 40960)]
        public MemoryStream EventObject { get; set; }

        /// <summary>
        /// Checks to see if the EventObject property is set.
        /// </summary>
        internal bool IsSetEventObject() => this.EventObject != null;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<c>ETag</c> value) of the function that you are testing, which
        /// you can get using <c>DescribeFunction</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the function that you are testing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        /// The stage of the function that you are testing, either <c>DEVELOPMENT</c> or <c>LIVE</c>.
        /// </para>
        /// </summary>
        public FunctionStage Stage { get; set; }

        /// <summary>
        /// Checks to see if the Stage property is set.
        /// </summary>
        internal bool IsSetStage() => this.Stage != null;
    }
}
