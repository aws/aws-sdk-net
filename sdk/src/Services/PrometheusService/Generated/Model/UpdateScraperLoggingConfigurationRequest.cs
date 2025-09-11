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
    /// Container for the parameters to the UpdateScraperLoggingConfiguration operation.
    /// Updates the logging configuration for a Amazon Managed Service for Prometheus scraper.
    /// </summary>
    public partial class UpdateScraperLoggingConfigurationRequest : AmazonPrometheusServiceRequest
    {
        private ScraperLoggingDestination _loggingDestination;
        private List<ScraperComponent> _scraperComponents = AWSConfigs.InitializeCollections ? new List<ScraperComponent>() : null;
        private string _scraperId;

        /// <summary>
        /// Gets and sets the property LoggingDestination. 
        /// <para>
        /// The destination where scraper logs will be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScraperLoggingDestination LoggingDestination
        {
            get { return this._loggingDestination; }
            set { this._loggingDestination = value; }
        }

        // Check to see if LoggingDestination property is set
        internal bool IsSetLoggingDestination()
        {
            return this._loggingDestination != null;
        }

        /// <summary>
        /// Gets and sets the property ScraperComponents. 
        /// <para>
        /// The list of scraper components to configure for logging.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ScraperComponent> ScraperComponents
        {
            get { return this._scraperComponents; }
            set { this._scraperComponents = value; }
        }

        // Check to see if ScraperComponents property is set
        internal bool IsSetScraperComponents()
        {
            return this._scraperComponents != null && (this._scraperComponents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScraperId. 
        /// <para>
        /// The ID of the scraper whose logging configuration will be updated.
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