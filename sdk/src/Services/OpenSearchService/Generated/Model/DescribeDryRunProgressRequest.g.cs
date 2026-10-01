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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDryRunProgress operation. Describes the
    /// progress of a pre-update dry run analysis on an Amazon OpenSearch Service domain.
    /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-configuration-changes#dryrun">Determining
    /// whether a change will cause a blue/green deployment</a>.
    /// </summary>
    public partial class DescribeDryRunProgressRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DryRunId. 
        /// <para>
        /// The unique identifier of the dry run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DryRunId { get; set; }

        /// <summary>
        /// Checks to see if the DryRunId property is set.
        /// </summary>
        internal bool IsSetDryRunId() => this.DryRunId != null;

        /// <summary>
        /// Gets and sets the property LoadDryRunConfig. 
        /// <para>
        /// Whether to include the configuration of the dry run in the response. The configuration
        /// specifies the updates that you're planning to make on the domain.
        /// </para>
        /// </summary>
        public bool? LoadDryRunConfig { get; set; }

        /// <summary>
        /// Checks to see if the LoadDryRunConfig property is set.
        /// </summary>
        internal bool IsSetLoadDryRunConfig() => this.LoadDryRunConfig.HasValue;
    }
}
