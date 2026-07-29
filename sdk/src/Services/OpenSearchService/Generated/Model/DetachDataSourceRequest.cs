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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the DetachDataSource operation.
    /// Removes a data source from an OpenSearch application. The application must be in the
    /// <c>ACTIVE</c> state. This operation removes the data source saved object from the
    /// application and deletes the attachment record. Throws a <c>ConflictException</c> if
    /// the specified data source has a <c>PENDING</c> attachment, and a <c>ResourceNotFoundException</c>
    /// if the data source is not currently attached to the application.
    /// </summary>
    public partial class DetachDataSourceRequest : AmazonOpenSearchServiceRequest
    {
        private string _dataSourceArn;
        private string _id;

        /// <summary>
        /// Gets and sets the property DataSourceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier or name of the OpenSearch application to detach the data source
        /// from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}