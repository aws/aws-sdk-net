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
    /// Container for the parameters to the CreateDataSource operation. Creates an Amazon
    /// DataZone data source.
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AssetFormsInput. 
        /// <para>
        /// The metadata forms that are to be attached to the assets that this data source works
        /// with.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that is provided to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies the configuration of the data source. It can be set to either <c>glueRunConfiguration</c>
        /// or <c>redshiftRunConfiguration</c>.
        /// </para>
        /// </summary>
        public DataSourceConfigurationInput Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ConnectionIdentifier. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        public string ConnectionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionIdentifier property is set.
        /// </summary>
        internal bool IsSetConnectionIdentifier() => this.ConnectionIdentifier != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the data source.
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
        /// The ID of the Amazon DataZone domain where the data source is created.
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
        /// Specifies whether the data source is enabled.
        /// </para>
        /// </summary>
        public EnableSetting EnableSetting { get; set; }

        /// <summary>
        /// Checks to see if the EnableSetting property is set.
        /// </summary>
        internal bool IsSetEnableSetting() => this.EnableSetting != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The unique identifier of the Amazon DataZone environment to which the data source
        /// publishes assets. 
        /// </para>
        /// </summary>
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone project in which you want to add this data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetProjectIdentifier() => this.ProjectIdentifier != null;

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
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// Specifies whether the business name generation is to be enabled for this data source.
        /// </para>
        /// </summary>
        public RecommendationConfiguration Recommendation { get; set; }

        /// <summary>
        /// Checks to see if the Recommendation property is set.
        /// </summary>
        internal bool IsSetRecommendation() => this.Recommendation != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the data source runs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ScheduleConfiguration Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source. In Amazon DataZone, you can use data sources to import
        /// technical metadata of assets (data) from the source databases or data warehouses into
        /// Amazon DataZone. In the current release of Amazon DataZone, you can create and run
        /// data sources for Amazon Web Services Glue and Amazon Redshift.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
