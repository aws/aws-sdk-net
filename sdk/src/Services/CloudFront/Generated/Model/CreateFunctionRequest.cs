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
    /// Container for the parameters to the CreateFunction operation.
    /// Creates a CloudFront function.
    /// 
    ///  
    /// <para>
    /// To create a function, you provide the function code and some configuration information
    /// about the function. The response contains an Amazon Resource Name (ARN) that uniquely
    /// identifies the function.
    /// </para>
    ///  
    /// <para>
    /// When you create a function, it's in the <code>DEVELOPMENT</code> stage. In this stage,
    /// you can test the function with <code>TestFunction</code>, and update it with <code>UpdateFunction</code>.
    /// </para>
    ///  
    /// <para>
    /// When you're ready to use your function with a CloudFront distribution, use <code>PublishFunction</code>
    /// to copy the function from the <code>DEVELOPMENT</code> stage to <code>LIVE</code>.
    /// When it's live, you can attach the function to a distribution's cache behavior, using
    /// the function's ARN.
    /// </para>
    /// </summary>
    public partial class CreateFunctionRequest : AmazonCloudFrontRequest
    {
        private MemoryStream _functionCode;
        private FunctionConfig _functionConfig;
        private string _name;

        /// <summary>
        /// Gets and sets the property FunctionCode. 
        /// <para>
        /// The function code. For more information about writing a CloudFront function, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/writing-function-code.html">Writing
        /// function code for CloudFront Functions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=40960)]
        public MemoryStream FunctionCode
        {
            get { return this._functionCode; }
            set { this._functionCode = value; }
        }

        // Check to see if FunctionCode property is set
        internal bool IsSetFunctionCode()
        {
            return this._functionCode != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionConfig. 
        /// <para>
        /// Configuration information about the function, including an optional comment and the
        /// function's runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FunctionConfig FunctionConfig
        {
            get { return this._functionConfig; }
            set { this._functionConfig = value; }
        }

        // Check to see if FunctionConfig property is set
        internal bool IsSetFunctionConfig()
        {
            return this._functionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name to identify the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}