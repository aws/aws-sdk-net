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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateServiceLinkedAnalyzer operation. Creates
    /// a service-linked analyzer managed by an Amazon Web Services service. This operation
    /// can only be invoked by authorized Amazon Web Services services. Direct customer invocation
    /// returns <c>AccessDeniedException</c>. <para> Service-linked analyzers enable Amazon
    /// Web Services services to create and manage analyzers on behalf of customers. The lifecycle
    /// of these analyzers is managed by the calling service. </para>
    /// </summary>
    public partial class CreateServiceLinkedAnalyzerRequest : AmazonAccessAnalyzerRequest
    {
        /// <summary>
        /// Gets and sets the property ArchiveRules. 
        /// <para>
        /// Specifies the archive rules to add for the analyzer. Archive rules automatically archive
        /// findings that meet the criteria you define for the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InlineArchiveRule> ArchiveRules { get; set; } = AWSConfigs.InitializeCollections ? new List<InlineArchiveRule>() : null;

        /// <summary>
        /// Checks to see if the ArchiveRules property is set.
        /// </summary>
        internal bool IsSetArchiveRules() => this.ArchiveRules != null && (this.ArchiveRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client token.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies the configuration of the analyzer. The specified scope of unused access
        /// is used for the configuration.
        /// </para>
        /// </summary>
        public AnalyzerConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of analyzer to create. Valid values are <c>ACCOUNT_UNUSED_ACCESS</c> and
        /// <c>ORGANIZATION_UNUSED_ACCESS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
