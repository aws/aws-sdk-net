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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteQueryDefinition operation.
    /// Deletes a saved CloudWatch Logs Insights query definition. A query definition contains
    /// details about a saved CloudWatch Logs Insights query.
    /// 
    ///  
    /// <para>
    /// Each <c>DeleteQueryDefinition</c> operation can delete one query definition.
    /// </para>
    ///  
    /// <para>
    /// You must have the <c>logs:DeleteQueryDefinition</c> permission to be able to perform
    /// this operation.
    /// </para>
    /// </summary>
    public partial class DeleteQueryDefinitionRequest : AmazonCloudWatchLogsRequest
    {
        private string _queryDefinitionId;

        /// <summary>
        /// Gets and sets the property QueryDefinitionId. 
        /// <para>
        /// The ID of the query definition that you want to delete. You can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeQueryDefinitions.html">DescribeQueryDefinitions</a>
        /// to retrieve the IDs of your saved query definitions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string QueryDefinitionId
        {
            get { return this._queryDefinitionId; }
            set { this._queryDefinitionId = value; }
        }

        // Check to see if QueryDefinitionId property is set
        internal bool IsSetQueryDefinitionId()
        {
            return this._queryDefinitionId != null;
        }

    }
}