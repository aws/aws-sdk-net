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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// This is the response object from the UpdateDataLake operation.
    /// </summary>
    public partial class UpdateDataLakeResponse : AmazonWebServiceResponse
    {
        private List<DataLakeResource> _dataLakes = new List<DataLakeResource>();

        /// <summary>
        /// Gets and sets the property DataLakes. 
        /// <para>
        /// The created Security Lake configuration object.
        /// </para>
        /// </summary>
        public List<DataLakeResource> DataLakes
        {
            get { return this._dataLakes; }
            set { this._dataLakes = value; }
        }

        // Check to see if DataLakes property is set
        internal bool IsSetDataLakes()
        {
            return this._dataLakes != null && this._dataLakes.Count > 0; 
        }

    }
}