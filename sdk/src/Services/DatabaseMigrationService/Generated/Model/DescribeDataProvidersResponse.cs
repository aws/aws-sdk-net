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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeDataProviders operation.
    /// </summary>
    public partial class DescribeDataProvidersResponse : AmazonWebServiceResponse
    {
        private List<DataProvider> _dataProviders = AWSConfigs.InitializeCollections ? new List<DataProvider>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property DataProviders. 
        /// <para>
        /// A description of data providers.
        /// </para>
        /// </summary>
        public List<DataProvider> DataProviders
        {
            get { return this._dataProviders; }
            set { this._dataProviders = value; }
        }

        // Check to see if DataProviders property is set
        internal bool IsSetDataProviders()
        {
            return this._dataProviders != null && (this._dataProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Specifies the unique pagination token that makes it possible to display the next page
        /// of results. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by <c>MaxRecords</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>Marker</c> is returned by a previous response, there are more results available.
        /// The value of <c>Marker</c> is a unique pagination token for each page. To retrieve
        /// the next page, make the call again using the returned token and keeping all other
        /// arguments unchanged.
        /// </para>
        /// </summary>
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