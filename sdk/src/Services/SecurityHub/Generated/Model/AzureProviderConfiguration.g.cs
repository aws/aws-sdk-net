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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The configuration for connecting to an Azure environment.
    /// </summary>
    public partial class AzureProviderConfiguration
    {
        /// <summary>
        /// Gets and sets the property AWSConfigConnectorArn. 
        /// <para>
        /// The ARN of the multi-cloud configuration connector used to establish the connection
        /// to Azure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AWSConfigConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the AWSConfigConnectorArn property is set.
        /// </summary>
        internal bool IsSetAWSConfigConnectorArn() => this.AWSConfigConnectorArn != null;

        /// <summary>
        /// Gets and sets the property AzureRegions. 
        /// <para>
        /// The list of Azure regions to monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> AzureRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AzureRegions property is set.
        /// </summary>
        internal bool IsSetAzureRegions() => this.AzureRegions != null && (this.AzureRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScopeConfiguration. 
        /// <para>
        /// The scope configuration that defines which Azure resources are monitored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AzureScopeConfiguration ScopeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScopeConfiguration property is set.
        /// </summary>
        internal bool IsSetScopeConfiguration() => this.ScopeConfiguration != null;
    }
}
