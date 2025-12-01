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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Contains classification information for data columns, including mappings that specify
    /// how columns should be handled during synthetic data generation and privacy analysis.
    /// </summary>
    public partial class ColumnClassificationDetails
    {
        private List<SyntheticDataColumnProperties> _columnMapping = AWSConfigs.InitializeCollections ? new List<SyntheticDataColumnProperties>() : null;

        /// <summary>
        /// Gets and sets the property ColumnMapping. 
        /// <para>
        /// A mapping that defines the classification of data columns for synthetic data generation
        /// and specifies how each column should be handled during the privacy-preserving data
        /// synthesis process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5)]
        public List<SyntheticDataColumnProperties> ColumnMapping
        {
            get { return this._columnMapping; }
            set { this._columnMapping = value; }
        }

        // Check to see if ColumnMapping property is set
        internal bool IsSetColumnMapping()
        {
            return this._columnMapping != null && (this._columnMapping.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}