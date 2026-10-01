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
    /// Container for the parameters to the UpdateScraperLoggingConfiguration operation. Updates
    /// the logging configuration for a Amazon Managed Service for Prometheus scraper.
    /// </summary>
    public partial class UpdateScraperLoggingConfigurationRequest : AmazonPrometheusServiceRequest
    {
        /// <summary>
        /// Gets and sets the property LoggingDestination. 
        /// <para>
        /// The destination where scraper logs will be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScraperLoggingDestination LoggingDestination { get; set; }

        /// <summary>
        /// Checks to see if the LoggingDestination property is set.
        /// </summary>
        internal bool IsSetLoggingDestination() => this.LoggingDestination != null;

        /// <summary>
        /// Gets and sets the property ScraperComponents. 
        /// <para>
        /// The list of scraper components to configure for logging.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ScraperComponent> ScraperComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<ScraperComponent>() : null;

        /// <summary>
        /// Checks to see if the ScraperComponents property is set.
        /// </summary>
        internal bool IsSetScraperComponents() => this.ScraperComponents != null && (this.ScraperComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScraperId. 
        /// <para>
        /// The ID of the scraper whose logging configuration will be updated.
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
