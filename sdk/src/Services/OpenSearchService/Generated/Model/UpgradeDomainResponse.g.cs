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
    /// This is the response object from the UpgradeDomain operation.
    /// </summary>
    public partial class UpgradeDomainResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// The advanced options configuration for the domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdvancedOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdvancedOptions property is set.
        /// </summary>
        internal bool IsSetAdvancedOptions() => this.AdvancedOptions != null && (this.AdvancedOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChangeProgressDetails. 
        /// <para>
        /// Container for information about a configuration change happening on a domain.
        /// </para>
        /// </summary>
        public ChangeProgressDetails ChangeProgressDetails { get; set; }

        /// <summary>
        /// Checks to see if the ChangeProgressDetails property is set.
        /// </summary>
        internal bool IsSetChangeProgressDetails() => this.ChangeProgressDetails != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that was upgraded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property PerformCheckOnly. 
        /// <para>
        /// When true, indicates that an upgrade eligibility check was performed.
        /// </para>
        /// </summary>
        public bool? PerformCheckOnly { get; set; }

        /// <summary>
        /// Checks to see if the PerformCheckOnly property is set.
        /// </summary>
        internal bool IsSetPerformCheckOnly() => this.PerformCheckOnly.HasValue;

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// OpenSearch or Elasticsearch version that the domain was upgraded to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 18)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion != null;

        /// <summary>
        /// Gets and sets the property UpgradeId. 
        /// <para>
        /// The unique identifier of the domain upgrade.
        /// </para>
        /// </summary>
        public string UpgradeId { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeId property is set.
        /// </summary>
        internal bool IsSetUpgradeId() => this.UpgradeId != null;
    }
}
