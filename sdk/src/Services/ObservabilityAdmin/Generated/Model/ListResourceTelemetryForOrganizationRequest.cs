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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
        private List<string> _accountIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceIdentifierPrefix;
        private Dictionary<string, string> _resourceTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _telemetryConfigurationState = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccountIdentifiers. 
        /// <para>
        ///  A list of Amazon Web Services accounts used to filter the resources to those associated
        /// with the specified accounts. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> AccountIdentifiers
        {
            get { return this._accountIdentifiers; }
            set { this._accountIdentifiers = value; }
        }

        // Check to see if AccountIdentifiers property is set
        internal bool IsSetAccountIdentifiers()
        {
            return this._accountIdentifiers != null && (this._accountIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  A number field used to limit the number of results within the returned list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of items to return. A previous call provides this token.
        /// 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifierPrefix. 
        /// <para>
        ///  A string used to filter resources in the organization which have a <c>ResourceIdentifier</c>
        /// starting with the <c>ResourceIdentifierPrefix</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=768)]
        public string ResourceIdentifierPrefix
        {
            get { return this._resourceIdentifierPrefix; }
            set { this._resourceIdentifierPrefix = value; }
        }

        // Check to see if ResourceIdentifierPrefix property is set
        internal bool IsSetResourceIdentifierPrefix()
        {
            return this._resourceIdentifierPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        ///  A key-value pair to filter resources in the organization based on tags associated
        /// with the resource. Fore more information about tags, see <a href="https://docs.aws.amazon.com/whitepapers/latest/tagging-best-practices/what-are-tags.html">What
        /// are tags?</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        ///  A list of resource types used to filter resources in the organization. If this parameter
        /// is provided, the resources will be returned in the same order used in the request.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TelemetryConfigurationState. 
        /// <para>
        ///  A key-value pair to filter resources in the organization based on the telemetry type
        /// and the state of the telemetry configuration. The key is the telemetry type and the
        /// value is the state. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> TelemetryConfigurationState
        {
            get { return this._telemetryConfigurationState; }
            set { this._telemetryConfigurationState = value; }
        }

        // Check to see if TelemetryConfigurationState property is set
        internal bool IsSetTelemetryConfigurationState()
        {
            return this._telemetryConfigurationState != null && (this._telemetryConfigurationState.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}