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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the DescribeDirectoryDataAccess operation.
    /// </summary>
    public partial class DescribeDirectoryDataAccessResponse : AmazonWebServiceResponse
    {
        private DataAccessStatus _dataAccessStatus;

        /// <summary>
        /// Gets and sets the property DataAccessStatus. 
        /// <para>
        /// The current status of data access through the Directory Service Data API.
        /// </para>
        /// </summary>
        public DataAccessStatus DataAccessStatus
        {
            get { return this._dataAccessStatus; }
            set { this._dataAccessStatus = value; }
        }

        // Check to see if DataAccessStatus property is set
        internal bool IsSetDataAccessStatus()
        {
            return this._dataAccessStatus != null;
        }

    }
}