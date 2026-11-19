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
    /// Container for the parameters to the UpdateFunction operation. Updates a CloudFront
    /// function. <para> You can update a function's code or the comment that describes the
    /// function. You cannot update a function's name. </para> <para> To update a function,
    /// you provide the function's name and version (<c>ETag</c> value) along with the updated
    /// function code. To get the name and version, you can use <c>ListFunctions</c> and <c>DescribeFunction</c>.
    /// </para>
    /// </summary>
    public partial class UpdateFunctionRequest : AmazonCloudFrontRequest
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
        /// Configuration information about the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FunctionConfig FunctionConfig { get; set; }

        /// <summary>
        /// Checks to see if the FunctionConfig property is set.
        /// </summary>
        internal bool IsSetFunctionConfig() => this.FunctionConfig != null;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<c>ETag</c> value) of the function that you are updating, which
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
        /// The name of the function that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
