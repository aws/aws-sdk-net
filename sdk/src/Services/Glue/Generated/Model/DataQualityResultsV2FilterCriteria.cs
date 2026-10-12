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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private DataSource _dataSource;
        private Dictionary<string, string> _dimensions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _evaluationContext;
        private DateTime? _publishedAfter;
        private DateTime? _publishedBefore;

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
        public DataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The platform dimensions to filter results by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public Dictionary<string, string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// The evaluation context to filter results by.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EvaluationContext
        {
            get { return this._evaluationContext; }
            set { this._evaluationContext = value; }
        }

        // Check to see if EvaluationContext property is set
        internal bool IsSetEvaluationContext()
        {
            return this._evaluationContext != null;
        }

        /// <summary>
        /// Gets and sets the property PublishedAfter. 
        /// <para>
        /// The time after which to include published results.
        /// </para>
        /// </summary>
        public DateTime? PublishedAfter
        {
            get { return this._publishedAfter; }
            set { this._publishedAfter = value; }
        }

        // Check to see if PublishedAfter property is set
        internal bool IsSetPublishedAfter()
        {
            return this._publishedAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublishedBefore. 
        /// <para>
        /// The time before which to include published results.
        /// </para>
        /// </summary>
        public DateTime? PublishedBefore
        {
            get { return this._publishedBefore; }
            set { this._publishedBefore = value; }
        }

        // Check to see if PublishedBefore property is set
        internal bool IsSetPublishedBefore()
        {
            return this._publishedBefore.HasValue; 
        }

    }
}