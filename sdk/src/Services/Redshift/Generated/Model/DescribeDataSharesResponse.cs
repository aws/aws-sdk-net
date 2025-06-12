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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the DescribeDataShares operation.
    /// </summary>
    public partial class DescribeDataSharesResponse : AmazonWebServiceResponse
    {
        private List<DataShare> _dataShares = AWSConfigs.InitializeCollections ? new List<DataShare>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property DataShares. 
        /// <para>
        /// The results returned from describing datashares.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataShare> DataShares
        {
            get { return this._dataShares; }
            set { this._dataShares = value; }
        }

        // Check to see if DataShares property is set
        internal bool IsSetDataShares()
        {
            return this._dataShares != null && (this._dataShares.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional parameter that specifies the starting point to return a set of response
        /// records. When the results of a <a>DescribeDataShares</a> request exceed the value
        /// specified in <c>MaxRecords</c>, Amazon Web Services returns a value in the <c>Marker</c>
        /// field of the response. You can retrieve the next set of response records by providing
        /// the returned marker value in the <c>Marker</c> parameter and retrying the request.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}