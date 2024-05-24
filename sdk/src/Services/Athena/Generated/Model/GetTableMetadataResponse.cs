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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the GetTableMetadata operation.
    /// </summary>
    public partial class GetTableMetadataResponse : AmazonWebServiceResponse
    {
        private TableMetadata _tableMetadata;

        /// <summary>
        /// Gets and sets the property TableMetadata. 
        /// <para>
        /// An object that contains table metadata.
        /// </para>
        /// </summary>
        public TableMetadata TableMetadata
        {
            get { return this._tableMetadata; }
            set { this._tableMetadata = value; }
        }

        // Check to see if TableMetadata property is set
        internal bool IsSetTableMetadata()
        {
            return this._tableMetadata != null;
        }

    }
}