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

namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScraper operation. Updates an existing scraper.
    /// <para> You can't use this function to update the source from which the scraper is
    /// collecting metrics. To change the source, delete the scraper and create a new one.
    /// </para>
    /// </summary>
    public partial class UpdateScraperRequest : AmazonPrometheusServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The new alias of the scraper.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier that you can provide to ensure the idempotency of the request.
        /// Case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The new destination where the scraper sends metrics. Valid destinations are Amazon
        /// Managed Service for Prometheus workspaces and CloudWatch datasets.
        /// </para>
        /// </summary>
        public Destination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Exporters. 
        /// <para>
        /// The exporter configurations for the scraper. You can configure at most one Amazon
        /// OpenSearch Service domain. If you don't specify a value, the existing exporter configuration
        /// remains unchanged.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<ExporterConfiguration> Exporters { get; set; } = AWSConfigs.InitializeCollections ? new List<ExporterConfiguration>() : null;

        /// <summary>
        /// Checks to see if the Exporters property is set.
        /// </summary>
        internal bool IsSetExporters() => this.Exporters != null && (this.Exporters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleConfiguration. 
        /// <para>
        /// Use this structure to enable cross-account access, so that you can use a target account
        /// to access Prometheus metrics from source accounts.
        /// </para>
        /// </summary>
        public RoleConfiguration RoleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RoleConfiguration property is set.
        /// </summary>
        internal bool IsSetRoleConfiguration() => this.RoleConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScrapeConfiguration. 
        /// <para>
        /// Contains the base-64 encoded YAML configuration for the scraper.
        /// </para>
        ///  <note> 
        /// <para>
        /// For more information about configuring a scraper, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html">Using
        /// an Amazon Web Services managed collector</a> in the <i>Amazon Managed Service for
        /// Prometheus User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public ScrapeConfiguration ScrapeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScrapeConfiguration property is set.
        /// </summary>
        internal bool IsSetScrapeConfiguration() => this.ScrapeConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScraperId. 
        /// <para>
        /// The ID of the scraper to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ScraperId { get; set; }

        /// <summary>
        /// Checks to see if the ScraperId property is set.
        /// </summary>
        internal bool IsSetScraperId() => this.ScraperId != null;
    }
}
