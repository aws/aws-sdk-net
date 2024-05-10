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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
    /// Container for the parameters to the CreateScraper operation.
    /// The <c>CreateScraper</c> operation creates a scraper to collect metrics. A scraper
    /// pulls metrics from Prometheus-compatible sources within an Amazon EKS cluster, and
    /// sends them to your Amazon Managed Service for Prometheus workspace. You can configure
    /// the scraper to control what metrics are collected, and what transformations are applied
    /// prior to sending them to your workspace.
    /// 
    ///  
    /// <para>
    /// If needed, an IAM role will be created for you that gives Amazon Managed Service for
    /// Prometheus access to the metrics in your cluster. For more information, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/using-service-linked-roles.html#using-service-linked-roles-prom-scraper">Using
    /// roles for scraping metrics from EKS</a> in the <i>Amazon Managed Service for Prometheus
    /// User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You cannot update a scraper. If you want to change the configuration of the scraper,
    /// create a new scraper and delete the old one.
    /// </para>
    ///  
    /// <para>
    /// The <c>scrapeConfiguration</c> parameter contains the base64-encoded version of the
    /// YAML configuration file.
    /// </para>
    ///  <note> 
    /// <para>
    /// For more information about collectors, including what metrics are collected, and how
    /// to configure the scraper, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector.html">Amazon
    /// Web Services managed collectors</a> in the <i>Amazon Managed Service for Prometheus
    /// User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateScraperRequest : AmazonPrometheusServiceRequest
    {
        private string _alias;
        private string _clientToken;
        private Destination _destination;
        private ScrapeConfiguration _scrapeConfiguration;
        private Source _source;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// (optional) a name to associate with the scraper. This is for your use, and does not
        /// need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// (Optional) A unique, case-sensitive identifier that you can provide to ensure the
        /// idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon Managed Service for Prometheus workspace to send metrics to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property ScrapeConfiguration. 
        /// <para>
        /// The configuration file to use in the new scraper. For more information, see <a href="prometheus/latest/userguide/AMP-collector-how-to.html#AMP-collector-configuration">Scraper
        /// configuration</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScrapeConfiguration ScrapeConfiguration
        {
            get { return this._scrapeConfiguration; }
            set { this._scrapeConfiguration = value; }
        }

        // Check to see if ScrapeConfiguration property is set
        internal bool IsSetScrapeConfiguration()
        {
            return this._scrapeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon EKS cluster from which the scraper will collect metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) The list of tag keys and values to associate with the scraper.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}