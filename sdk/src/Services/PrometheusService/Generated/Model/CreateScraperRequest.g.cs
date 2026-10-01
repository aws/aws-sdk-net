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
    /// Container for the parameters to the CreateScraper operation. Creates a scraper to
    /// collect metrics from Prometheus-compatible sources. The scraper sends the collected
    /// metrics to Amazon Managed Service for Prometheus workspaces or CloudWatch datasets.
    /// You can configure scrapers to collect metrics from Amazon EKS clusters, Amazon MSK
    /// clusters, or from VPC-based sources that support DNS-based service discovery. Scrapers
    /// are flexible. You can configure a scraper to control which metrics to collect, the
    /// frequency of collection, which transformations to apply to the metrics, and more.
    /// <para> An IAM role will be created for you that Amazon Managed Service for Prometheus
    /// uses to access the metrics in your source. You must configure this role with a policy
    /// that allows it to scrape metrics from your source. For Amazon EKS sources, see <a
    /// href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html#AMP-collector-eks-setup">Configuring
    /// your Amazon EKS cluster</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
    /// </para> <para> The <c>scrapeConfiguration</c> parameter contains the base-64 encoded
    /// YAML configuration for the scraper. </para> <para> When creating a scraper, the service
    /// creates a <c>Network Interface</c> in each <b>Availability Zone</b> that are passed
    /// into <c>CreateScraper</c> through subnets. These network interfaces are used to connect
    /// to your source within the VPC for scraping metrics. </para> <note> <para> For more
    /// information about collectors, including what metrics are collected, and how to configure
    /// the scraper, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html">Using
    /// an Amazon Web Services managed collector</a> in the <i>Amazon Managed Service for
    /// Prometheus User Guide</i>. </para> </note>
    /// </summary>
    public partial class CreateScraperRequest : AmazonPrometheusServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// (optional) An alias to associate with the scraper. This is for your use, and does
        /// not need to be unique.
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
        /// (Optional) A unique, case-sensitive identifier that you can provide to ensure the
        /// idempotency of the request.
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
        /// The destination where the scraper sends the collected metrics. Valid destinations
        /// are Amazon Managed Service for Prometheus workspaces and CloudWatch datasets.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Destination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property Exporters. 
        /// <para>
        /// The exporter configurations for the scraper. You can configure at most one Amazon
        /// OpenSearch Service domain. If you don't specify a value, the scraper is created without
        /// an exporter configuration.
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
        /// The configuration file to use in the new scraper. For more information, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html#AMP-collector-configuration">Scraper
        /// configuration</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScrapeConfiguration ScrapeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScrapeConfiguration property is set.
        /// </summary>
        internal bool IsSetScrapeConfiguration() => this.ScrapeConfiguration != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon EKS or Amazon Web Services cluster from which the scraper will collect
        /// metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Source Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) The list of tag keys and values to associate with the scraper.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
