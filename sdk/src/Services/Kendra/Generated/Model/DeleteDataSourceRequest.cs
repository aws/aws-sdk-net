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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDataSource operation.
    /// Deletes an Amazon Kendra data source connector. An exception is not thrown if the
    /// data source is already being deleted. While the data source is being deleted, the
    /// <c>Status</c> field returned by a call to the <c>DescribeDataSource</c> API is set
    /// to <c>DELETING</c>. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/delete-data-source.html">Deleting
    /// Data Sources</a>.
    /// 
    ///  
    /// <para>
    /// Deleting an entire data source or re-syncing your index after deleting specific documents
    /// from a data source could take up to an hour or more, depending on the number of documents
    /// you want to delete.
    /// </para>
    /// </summary>
    public partial class DeleteDataSourceRequest : AmazonKendraRequest
    {
        private string _id;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the data source connector you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index used with the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

    }
}