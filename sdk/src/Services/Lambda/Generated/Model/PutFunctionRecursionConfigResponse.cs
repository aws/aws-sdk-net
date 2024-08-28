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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the PutFunctionRecursionConfig operation.
    /// </summary>
    public partial class PutFunctionRecursionConfigResponse : AmazonWebServiceResponse
    {
        private RecursiveLoop _recursiveLoop;

        /// <summary>
        /// Gets and sets the property RecursiveLoop. 
        /// <para>
        /// The status of your function's recursive loop detection configuration.
        /// </para>
        ///  
        /// <para>
        /// When this value is set to <c>Allow</c>and Lambda detects your function being invoked
        /// as part of a recursive loop, it doesn't take any action.
        /// </para>
        ///  
        /// <para>
        /// When this value is set to <c>Terminate</c> and Lambda detects your function being
        /// invoked as part of a recursive loop, it stops your function being invoked and notifies
        /// you. 
        /// </para>
        /// </summary>
        public RecursiveLoop RecursiveLoop
        {
            get { return this._recursiveLoop; }
            set { this._recursiveLoop = value; }
        }

        // Check to see if RecursiveLoop property is set
        internal bool IsSetRecursiveLoop()
        {
            return this._recursiveLoop != null;
        }

    }
}