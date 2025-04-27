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
    /// Container for the parameters to the UpdateScraper operation.
    /// Updates an existing scraper.
    /// 
    ///  
    /// <para>
    /// You can't use this function to update the source from which the scraper is collecting
    /// metrics. To change the source, delete the scraper and create a new one.
    /// </para>
    /// </summary>
    public partial class UpdateScraperRequest : AmazonPrometheusServiceRequest
    {
        private string _alias;
        private string _clientToken;
        private Destination _destination;
        private RoleConfiguration _roleConfiguration;
        private ScrapeConfiguration _scrapeConfiguration;
        private string _scraperId;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The new alias of the scraper.
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
        /// A unique identifier that you can provide to ensure the idempotency of the request.
        /// Case-sensitive.
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
        /// The new Amazon Managed Service for Prometheus workspace to send metrics to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RoleConfiguration. 
        /// <para>
        /// Use this structure to enable cross-account access, so that you can use a target account
        /// to access Prometheus metrics from source accounts.
        /// </para>
        /// </summary>
        public RoleConfiguration RoleConfiguration
        {
            get { return this._roleConfiguration; }
            set { this._roleConfiguration = value; }
        }

        // Check to see if RoleConfiguration property is set
        internal bool IsSetRoleConfiguration()
        {
            return this._roleConfiguration != null;
        }

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
        /// Gets and sets the property ScraperId. 
        /// <para>
        /// The ID of the scraper to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ScraperId
        {
            get { return this._scraperId; }
            set { this._scraperId = value; }
        }

        // Check to see if ScraperId property is set
        internal bool IsSetScraperId()
        {
            return this._scraperId != null;
        }

    }
}