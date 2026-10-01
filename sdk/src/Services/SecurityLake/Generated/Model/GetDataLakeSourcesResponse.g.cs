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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// This is the response object from the GetDataLakeSources operation.
    /// </summary>
    public partial class GetDataLakeSourcesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DataLakeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) created by you to provide to the subscriber. For more
        /// information about ARNs and how to use them in policies, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/subscriber-management.html">Amazon
        /// Security Lake User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string DataLakeArn { get; set; }

        /// <summary>
        /// Checks to see if the DataLakeArn property is set.
        /// </summary>
        internal bool IsSetDataLakeArn() => this.DataLakeArn != null;

        /// <summary>
        /// Gets and sets the property DataLakeSources. 
        /// <para>
        /// The list of enabled accounts and enabled sources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataLakeSource> DataLakeSources { get; set; } = AWSConfigs.InitializeCollections ? new List<DataLakeSource>() : null;

        /// <summary>
        /// Checks to see if the DataLakeSources property is set.
        /// </summary>
        internal bool IsSetDataLakeSources() => this.DataLakeSources != null && (this.DataLakeSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Lists if there are more results available. The value of nextToken is a unique pagination
        /// token for each page. Repeat the call using the returned token to retrieve the next
        /// page. Keep all other arguments unchanged.
        /// </para>
        ///  
        /// <para>
        /// Each pagination token expires after 24 hours. Using an expired pagination token will
        /// return an HTTP 400 InvalidToken error.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
