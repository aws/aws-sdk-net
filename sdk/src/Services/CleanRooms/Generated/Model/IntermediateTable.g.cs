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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains the details of an intermediate table in Clean Rooms. An intermediate table
    /// stores a query definition and its materialized results within a collaboration.
    /// </summary>
    public partial class IntermediateTable
    {
        /// <summary>
        /// Gets and sets the property AnalysisRuleTypes. 
        /// <para>
        /// The types of analysis rules associated with the intermediate table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AnalysisRuleTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AnalysisRuleTypes property is set.
        /// </summary>
        internal bool IsSetAnalysisRuleTypes() => this.AnalysisRuleTypes != null && (this.AnalysisRuleTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 256)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChildResources. 
        /// <para>
        /// The child resources that depend on this intermediate table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChildResource> ChildResources { get; set; } = AWSConfigs.InitializeCollections ? new List<ChildResource>() : null;

        /// <summary>
        /// Checks to see if the ChildResources property is set.
        /// </summary>
        internal bool IsSetChildResources() => this.ChildResources != null && (this.ChildResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CollaborationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collaboration that contains the intermediate
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string CollaborationArn { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationArn property is set.
        /// </summary>
        internal bool IsSetCollaborationArn() => this.CollaborationArn != null;

        /// <summary>
        /// Gets and sets the property CollaborationId. 
        /// <para>
        /// The unique identifier of the collaboration that contains the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string CollaborationId { get; set; }

        /// <summary>
        /// Checks to see if the CollaborationId property is set.
        /// </summary>
        internal bool IsSetCollaborationId() => this.CollaborationId != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the intermediate table was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IntermediateTableVersion. 
        /// <para>
        /// The details of the currently active version of the intermediate table.
        /// </para>
        /// </summary>
        public IntermediateTableActiveVersion IntermediateTableVersion { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateTableVersion property is set.
        /// </summary>
        internal bool IsSetIntermediateTableVersion() => this.IntermediateTableVersion != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the intermediate table
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the membership that contains the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string MembershipArn { get; set; }

        /// <summary>
        /// Checks to see if the MembershipArn property is set.
        /// </summary>
        internal bool IsSetMembershipArn() => this.MembershipArn != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The unique identifier of the membership that contains the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PopulationAnalysisConfiguration. 
        /// <para>
        /// The analysis configuration that defines the query used to populate the intermediate
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PopulationAnalysisConfiguration PopulationAnalysisConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PopulationAnalysisConfiguration property is set.
        /// </summary>
        internal bool IsSetPopulationAnalysisConfiguration() => this.PopulationAnalysisConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetentionInDays. 
        /// <para>
        /// The number of days that populated data is retained before expiring.
        /// </para>
        /// </summary>
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionInDays property is set.
        /// </summary>
        internal bool IsSetRetentionInDays() => this.RetentionInDays.HasValue;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema of the intermediate table, containing column definitions. Available after
        /// the table has been successfully populated.
        /// </para>
        /// </summary>
        public IntermediateTableSchema Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the intermediate table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IntermediateTableStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the intermediate table.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TableDependencies. 
        /// <para>
        /// The list of base tables that this intermediate table depends on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntermediateTableDependency> TableDependencies { get; set; } = AWSConfigs.InitializeCollections ? new List<IntermediateTableDependency>() : null;

        /// <summary>
        /// Checks to see if the TableDependencies property is set.
        /// </summary>
        internal bool IsSetTableDependencies() => this.TableDependencies != null && (this.TableDependencies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the intermediate table was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
