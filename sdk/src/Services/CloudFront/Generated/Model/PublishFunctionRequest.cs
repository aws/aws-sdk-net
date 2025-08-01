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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the PublishFunction operation.
    /// Publishes a CloudFront function by copying the function code from the <c>DEVELOPMENT</c>
    /// stage to <c>LIVE</c>. This automatically updates all cache behaviors that are using
    /// this function to use the newly published copy in the <c>LIVE</c> stage.
    /// 
    ///  
    /// <para>
    /// When a function is published to the <c>LIVE</c> stage, you can attach the function
    /// to a distribution's cache behavior, using the function's Amazon Resource Name (ARN).
    /// </para>
    ///  
    /// <para>
    /// To publish a function, you must provide the function's name and version (<c>ETag</c>
    /// value). To get these values, you can use <c>ListFunctions</c> and <c>DescribeFunction</c>.
    /// </para>
    /// </summary>
    public partial class PublishFunctionRequest : AmazonCloudFrontRequest
    {
        private string _ifMatch;
        private string _name;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<c>ETag</c> value) of the function that you are publishing, which
        /// you can get using <c>DescribeFunction</c>.
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
        /// The name of the function that you are publishing.
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