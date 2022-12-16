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
    /// Container for the parameters to the GetFunction operation.
    /// Gets the code of a CloudFront function. To get configuration information and metadata
    /// about a function, use <code>DescribeFunction</code>.
    /// 
    ///  
    /// <para>
    /// To get a function's code, you must provide the function's name and stage. To get these
    /// values, you can use <code>ListFunctions</code>.
    /// </para>
    /// </summary>
    public partial class GetFunctionRequest : AmazonCloudFrontRequest
    {
        private string _name;
        private FunctionStage _stage;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the function whose code you are getting.
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
        /// The function's stage, either <code>DEVELOPMENT</code> or <code>LIVE</code>.
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