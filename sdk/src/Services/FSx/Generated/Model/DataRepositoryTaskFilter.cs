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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// (Optional) An array of filter objects you can use to filter the response of data repository
    /// tasks you will see in the the response. You can filter the tasks returned in the response
    /// by one or more file system IDs, task lifecycles, and by task type. A filter object
    /// consists of a filter <c>Name</c>, and one or more <c>Values</c> for the filter.
    /// </summary>
    public partial class DataRepositoryTaskFilter
    {
        private DataRepositoryTaskFilterName _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the task property to use in filtering the tasks returned in the response.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>file-system-id</c> to retrieve data repository tasks for specific file systems.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>task-lifecycle</c> to retrieve data repository tasks with one or more specific
        /// lifecycle states, as follows: CANCELED, EXECUTING, FAILED, PENDING, and SUCCEEDED.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataRepositoryTaskFilterName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// Use Values to include the specific file system IDs and task lifecycle states for the
        /// filters you are using.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}