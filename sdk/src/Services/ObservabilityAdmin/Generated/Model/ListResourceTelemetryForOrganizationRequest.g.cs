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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the ListResourceTelemetryForOrganization operation.
    /// Returns a list of telemetry configurations for Amazon Web Services resources supported
    /// by telemetry config in the organization.
    /// </summary>
    public partial class ListResourceTelemetryForOrganizationRequest : AmazonObservabilityAdminRequest
    {
        /// <summary>
        /// Gets and sets the property AccountIdentifiers. 
        /// <para>
        ///  A list of Amazon Web Services accounts used to filter the resources to those associated
        /// with the specified accounts. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> AccountIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIdentifiers property is set.
        /// </summary>
        internal bool IsSetAccountIdentifiers() => this.AccountIdentifiers != null && (this.AccountIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  A number field used to limit the number of results within the returned list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of items to return. A previous call provides this token.
        /// 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifierPrefix. 
        /// <para>
        ///  A string used to filter resources in the organization which have a <c>ResourceIdentifier</c>
        /// starting with the <c>ResourceIdentifierPrefix</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 768)]
        public string ResourceIdentifierPrefix { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifierPrefix property is set.
        /// </summary>
        internal bool IsSetResourceIdentifierPrefix() => this.ResourceIdentifierPrefix != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        ///  A key-value pair to filter resources in the organization based on tags associated
        /// with the resource. Fore more information about tags, see <a href="https://docs.aws.amazon.com/whitepapers/latest/tagging-best-practices/what-are-tags.html">What
        /// are tags?</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        ///  A list of resource types used to filter resources in the organization. If this parameter
        /// is provided, the resources will be returned in the same order used in the request.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 9)]
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TelemetryConfigurationState. 
        /// <para>
        ///  A key-value pair to filter resources in the organization based on the telemetry type
        /// and the state of the telemetry configuration. The key is the telemetry type and the
        /// value is the state. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TelemetryConfigurationState { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TelemetryConfigurationState property is set.
        /// </summary>
        internal bool IsSetTelemetryConfigurationState() => this.TelemetryConfigurationState != null && (this.TelemetryConfigurationState.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
