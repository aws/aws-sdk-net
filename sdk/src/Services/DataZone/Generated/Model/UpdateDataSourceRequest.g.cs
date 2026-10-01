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
    /// Container for the parameters to the UpdateDataSource operation. Updates the specified
    /// data source in Amazon DataZone.
    /// </summary>
    public partial class UpdateDataSourceRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AssetFormsInput. 
        /// <para>
        /// The asset forms to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 10)]
        public List<FormInput> AssetFormsInput { get; set; } = AWSConfigs.InitializeCollections ? new List<FormInput>() : null;

        /// <summary>
        /// Checks to see if the AssetFormsInput property is set.
        /// </summary>
        internal bool IsSetAssetFormsInput() => this.AssetFormsInput != null && (this.AssetFormsInput.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        public DataSourceConfigurationInput Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the domain in which to update a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property EnableSetting. 
        /// <para>
        /// The enable setting to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        public EnableSetting EnableSetting { get; set; }

        /// <summary>
        /// Checks to see if the EnableSetting property is set.
        /// </summary>
        internal bool IsSetEnableSetting() => this.EnableSetting != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the data source to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PublishOnImport. 
        /// <para>
        /// The publish on import setting to be updated as part of the <c>UpdateDataSource</c>
        /// action.
        /// </para>
        /// </summary>
        public bool? PublishOnImport { get; set; }

        /// <summary>
        /// Checks to see if the PublishOnImport property is set.
        /// </summary>
        internal bool IsSetPublishOnImport() => this.PublishOnImport.HasValue;

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The recommendation to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        public RecommendationConfiguration Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

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
        /// The schedule to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ScheduleConfiguration Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;
    }
}
