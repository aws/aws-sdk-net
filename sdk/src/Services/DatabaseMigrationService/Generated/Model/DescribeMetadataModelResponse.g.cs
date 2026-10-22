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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeMetadataModel operation.
    /// </summary>
    public partial class DescribeMetadataModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The SQL text of the metadata model. This field might not be populated for some metadata
        /// models.
        /// </para>
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property MetadataModelName. 
        /// <para>
        /// The name of the metadata model.
        /// </para>
        /// </summary>
        public string MetadataModelName { get; set; }

        /// <summary>
        /// Checks to see if the MetadataModelName property is set.
        /// </summary>
        internal bool IsSetMetadataModelName() => this.MetadataModelName != null;

        /// <summary>
        /// Gets and sets the property MetadataModelType. 
        /// <para>
        /// The type of the metadata model.
        /// </para>
        /// </summary>
        public string MetadataModelType { get; set; }

        /// <summary>
        /// Checks to see if the MetadataModelType property is set.
        /// </summary>
        internal bool IsSetMetadataModelType() => this.MetadataModelType != null;

        /// <summary>
        /// Gets and sets the property TargetMetadataModels. 
        /// <para>
        /// A list of counterpart metadata models in the target. This field is populated only
        /// when Origin is SOURCE and after the object has been converted by DMS Schema Conversion.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetadataModelReference> TargetMetadataModels { get; set; } = AWSConfigs.InitializeCollections ? new List<MetadataModelReference>() : null;

        /// <summary>
        /// Checks to see if the TargetMetadataModels property is set.
        /// </summary>
        internal bool IsSetTargetMetadataModels() => this.TargetMetadataModels != null && (this.TargetMetadataModels.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
