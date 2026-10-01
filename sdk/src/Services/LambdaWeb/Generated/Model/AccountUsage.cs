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
    /// Contains your current web function usage for the current AWS Region.
    /// </summary>
    public partial class AccountUsage
    {
        private int? _functionCount;

        /// <summary>
        /// Gets and sets the property FunctionCount. 
        /// <para>
        /// The number of web functions in your account in the current AWS Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? FunctionCount
        {
            get { return this._functionCount; }
            set { this._functionCount = value; }
        }

        // Check to see if FunctionCount property is set
        internal bool IsSetFunctionCount()
        {
            return this._functionCount.HasValue; 
        }

    }
}