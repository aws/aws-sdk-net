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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// A <code>DatasetAction</code> object that specifies how data set contents are automatically
    /// created.
    /// </summary>
    public partial class DatasetAction
    {
        private string _actionName;
        private ContainerDatasetAction _containerAction;
        private SqlQueryDatasetAction _queryAction;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the data set action by which data set contents are automatically created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerAction. 
        /// <para>
        /// Information that allows the system to run a containerized application to create the
        /// dataset contents. The application must be in a Docker container along with any required
        /// support libraries.
        /// </para>
        /// </summary>
        public ContainerDatasetAction ContainerAction
        {
            get { return this._containerAction; }
            set { this._containerAction = value; }
        }

        // Check to see if ContainerAction property is set
        internal bool IsSetContainerAction()
        {
            return this._containerAction != null;
        }

        /// <summary>
        /// Gets and sets the property QueryAction. 
        /// <para>
        /// An <code>SqlQueryDatasetAction</code> object that uses an SQL query to automatically
        /// create data set contents.
        /// </para>
        /// </summary>
        public SqlQueryDatasetAction QueryAction
        {
            get { return this._queryAction; }
            set { this._queryAction = value; }
        }

        // Check to see if QueryAction property is set
        internal bool IsSetQueryAction()
        {
            return this._queryAction != null;
        }

    }
}