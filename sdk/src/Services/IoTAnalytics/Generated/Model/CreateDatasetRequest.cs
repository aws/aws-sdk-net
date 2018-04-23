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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataset operation.
    /// Creates a data set. A data set stores data retrieved from a data store by applying
    /// an SQL action.
    /// 
    ///  <note> 
    /// <para>
    /// This operation creates the skeleton of a data set. To populate the data set, call
    /// "CreateDatasetContent".
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateDatasetRequest : AmazonIoTAnalyticsRequest
    {
        private List<DatasetAction> _actions = new List<DatasetAction>();
        private string _datasetName;
        private List<DatasetTrigger> _triggers = new List<DatasetTrigger>();

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of actions that create the data set. Only one action is supported at this time.
        /// </para>
        /// </summary>
        public List<DatasetAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the data set.
        /// </para>
        /// </summary>
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// A list of triggers. A trigger causes data set content to be populated at a specified
        /// time or time interval. The list of triggers can be empty or contain up to five <b>DataSetTrigger</b>
        /// objects.
        /// </para>
        /// </summary>
        public List<DatasetTrigger> Triggers
        {
            get { return this._triggers; }
            set { this._triggers = value; }
        }

        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this._triggers != null && this._triggers.Count > 0; 
        }

    }
}