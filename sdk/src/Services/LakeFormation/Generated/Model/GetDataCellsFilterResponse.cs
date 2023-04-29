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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// This is the response object from the GetDataCellsFilter operation.
    /// </summary>
    public partial class GetDataCellsFilterResponse : AmazonWebServiceResponse
    {
        private DataCellsFilter _dataCellsFilter;

        /// <summary>
        /// Gets and sets the property DataCellsFilter. 
        /// <para>
        /// A structure that describes certain columns on certain rows.
        /// </para>
        /// </summary>
        public DataCellsFilter DataCellsFilter
        {
            get { return this._dataCellsFilter; }
            set { this._dataCellsFilter = value; }
        }

        // Check to see if DataCellsFilter property is set
        internal bool IsSetDataCellsFilter()
        {
            return this._dataCellsFilter != null;
        }

    }
}