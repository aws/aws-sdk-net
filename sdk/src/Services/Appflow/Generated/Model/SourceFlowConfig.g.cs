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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Contains information about the configuration of the source connector used in the
    /// flow.
    /// </summary>
    public partial class SourceFlowConfig
    {
        /// <summary>
        /// Gets and sets the property ApiVersion. 
        /// <para>
        /// The API version of the connector when it's used as a source in the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Checks to see if the ApiVersion property is set.
        /// </summary>
        internal bool IsSetApiVersion() => this.ApiVersion != null;

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        ///  The name of the connector profile. This name must be unique for each connector profile
        /// in the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ConnectorProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorProfileName property is set.
        /// </summary>
        internal bool IsSetConnectorProfileName() => this.ConnectorProfileName != null;

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        ///  The type of connector, such as Salesforce, Amplitude, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectorType ConnectorType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorType property is set.
        /// </summary>
        internal bool IsSetConnectorType() => this.ConnectorType != null;

        /// <summary>
        /// Gets and sets the property IncrementalPullConfig. 
        /// <para>
        ///  Defines the configuration for a scheduled incremental data pull. If a valid configuration
        /// is provided, the fields specified in the configuration are used when querying for
        /// the incremental data pull. 
        /// </para>
        /// </summary>
        public IncrementalPullConfig IncrementalPullConfig { get; set; }

        /// <summary>
        /// Checks to see if the IncrementalPullConfig property is set.
        /// </summary>
        internal bool IsSetIncrementalPullConfig() => this.IncrementalPullConfig != null;

        /// <summary>
        /// Gets and sets the property SourceConnectorProperties. 
        /// <para>
        ///  Specifies the information that is required to query a particular source connector.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceConnectorProperties SourceConnectorProperties { get; set; }

        /// <summary>
        /// Checks to see if the SourceConnectorProperties property is set.
        /// </summary>
        internal bool IsSetSourceConnectorProperties() => this.SourceConnectorProperties != null;
    }
}
