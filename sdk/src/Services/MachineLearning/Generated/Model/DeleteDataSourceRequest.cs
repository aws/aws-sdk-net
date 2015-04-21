/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDataSource operation.
    /// Assigns the DELETED status to a <code>DataSource</code>, rendering it unusable.
    /// 
    ///  
    /// <para>
    /// After using the <code>DeleteDataSource</code> operation, you can use the <a>GetDataSource</a>
    /// operation to verify that the status of the <code>DataSource</code> changed to DELETED.
    /// </para>
    ///  <caution><title>Caution</title> 
    /// <para>
    /// The results of the <code>DeleteDataSource</code> operation are irreversible.
    /// </para>
    /// </caution>
    /// </summary>
    public partial class DeleteDataSourceRequest : AmazonMachineLearningRequest
    {
        private string _dataSourceId;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// A user-supplied ID that uniquely identifies the <code>DataSource</code>.
        /// </para>
        /// </summary>
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

    }
}