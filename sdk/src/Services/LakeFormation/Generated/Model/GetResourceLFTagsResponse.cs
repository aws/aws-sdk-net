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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// This is the response object from the GetResourceLFTags operation.
    /// </summary>
    public partial class GetResourceLFTagsResponse : AmazonWebServiceResponse
    {
        private List<LFTagPair> _lfTagOnDatabase = AWSConfigs.InitializeCollections ? new List<LFTagPair>() : null;
        private List<ColumnLFTag> _lfTagsOnColumns = AWSConfigs.InitializeCollections ? new List<ColumnLFTag>() : null;
        private List<LFTagPair> _lfTagsOnTable = AWSConfigs.InitializeCollections ? new List<LFTagPair>() : null;

        /// <summary>
        /// Gets and sets the property LFTagOnDatabase. 
        /// <para>
        /// A list of LF-tags applied to a database resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<LFTagPair> LFTagOnDatabase
        {
            get { return this._lfTagOnDatabase; }
            set { this._lfTagOnDatabase = value; }
        }

        // Check to see if LFTagOnDatabase property is set
        internal bool IsSetLFTagOnDatabase()
        {
            return this._lfTagOnDatabase != null && (this._lfTagOnDatabase.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LFTagsOnColumns. 
        /// <para>
        /// A list of LF-tags applied to a column resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ColumnLFTag> LFTagsOnColumns
        {
            get { return this._lfTagsOnColumns; }
            set { this._lfTagsOnColumns = value; }
        }

        // Check to see if LFTagsOnColumns property is set
        internal bool IsSetLFTagsOnColumns()
        {
            return this._lfTagsOnColumns != null && (this._lfTagsOnColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LFTagsOnTable. 
        /// <para>
        /// A list of LF-tags applied to a table resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<LFTagPair> LFTagsOnTable
        {
            get { return this._lfTagsOnTable; }
            set { this._lfTagsOnTable = value; }
        }

        // Check to see if LFTagsOnTable property is set
        internal bool IsSetLFTagsOnTable()
        {
            return this._lfTagsOnTable != null && (this._lfTagsOnTable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}