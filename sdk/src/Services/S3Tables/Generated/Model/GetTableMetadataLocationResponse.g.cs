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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// This is the response object from the GetTableMetadataLocation operation.
    /// </summary>
    public partial class GetTableMetadataLocationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MetadataLocation. 
        /// <para>
        /// The metadata location.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string MetadataLocation { get; set; }

        /// <summary>
        /// Checks to see if the MetadataLocation property is set.
        /// </summary>
        internal bool IsSetMetadataLocation() => this.MetadataLocation != null;

        /// <summary>
        /// Gets and sets the property VersionToken. 
        /// <para>
        /// The version token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string VersionToken { get; set; }

        /// <summary>
        /// Checks to see if the VersionToken property is set.
        /// </summary>
        internal bool IsSetVersionToken() => this.VersionToken != null;

        /// <summary>
        /// Gets and sets the property WarehouseLocation. 
        /// <para>
        /// The warehouse location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string WarehouseLocation { get; set; }

        /// <summary>
        /// Checks to see if the WarehouseLocation property is set.
        /// </summary>
        internal bool IsSetWarehouseLocation() => this.WarehouseLocation != null;
    }
}
