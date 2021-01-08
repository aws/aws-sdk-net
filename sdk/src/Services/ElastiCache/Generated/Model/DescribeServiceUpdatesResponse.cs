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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// This is the response object from the DescribeServiceUpdates operation.
    /// </summary>
    public partial class DescribeServiceUpdatesResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ServiceUpdate> _serviceUpdates = new List<ServiceUpdate>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <code>MaxRecords</code>.
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

        /// <summary>
        /// Gets and sets the property ServiceUpdates. 
        /// <para>
        /// A list of service updates
        /// </para>
        /// </summary>
        public List<ServiceUpdate> ServiceUpdates
        {
            get { return this._serviceUpdates; }
            set { this._serviceUpdates = value; }
        }

        // Check to see if ServiceUpdates property is set
        internal bool IsSetServiceUpdates()
        {
            return this._serviceUpdates != null && this._serviceUpdates.Count > 0; 
        }

    }
}