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
    /// Container for the parameters to the DeleteFunction operation.
    /// Deletes a CloudFront function.
    /// 
    ///  
    /// <para>
    /// You cannot delete a function if it's associated with a cache behavior. First, update
    /// your distributions to remove the function association from all cache behaviors, then
    /// delete the function.
    /// </para>
    ///  
    /// <para>
    /// To delete a function, you must provide the function's name and version (<code>ETag</code>
    /// value). To get these values, you can use <code>ListFunctions</code> and <code>DescribeFunction</code>.
    /// </para>
    /// </summary>
    public partial class DeleteFunctionRequest : AmazonCloudFrontRequest
    {
        private string _ifMatch;
        private string _name;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<code>ETag</code> value) of the function that you are deleting,
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
        /// The name of the function that you are deleting.
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