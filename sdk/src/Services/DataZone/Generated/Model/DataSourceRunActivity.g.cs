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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The activity details of the data source run.
    /// </summary>
    public partial class DataSourceRunActivity
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when data source run activity was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataAssetId. 
        /// <para>
        /// The identifier of the asset included in the data source run activity.
        /// </para>
        /// </summary>
        public string DataAssetId { get; set; }

        /// <summary>
        /// Checks to see if the DataAssetId property is set.
        /// </summary>
        internal bool IsSetDataAssetId() => this.DataAssetId != null;

        /// <summary>
        /// Gets and sets the property DataAssetStatus. 
        /// <para>
        /// The status of the asset included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataAssetActivityStatus DataAssetStatus { get; set; }

        /// <summary>
        /// Checks to see if the DataAssetStatus property is set.
        /// </summary>
        internal bool IsSetDataAssetStatus() => this.DataAssetStatus != null;

        /// <summary>
        /// Gets and sets the property DataSourceRunId. 
        /// <para>
        /// The identifier of the data source for the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSourceRunId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceRunId property is set.
        /// </summary>
        internal bool IsSetDataSourceRunId() => this.DataSourceRunId != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage.
        /// </summary>
        public DataSourceErrorMessage ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LineageSummary. 
        /// <para>
        /// The data lineage summary.
        /// </para>
        /// </summary>
        public LineageInfo LineageSummary { get; set; }

        /// <summary>
        /// Checks to see if the LineageSummary property is set.
        /// </summary>
        internal bool IsSetLineageSummary() => this.LineageSummary != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The project ID included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property TechnicalDescription. 
        /// <para>
        /// The technical description included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string TechnicalDescription { get; set; }

        /// <summary>
        /// Checks to see if the TechnicalDescription property is set.
        /// </summary>
        internal bool IsSetTechnicalDescription() => this.TechnicalDescription != null;

        /// <summary>
        /// Gets and sets the property TechnicalName. 
        /// <para>
        /// The technical name included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string TechnicalName { get; set; }

        /// <summary>
        /// Checks to see if the TechnicalName property is set.
        /// </summary>
        internal bool IsSetTechnicalName() => this.TechnicalName != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when data source run activity was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
