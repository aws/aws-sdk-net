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

namespace Amazon.PI.Model
{
    /// <summary>
    /// Container for the parameters to the ListPerformanceAnalysisReports operation. Lists
    /// all the analysis reports created for the DB instance. The reports are sorted based
    /// on the start time of each report.
    /// </summary>
    public partial class ListPerformanceAnalysisReportsRequest : AmazonPIRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An immutable identifier for a data source that is unique for an Amazon Web Services
        /// Region. Performance Insights gathers metrics from this data source. In the console,
        /// the identifier is shown as <i>ResourceID</i>. When you call <c>DescribeDBInstances</c>,
        /// the identifier is returned as <c>DbiResourceId</c>.
        /// </para>
        ///  
        /// <para>
        /// To use a DB instance as a data source, specify its <c>DbiResourceId</c> value. For
        /// example, specify <c>db-ABCDEFGHIJKLMNOPQRSTU1VW2X</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property ListTags. 
        /// <para>
        /// Specifies whether or not to include the list of tags in the response.
        /// </para>
        /// </summary>
        public bool? ListTags { get; set; }

        /// <summary>
        /// Checks to see if the ListTags property is set.
        /// </summary>
        internal bool IsSetListTags() => this.ListTags.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return in the response. If more items exist than the
        /// specified <c>MaxResults</c> value, a pagination token is included in the response
        /// so that the remaining results can be retrieved. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the token, up to the value specified
        /// by <c>MaxResults</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The Amazon Web Services service for which Performance Insights returns metrics. Valid
        /// value is <c>RDS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceType ServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null;
    }
}
