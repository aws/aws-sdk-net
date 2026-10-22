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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Represents a scan configuration and the connectors it applies to. Returned in the
    /// results of a <c>ListConnectorScanConfigurations</c> request.
    /// </summary>
    public partial class ConnectorScanConfigurationItem
    {
        /// <summary>
        /// Gets and sets the property AwsConfigConnectorArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Config connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AwsConfigConnectorArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsConfigConnectorArn property is set.
        /// </summary>
        internal bool IsSetAwsConfigConnectorArn() => this.AwsConfigConnectorArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorArns. 
        /// <para>
        /// The list of connector ARNs associated with this Amazon Web Services Config connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ConnectorArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectorArns property is set.
        /// </summary>
        internal bool IsSetConnectorArns() => this.ConnectorArns != null && (this.ConnectorArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanConfiguration. 
        /// <para>
        /// The scan configuration settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorScanConfiguration ScanConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScanConfiguration property is set.
        /// </summary>
        internal bool IsSetScanConfiguration() => this.ScanConfiguration != null;
    }
}
