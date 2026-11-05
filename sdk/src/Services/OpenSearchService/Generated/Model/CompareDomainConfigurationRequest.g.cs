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
    /// Container for the parameters to the CompareDomainConfiguration operation. Compares
    /// the metadata of two domains and reports where they differ. Use this operation to check
    /// that a secondary domain is configured consistently with its primary before you rely
    /// on it, because replication copies index data but does not copy domain metadata such
    /// as index templates, ingest pipelines, or security roles. <para> You choose which categories
    /// to compare. The response reports, for each category, how many items match, how many
    /// exist on only one domain, and which fields diverge. </para>
    /// </summary>
    public partial class CompareDomainConfigurationRequest : AmazonOpenSearchServiceRequest
    {
        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The metadata categories to compare. At least one is required, and only the categories
        /// you name are read and returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aliases</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>alerting_monitors</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cluster_settings</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>component_templates</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ingest_pipelines</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ism_policies</c> — index state management policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>security_action_groups</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>security_internal_users</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>security_role_mappings</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>security_roles</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>templates</c> — index templates
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The set of categories grows over time, so this list is not fixed. A category the service
        /// does not recognise is rejected with the supported categories named in the error message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<string> Categories { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Categories property is set.
        /// </summary>
        internal bool IsSetCategories() => this.Categories != null && (this.Categories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceDomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain to compare from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string SourceDomainArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceDomainArn property is set.
        /// </summary>
        internal bool IsSetSourceDomainArn() => this.SourceDomainArn != null;

        /// <summary>
        /// Gets and sets the property TargetDomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain to compare against.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string TargetDomainArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetDomainArn property is set.
        /// </summary>
        internal bool IsSetTargetDomainArn() => this.TargetDomainArn != null;
    }
}
