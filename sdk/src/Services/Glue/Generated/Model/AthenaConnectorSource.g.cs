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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a connector to an Amazon Athena data source.
    /// </summary>
    public partial class AthenaConnectorSource
    {
        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of the connection that is associated with the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property ConnectionTable. 
        /// <para>
        /// The name of the table in the data source.
        /// </para>
        /// </summary>
        public string ConnectionTable { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTable property is set.
        /// </summary>
        internal bool IsSetConnectionTable() => this.ConnectionTable != null;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection, such as marketplace.athena or custom.athena, designating a
        /// connection to an Amazon Athena data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property ConnectorName. 
        /// <para>
        /// The name of a connector that assists with accessing the data store in Glue Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorName property is set.
        /// </summary>
        internal bool IsSetConnectorName() => this.ConnectorName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputSchemas. 
        /// <para>
        /// Specifies the data schema for the custom Athena source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlueSchema> OutputSchemas { get; set; } = AWSConfigs.InitializeCollections ? new List<GlueSchema>() : null;

        /// <summary>
        /// Checks to see if the OutputSchemas property is set.
        /// </summary>
        internal bool IsSetOutputSchemas() => this.OutputSchemas != null && (this.OutputSchemas.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SchemaName. 
        /// <para>
        /// The name of the Cloudwatch log group to read from. For example, <c>/aws-glue/jobs/output</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Checks to see if the SchemaName property is set.
        /// </summary>
        internal bool IsSetSchemaName() => this.SchemaName != null;
    }
}
