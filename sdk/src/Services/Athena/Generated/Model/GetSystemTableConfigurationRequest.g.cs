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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the GetSystemTableConfiguration operation. Returns
    /// the account-level system tables configuration. Fails with a <c>ResourceNotFoundException</c>
    /// if system tables are not enabled for the account.
    /// </summary>
    public partial class GetSystemTableConfigurationRequest : AmazonAthenaRequest
    {
        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The system table configuration to retrieve. The only accepted value is <c>ALL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SystemTableName TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
