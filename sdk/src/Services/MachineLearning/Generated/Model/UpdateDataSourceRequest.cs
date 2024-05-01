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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataSource operation.
    /// Updates the <c>DataSourceName</c> of a <c>DataSource</c>.
    /// 
    ///  
    /// <para>
    /// You can use the <c>GetDataSource</c> operation to view the contents of the updated
    /// data element.
    /// </para>
    /// </summary>
    public partial class UpdateDataSourceRequest : AmazonMachineLearningRequest
    {
        private string _dataSourceId;
        private string _dataSourceName;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID assigned to the <c>DataSource</c> during creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property DataSourceName. 
        /// <para>
        /// A new user-supplied name or description of the <c>DataSource</c> that will replace
        /// the current description. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string DataSourceName
        {
            get { return this._dataSourceName; }
            set { this._dataSourceName = value; }
        }

        // Check to see if DataSourceName property is set
        internal bool IsSetDataSourceName()
        {
            return this._dataSourceName != null;
        }

    }
}