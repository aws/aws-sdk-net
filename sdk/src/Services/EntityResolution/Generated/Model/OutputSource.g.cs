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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// A list of <c>OutputAttribute</c> objects, each of which have the fields <c>Name</c>
    /// and <c>Hashed</c>. Each of these objects selects a column to be included in the output
    /// table, and whether the values of the column should be hashed.
    /// </summary>
    public partial class OutputSource
    {
        /// <summary>
        /// Gets and sets the property ApplyNormalization. 
        /// <para>
        /// Normalizes the attributes defined in the schema in the input data. For example, if
        /// an attribute has an <c>AttributeType</c> of <c>PHONE_NUMBER</c>, and the data in the
        /// input table is in a format of 1234567890, Entity Resolution will normalize this field
        /// in the output to (123)-456-7890.
        /// </para>
        /// </summary>
        public bool? ApplyNormalization { get; set; }

        /// <summary>
        /// Checks to see if the ApplyNormalization property is set.
        /// </summary>
        internal bool IsSetApplyNormalization() => this.ApplyNormalization.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerProfilesIntegrationConfig. 
        /// <para>
        /// Specifies the Customer Profiles integration configuration for sending matched output
        /// directly to Customer Profiles. When configured, Entity Resolution automatically creates
        /// and updates customer profiles based on match clusters, eliminating the need for manual
        /// Amazon S3 integration setup.
        /// </para>
        /// </summary>
        public CustomerProfilesIntegrationConfig CustomerProfilesIntegrationConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomerProfilesIntegrationConfig property is set.
        /// </summary>
        internal bool IsSetCustomerProfilesIntegrationConfig() => this.CustomerProfilesIntegrationConfig != null;

        /// <summary>
        /// Gets and sets the property KMSArn. 
        /// <para>
        /// Customer KMS ARN for encryption at rest. If not provided, system will use an Entity
        /// Resolution managed KMS key.
        /// </para>
        /// </summary>
        public string KMSArn { get; set; }

        /// <summary>
        /// Checks to see if the KMSArn property is set.
        /// </summary>
        internal bool IsSetKMSArn() => this.KMSArn != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// A list of <c>OutputAttribute</c> objects, each of which have the fields <c>Name</c>
        /// and <c>Hashed</c>. Each of these objects selects a column to be included in the output
        /// table, and whether the values of the column should be hashed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 750)]
        public List<OutputAttribute> Output { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputAttribute>() : null;

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null && (this.Output.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutputS3Path. 
        /// <para>
        /// The S3 path to which Entity Resolution will write the output table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OutputS3Path { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Path property is set.
        /// </summary>
        internal bool IsSetOutputS3Path() => this.OutputS3Path != null;
    }
}
