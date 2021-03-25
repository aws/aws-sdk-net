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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// This is the response object from the GetSampleData operation.
    /// </summary>
    public partial class GetSampleDataResponse : AmazonWebServiceResponse
    {
        private List<string> _headerValues = new List<string>();
        private List<List<string>> _sampleRows = new List<List<string>>();

        /// <summary>
        /// Gets and sets the property HeaderValues. 
        /// <para>
        /// A list of header labels for the records.
        /// </para>
        /// </summary>
        public List<string> HeaderValues
        {
            get { return this._headerValues; }
            set { this._headerValues = value; }
        }

        // Check to see if HeaderValues property is set
        internal bool IsSetHeaderValues()
        {
            return this._headerValues != null && this._headerValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SampleRows. 
        /// <para>
        /// A list of records.
        /// </para>
        /// </summary>
        public List<List<string>> SampleRows
        {
            get { return this._sampleRows; }
            set { this._sampleRows = value; }
        }

        // Check to see if SampleRows property is set
        internal bool IsSetSampleRows()
        {
            return this._sampleRows != null && this._sampleRows.Count > 0; 
        }

    }
}