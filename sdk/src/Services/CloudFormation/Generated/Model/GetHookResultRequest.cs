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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetHookResult operation.
    /// Retrieves detailed information and remediation guidance for a Hook invocation result.
    /// </summary>
    public partial class GetHookResultRequest : AmazonCloudFormationRequest
    {
        private string _hookResultId;

        /// <summary>
        /// Gets and sets the property HookResultId. 
        /// <para>
        /// The unique identifier (ID) of the Hook invocation result that you want details about.
        /// You can get the ID from the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/APIReference/API_ListHookResults.html">ListHookResults</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string HookResultId
        {
            get { return this._hookResultId; }
            set { this._hookResultId = value; }
        }

        // Check to see if HookResultId property is set
        internal bool IsSetHookResultId()
        {
            return this._hookResultId != null;
        }

    }
}