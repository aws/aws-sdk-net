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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// This is the response object from the CreateFunction operation.
    /// </summary>
    public partial class CreateFunctionResponse : AmazonWebServiceResponse
    {
        private FunctionConfiguration _functionConfiguration;

        /// <summary>
        /// Gets and sets the property FunctionConfiguration. 
        /// <para>
        /// The <c>Function</c> object.
        /// </para>
        /// </summary>
        public FunctionConfiguration FunctionConfiguration
        {
            get { return this._functionConfiguration; }
            set { this._functionConfiguration = value; }
        }

        // Check to see if FunctionConfiguration property is set
        internal bool IsSetFunctionConfiguration()
        {
            return this._functionConfiguration != null;
        }

    }
}