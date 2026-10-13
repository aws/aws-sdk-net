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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Describes the criteria used to filter the data quality results returned by <c>ListDataQualityResultsV2</c>.
    /// </summary>
    public partial class DataQualityResultsV2FilterCriteria
    {
        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source used to filter the results. For example, you can retrieve all results
        /// for an Glue table. <c>DatabaseName</c> and <c>TableName</c> are required. If you omit
        /// <c>CatalogId</c>, the catalog of the calling account is used.
        /// </para>
        ///  
        /// <para>
        /// When you filter by data source, a page of results can be empty but still include a
        /// <c>NextToken</c>. Keep requesting pages until <c>NextToken</c> is absent.
        /// </para>
        /// </summary>
        public DataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The platform dimensions to filter results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The evaluation context to filter results by.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EvaluationContext { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationContext property is set.
        /// </summary>
        internal bool IsSetEvaluationContext() => this.EvaluationContext != null;

        /// <summary>
        /// Gets and sets the property PublishedAfter. 
        /// <para>
        /// The time after which to include published results.
        /// </para>
        /// </summary>
        public DateTime? PublishedAfter { get; set; }

        /// <summary>
        /// Checks to see if the PublishedAfter property is set.
        /// </summary>
        internal bool IsSetPublishedAfter() => this.PublishedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property PublishedBefore. 
        /// <para>
        /// The time before which to include published results.
        /// </para>
        /// </summary>
        public DateTime? PublishedBefore { get; set; }

        /// <summary>
        /// Checks to see if the PublishedBefore property is set.
        /// </summary>
        internal bool IsSetPublishedBefore() => this.PublishedBefore.HasValue;
    }
}
