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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The proposed access control configuration for a DynamoDB table or index. You can propose
    /// a configuration for a new DynamoDB table or index or an existing DynamoDB table or
    /// index that you own by specifying the policy for the DynamoDB table or index. For more
    /// information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_PutResourcePolicy.html">PutResourcePolicy</a>.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If the configuration is for an existing DynamoDB table or index and you do not specify
    /// the DynamoDB policy, then the access preview uses the existing DynamoDB policy for
    /// the table or index.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the access preview is for a new resource and you do not specify the policy, then
    /// the access preview assumes a DynamoDB table without a policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To propose deletion of an existing DynamoDB table or index policy, you can specify
    /// an empty string for the DynamoDB policy.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DynamodbTableConfiguration
    {
        private string _tablePolicy;

        /// <summary>
        /// Gets and sets the property TablePolicy. 
        /// <para>
        /// The proposed resource policy defining who can access or manage the DynamoDB table.
        /// </para>
        /// </summary>
        public string TablePolicy
        {
            get { return this._tablePolicy; }
            set { this._tablePolicy = value; }
        }

        // Check to see if TablePolicy property is set
        internal bool IsSetTablePolicy()
        {
            return this._tablePolicy != null;
        }

    }
}