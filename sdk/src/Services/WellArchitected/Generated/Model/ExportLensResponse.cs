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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// This is the response object from the ExportLens operation.
    /// </summary>
    public partial class ExportLensResponse : AmazonWebServiceResponse
    {
        private string _lensJSON;

        /// <summary>
        /// Gets and sets the property LensJSON. 
        /// <para>
        /// The JSON representation of a lens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=500000)]
        public string LensJSON
        {
            get { return this._lensJSON; }
            set { this._lensJSON = value; }
        }

        // Check to see if LensJSON property is set
        internal bool IsSetLensJSON()
        {
            return this._lensJSON != null;
        }

    }
}