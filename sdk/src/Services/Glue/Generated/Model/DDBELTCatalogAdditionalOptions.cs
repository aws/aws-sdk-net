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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// Specifies additional options for DynamoDB ELT catalog operations.
    /// </summary>
    public partial class DDBELTCatalogAdditionalOptions
    {
        private string _dynamodbExport;
        private bool? _dynamodbUnnestDDBJson;

        /// <summary>
        /// Gets and sets the property DynamodbExport. 
        /// <para>
        /// Specifies the DynamoDB export configuration for the ELT operation.
        /// </para>
        /// </summary>
        public string DynamodbExport
        {
            get { return this._dynamodbExport; }
            set { this._dynamodbExport = value; }
        }

        // Check to see if DynamodbExport property is set
        internal bool IsSetDynamodbExport()
        {
            return this._dynamodbExport != null;
        }

        /// <summary>
        /// Gets and sets the property DynamodbUnnestDDBJson. 
        /// <para>
        /// Specifies whether to unnest DynamoDB JSON format. When set to <c>true</c>, nested
        /// JSON structures in DynamoDB items are flattened.
        /// </para>
        /// </summary>
        public bool? DynamodbUnnestDDBJson
        {
            get { return this._dynamodbUnnestDDBJson; }
            set { this._dynamodbUnnestDDBJson = value; }
        }

        // Check to see if DynamodbUnnestDDBJson property is set
        internal bool IsSetDynamodbUnnestDDBJson()
        {
            return this._dynamodbUnnestDDBJson.HasValue; 
        }

    }
}