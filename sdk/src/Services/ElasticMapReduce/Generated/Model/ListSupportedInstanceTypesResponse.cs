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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the ListSupportedInstanceTypes operation.
    /// </summary>
    public partial class ListSupportedInstanceTypesResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<SupportedInstanceType> _supportedInstanceTypes = new List<SupportedInstanceType>();

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that marks the next set of results to retrieve.
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
        /// Gets and sets the property SupportedInstanceTypes. 
        /// <para>
        /// The list of instance types that the release specified in <code>ListSupportedInstanceTypesInput$ReleaseLabel</code>
        /// supports, filtered by Amazon Web Services Region.
        /// </para>
        /// </summary>
        public List<SupportedInstanceType> SupportedInstanceTypes
        {
            get { return this._supportedInstanceTypes; }
            set { this._supportedInstanceTypes = value; }
        }

        // Check to see if SupportedInstanceTypes property is set
        internal bool IsSetSupportedInstanceTypes()
        {
            return this._supportedInstanceTypes != null && this._supportedInstanceTypes.Count > 0; 
        }

    }
}