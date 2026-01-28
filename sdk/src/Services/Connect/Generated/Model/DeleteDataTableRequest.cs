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
    /// Container for the parameters to the DeleteDataTable operation.
    /// Deletes a data table and all associated attributes, versions, audits, and values.
    /// Does not update any references to the data table, even from other data tables. This
    /// includes dynamic values and conditional validations. System managed data tables are
    /// not deletable by customers. API users may delete the table at any time. When deletion
    /// is requested from the admin website, a warning is shown alerting the user of the most
    /// recent time the table and its values were accessed.
    /// </summary>
    public partial class DeleteDataTableRequest : AmazonConnectRequest
    {
        private string _dataTableId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier for the data table to delete. Must also accept the table ARN.
        /// Fails with an error if the version is provided and is not $LATEST.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DataTableId
        {
            get { return this._dataTableId; }
            set { this._dataTableId = value; }
        }

        // Check to see if DataTableId property is set
        internal bool IsSetDataTableId()
        {
            return this._dataTableId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}