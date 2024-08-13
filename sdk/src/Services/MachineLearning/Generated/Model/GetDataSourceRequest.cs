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
    /// Container for the parameters to the GetDataSource operation.
    /// Returns a <c>DataSource</c> that includes metadata and data file information, as well
    /// as the current status of the <c>DataSource</c>.
    /// 
    ///  
    /// <para>
    ///  <c>GetDataSource</c> provides results in normal or verbose format. The verbose format
    /// adds the schema description and the list of files pointed to by the DataSource to
    /// the normal format.
    /// </para>
    /// </summary>
    public partial class GetDataSourceRequest : AmazonMachineLearningRequest
    {
        private string _dataSourceId;
        private bool? _verbose;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID assigned to the <c>DataSource</c> at creation.
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
        /// Gets and sets the property Verbose. 
        /// <para>
        /// Specifies whether the <c>GetDataSource</c> operation should return <c>DataSourceSchema</c>.
        /// </para>
        ///  
        /// <para>
        /// If true, <c>DataSourceSchema</c> is returned.
        /// </para>
        ///  
        /// <para>
        /// If false, <c>DataSourceSchema</c> is not returned.
        /// </para>
        /// </summary>
        public bool? Verbose
        {
            get { return this._verbose; }
            set { this._verbose = value; }
        }

        // Check to see if Verbose property is set
        internal bool IsSetVerbose()
        {
            return this._verbose.HasValue; 
        }

    }
}