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
    /// This is the response object from the DeleteDataSource operation.
    /// </summary>
    public partial class DeleteDataSourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssetFormsOutput. 
        /// <para>
        /// The asset data forms associated with this data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<FormOutput> AssetFormsOutput { get; set; } = AWSConfigs.InitializeCollections ? new List<FormOutput>() : null;

        /// <summary>
        /// Checks to see if the AssetFormsOutput property is set.
        /// </summary>
        internal bool IsSetAssetFormsOutput() => this.AssetFormsOutput != null && (this.AssetFormsOutput.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the data source that is deleted.
        /// </para>
        /// </summary>
        public DataSourceConfigurationOutput Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection that is deleted.
        /// </para>
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when this data source was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data source that is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which the data source is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EnableSetting. 
        /// <para>
        /// The enable setting of the data source that specifies whether the data source is enabled
        /// or disabled.
        /// </para>
        /// </summary>
        public EnableSetting EnableSetting { get; set; }

        /// <summary>
        /// Checks to see if the EnableSetting property is set.
        /// </summary>
        internal bool IsSetEnableSetting() => this.EnableSetting != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environemnt associated with this data source.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Specifies the error message that is returned if the operation cannot be successfully
        /// completed.
        /// </para>
        /// </summary>
        public DataSourceErrorMessage ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the data source that is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastRunAt. 
        /// <para>
        /// The timestamp of when the data source was last run.
        /// </para>
        /// </summary>
        public DateTime? LastRunAt { get; set; }

        /// <summary>
        /// Checks to see if the LastRunAt property is set.
        /// </summary>
        internal bool IsSetLastRunAt() => this.LastRunAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastRunErrorMessage. 
        /// <para>
        /// Specifies the error message that is returned if the operation cannot be successfully
        /// completed.
        /// </para>
        /// </summary>
        public DataSourceErrorMessage LastRunErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastRunErrorMessage property is set.
        /// </summary>
        internal bool IsSetLastRunErrorMessage() => this.LastRunErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LastRunStatus. 
        /// <para>
        /// The status of the last run of this data source.
        /// </para>
        /// </summary>
        public DataSourceRunStatus LastRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastRunStatus property is set.
        /// </summary>
        internal bool IsSetLastRunStatus() => this.LastRunStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source that is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project in which this data source exists and from which it's deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectId { get; set; }

        /// <summary>
        /// Checks to see if the ProjectId property is set.
        /// </summary>
        internal bool IsSetProjectId() => this.ProjectId != null;

        /// <summary>
        /// Gets and sets the property PublishOnImport. 
        /// <para>
        /// Specifies whether the assets that this data source creates in the inventory are to
        /// be also automatically published to the catalog.
        /// </para>
        /// </summary>
        public bool? PublishOnImport { get; set; }

        /// <summary>
        /// Checks to see if the PublishOnImport property is set.
        /// </summary>
        internal bool IsSetPublishOnImport() => this.PublishOnImport.HasValue;

        /// <summary>
        /// Gets and sets the property RetainPermissionsOnRevokeFailure. 
        /// <para>
        /// Specifies that the granted permissions are retained in case of a self-subscribe functionality
        /// failure for a data source.
        /// </para>
        /// </summary>
        public bool? RetainPermissionsOnRevokeFailure { get; set; }

        /// <summary>
        /// Checks to see if the RetainPermissionsOnRevokeFailure property is set.
        /// </summary>
        internal bool IsSetRetainPermissionsOnRevokeFailure() => this.RetainPermissionsOnRevokeFailure.HasValue;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of runs for this data source.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ScheduleConfiguration Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SelfGrantStatus. 
        /// <para>
        /// Specifies the status of the self-granting functionality.
        /// </para>
        /// </summary>
        public SelfGrantStatusOutput SelfGrantStatus { get; set; }

        /// <summary>
        /// Checks to see if the SelfGrantStatus property is set.
        /// </summary>
        internal bool IsSetSelfGrantStatus() => this.SelfGrantStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this data source.
        /// </para>
        /// </summary>
        public DataSourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when this data source was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
