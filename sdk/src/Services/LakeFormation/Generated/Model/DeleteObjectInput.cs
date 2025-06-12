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
    /// An object to delete from the governed table.
    /// </summary>
    public partial class DeleteObjectInput
    {
        private string _eTag;
        private List<string> _partitionValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _uri;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The Amazon S3 ETag of the object. Returned by <c>GetTableObjects</c> for validation
        /// and used to identify changes to the underlying data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionValues. 
        /// <para>
        /// A list of partition values for the object. A value must be specified for each partition
        /// key associated with the governed table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> PartitionValues
        {
            get { return this._partitionValues; }
            set { this._partitionValues = value; }
        }

        // Check to see if PartitionValues property is set
        internal bool IsSetPartitionValues()
        {
            return this._partitionValues != null && (this._partitionValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The Amazon S3 location of the object to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}