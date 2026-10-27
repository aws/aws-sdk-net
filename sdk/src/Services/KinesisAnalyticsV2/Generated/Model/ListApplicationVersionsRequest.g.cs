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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListApplicationVersions operation. Lists all the
    /// versions for the specified application, including versions that were rolled back.
    /// The response also includes a summary of the configuration associated with each version.
    /// <para> To get the complete description of a specific application version, invoke the
    /// <a>DescribeApplicationVersion</a> operation. </para> <note> <para> This operation
    /// is supported only for Managed Service for Apache Flink. </para> </note>
    /// </summary>
    public partial class ListApplicationVersionsRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application for which you want to list all versions.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of versions to list in this invocation of the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If a previous invocation of this operation returned a pagination token, pass it into
        /// this value to retrieve the next set of results. For more information about pagination,
        /// see <a href="https://docs.aws.amazon.com/cli/latest/userguide/pagination.html">Using
        /// the Amazon Command Line Interface's Pagination Options</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
