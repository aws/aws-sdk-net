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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// This is the response object from the GetTableRestoreStatus operation.
    /// </summary>
    public partial class GetTableRestoreStatusResponse : AmazonWebServiceResponse
    {
        private TableRestoreStatus _tableRestoreStatus;

        /// <summary>
        /// Gets and sets the property TableRestoreStatus. 
        /// <para>
        /// The returned <code>TableRestoreStatus</code> object that contains information about
        /// the status of your <code>RestoreTableFromSnapshot</code> request.
        /// </para>
        /// </summary>
        public TableRestoreStatus TableRestoreStatus
        {
            get { return this._tableRestoreStatus; }
            set { this._tableRestoreStatus = value; }
        }

        // Check to see if TableRestoreStatus property is set
        internal bool IsSetTableRestoreStatus()
        {
            return this._tableRestoreStatus != null;
        }

    }
}