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
    /// Container for the parameters to the UpdateFunction operation.
    /// Updates a CloudFront function.
    /// 
    ///  
    /// <para>
    /// You can update a function's code or the comment that describes the function. You cannot
    /// update a function's name.
    /// </para>
    ///  
    /// <para>
    /// To update a function, you provide the function's name and version (<code>ETag</code>
    /// value) along with the updated function code. To get the name and version, you can
    /// use <code>ListFunctions</code> and <code>DescribeFunction</code>.
    /// </para>
    /// </summary>
    public partial class UpdateFunctionRequest : AmazonCloudFrontRequest
    {
        private MemoryStream _functionCode;
        private FunctionConfig _functionConfig;
        private string _ifMatch;
        private string _name;

        /// <summary>
        /// Gets and sets the property FunctionCode. 
        /// <para>
        /// The function code. For more information about writing a CloudFront function, see <a
        /// href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/writing-function-code.html">Writing
        /// function code for CloudFront Functions</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40960)]
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
        /// Configuration information about the function.
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
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<code>ETag</code> value) of the function that you are updating,
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
        /// The name of the function that you are updating.
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

    }
}