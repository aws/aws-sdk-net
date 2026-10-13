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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIntegration operation. Modifies a Zero-ETL
    /// integration in the caller's account.
    /// </summary>
    public partial class ModifyIntegrationRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property DataFilter. 
        /// <para>
        /// Selects source tables for the integration using Maxwell filter syntax.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DataFilter { get; set; }

        /// <summary>
        /// Checks to see if the DataFilter property is set.
        /// </summary>
        internal bool IsSetDataFilter() => this.DataFilter != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IntegrationConfig. 
        /// <para>
        /// The configuration settings for the integration. Currently, only the RefreshInterval
        /// can be modified. 
        /// </para>
        /// </summary>
        public IntegrationConfig IntegrationConfig { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationConfig property is set.
        /// </summary>
        internal bool IsSetIntegrationConfig() => this.IntegrationConfig != null;

        /// <summary>
        /// Gets and sets the property IntegrationIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string IntegrationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationIdentifier property is set.
        /// </summary>
        internal bool IsSetIntegrationIdentifier() => this.IntegrationIdentifier != null;

        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// A unique name for an integration in Glue.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IntegrationName { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationName property is set.
        /// </summary>
        internal bool IsSetIntegrationName() => this.IntegrationName != null;
    }
}
