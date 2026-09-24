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

namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// Container for the parameters to the ListConfigurations operation. Returns configurations
    /// deployed by Quick Setup in the requesting Amazon Web Services account and Amazon Web
    /// Services Region.
    /// </summary>
    public partial class ListConfigurationsRequest : AmazonSSMQuickSetupRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationDefinitionId. 
        /// <para>
        /// The ID of the configuration definition.
        /// </para>
        /// </summary>
        public string ConfigurationDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationDefinitionId property is set.
        /// </summary>
        internal bool IsSetConfigurationDefinitionId() => this.ConfigurationDefinitionId != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the results returned by the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManagerArn. 
        /// <para>
        /// The ARN of the configuration manager.
        /// </para>
        /// </summary>
        public string ManagerArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagerArn property is set.
        /// </summary>
        internal bool IsSetManagerArn() => this.ManagerArn != null;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Specifies the maximum number of configurations that are returned by the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property StartingToken. 
        /// <para>
        /// The token to use when requesting a specific set of items from a list.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string StartingToken { get; set; }

        /// <summary>
        /// Checks to see if the StartingToken property is set.
        /// </summary>
        internal bool IsSetStartingToken() => this.StartingToken != null;
    }
}
