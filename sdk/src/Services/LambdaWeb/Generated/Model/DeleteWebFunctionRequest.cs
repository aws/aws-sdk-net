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
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
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
namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteWebFunction operation.
    /// Deletes a web function and all of its associated revisions and endpoints.
    /// 
    ///  
    /// <para>
    /// To use this operation, you must have the <c>DeleteWebFunction</c> permission on the
    /// web function. You don't need the <c>DeleteWebFunctionRevision</c> or <c>DeleteWebFunctionEndpoint</c>
    /// permission.
    /// </para>
    /// </summary>
    public partial class DeleteWebFunctionRequest : AmazonLambdaWebRequest
    {
        private string _functionName;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name of the web function to delete. You can specify the function name or the function
        /// ARN. The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

    }
}