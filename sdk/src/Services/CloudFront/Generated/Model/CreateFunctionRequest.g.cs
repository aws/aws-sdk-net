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
    /// Container for the parameters to the CreateFunction operation. Creates a CloudFront
    /// function. <para> To create a function, you provide the function code and some configuration
    /// information about the function. The response contains an Amazon Resource Name (ARN)
    /// that uniquely identifies the function. </para> <para> When you create a function,
    /// it's in the <c>DEVELOPMENT</c> stage. In this stage, you can test the function with
    /// <c>TestFunction</c>, and update it with <c>UpdateFunction</c>. </para> <para> When
    /// you're ready to use your function with a CloudFront distribution, use <c>PublishFunction</c>
    /// to copy the function from the <c>DEVELOPMENT</c> stage to <c>LIVE</c>. When it's live,
    /// you can attach the function to a distribution's cache behavior, using the function's
    /// ARN. </para>
    /// </summary>
    public partial class CreateFunctionRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Gets and sets the property FunctionCode. 
        /// <para>
        /// The function code. For more information about writing a CloudFront function, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/writing-function-code.html">Writing
        /// function code for CloudFront Functions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 40960)]
        public MemoryStream FunctionCode { get; set; }

        /// <summary>
        /// Checks to see if the FunctionCode property is set.
        /// </summary>
        internal bool IsSetFunctionCode() => this.FunctionCode != null;

        /// <summary>
        /// Gets and sets the property FunctionConfig. 
        /// <para>
        /// Configuration information about the function, including an optional comment and the
        /// function's runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FunctionConfig FunctionConfig { get; set; }

        /// <summary>
        /// Checks to see if the FunctionConfig property is set.
        /// </summary>
        internal bool IsSetFunctionConfig() => this.FunctionConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name to identify the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null;
    }
}
