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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains granular access control configuration for security profiles, including data
    /// table access permissions.
    /// </summary>
    public partial class GranularAccessControlConfiguration
    {
        private DataTableAccessControlConfiguration _dataTableAccessControlConfiguration;

        /// <summary>
        /// Gets and sets the property DataTableAccessControlConfiguration. 
        /// <para>
        /// The access control configuration for data tables.
        /// </para>
        /// </summary>
        public DataTableAccessControlConfiguration DataTableAccessControlConfiguration
        {
            get { return this._dataTableAccessControlConfiguration; }
            set { this._dataTableAccessControlConfiguration = value; }
        }

        // Check to see if DataTableAccessControlConfiguration property is set
        internal bool IsSetDataTableAccessControlConfiguration()
        {
            return this._dataTableAccessControlConfiguration != null;
        }

    }
}