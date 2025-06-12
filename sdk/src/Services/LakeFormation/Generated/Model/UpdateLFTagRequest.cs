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
    /// Container for the parameters to the UpdateLFTag operation.
    /// Updates the list of possible values for the specified LF-tag key. If the LF-tag does
    /// not exist, the operation throws an EntityNotFoundException. The values in the delete
    /// key values will be deleted from list of possible values. If any value in the delete
    /// key values is attached to a resource, then API errors out with a 400 Exception - "Update
    /// not allowed". Untag the attribute before deleting the LF-tag key's value.
    /// </summary>
    public partial class UpdateLFTagRequest : AmazonLakeFormationRequest
    {
        private string _catalogId;
        private string _tagKey;
        private List<string> _tagValuesToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _tagValuesToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your Lake Formation environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The key-name for the LF-tag for which to add or delete values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

        /// <summary>
        /// Gets and sets the property TagValuesToAdd. 
        /// <para>
        /// A list of LF-tag values to add from the LF-tag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> TagValuesToAdd
        {
            get { return this._tagValuesToAdd; }
            set { this._tagValuesToAdd = value; }
        }

        // Check to see if TagValuesToAdd property is set
        internal bool IsSetTagValuesToAdd()
        {
            return this._tagValuesToAdd != null && (this._tagValuesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagValuesToDelete. 
        /// <para>
        /// A list of LF-tag values to delete from the LF-tag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> TagValuesToDelete
        {
            get { return this._tagValuesToDelete; }
            set { this._tagValuesToDelete = value; }
        }

        // Check to see if TagValuesToDelete property is set
        internal bool IsSetTagValuesToDelete()
        {
            return this._tagValuesToDelete != null && (this._tagValuesToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}