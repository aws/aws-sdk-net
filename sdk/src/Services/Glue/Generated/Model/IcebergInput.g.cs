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
    /// A structure that defines an Apache Iceberg metadata table to create in the catalog.
    /// </summary>
    public partial class IcebergInput
    {
        /// <summary>
        /// Gets and sets the property CreateIcebergTableInput. 
        /// <para>
        /// The configuration parameters required to create a new Iceberg table in the Glue Data
        /// Catalog, including table properties and metadata specifications.
        /// </para>
        /// </summary>
        public CreateIcebergTableInput CreateIcebergTableInput { get; set; }

        /// <summary>
        /// Checks to see if the CreateIcebergTableInput property is set.
        /// </summary>
        internal bool IsSetCreateIcebergTableInput() => this.CreateIcebergTableInput != null;

        /// <summary>
        /// Gets and sets the property MetadataOperation. 
        /// <para>
        /// A required metadata operation. Can only be set to <c>CREATE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetadataOperation MetadataOperation { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOperation property is set.
        /// </summary>
        internal bool IsSetMetadataOperation() => this.MetadataOperation != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The table version for the Iceberg table. Defaults to 2.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
