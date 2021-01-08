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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Options that define how Microsoft Excel input is to be interpreted by DataBrew.
    /// </summary>
    public partial class FormatOptions
    {
        private ExcelOptions _excel;
        private JsonOptions _json;

        /// <summary>
        /// Gets and sets the property Excel. 
        /// <para>
        /// Options that define how Excel input is to be interpreted by DataBrew.
        /// </para>
        /// </summary>
        public ExcelOptions Excel
        {
            get { return this._excel; }
            set { this._excel = value; }
        }

        // Check to see if Excel property is set
        internal bool IsSetExcel()
        {
            return this._excel != null;
        }

        /// <summary>
        /// Gets and sets the property Json. 
        /// <para>
        /// Options that define how JSON input is to be interpreted by DataBrew.
        /// </para>
        /// </summary>
        public JsonOptions Json
        {
            get { return this._json; }
            set { this._json = value; }
        }

        // Check to see if Json property is set
        internal bool IsSetJson()
        {
            return this._json != null;
        }

    }
}