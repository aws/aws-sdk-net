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
    /// a "queryAction" (a SQL query) or a "containerAction" (executing a containerized application).
    /// This operation creates the skeleton of a data set. The data set can be populated manually
    /// by calling "CreateDatasetContent" or automatically according to a "trigger" you specify.
    /// </summary>
    public partial class CreateDatasetRequest : AmazonIoTAnalyticsRequest
    {
        private List<DatasetAction> _actions = new List<DatasetAction>();
        private List<DatasetContentDeliveryRule> _contentDeliveryRules = new List<DatasetContentDeliveryRule>();
        private string _datasetName;
        private RetentionPeriod _retentionPeriod;
        private List<Tag> _tags = new List<Tag>();
        private List<DatasetTrigger> _triggers = new List<DatasetTrigger>();

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of actions that create the data set contents.
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
        /// Gets and sets the property ContentDeliveryRules. 
        /// <para>
        /// When data set contents are created they are delivered to destinations specified here.
        /// </para>
        /// </summary>
        public List<DatasetContentDeliveryRule> ContentDeliveryRules
        {
            get { return this._contentDeliveryRules; }
            set { this._contentDeliveryRules = value; }
        }

        // Check to see if ContentDeliveryRules property is set
        internal bool IsSetContentDeliveryRules()
        {
            return this._contentDeliveryRules != null && this._contentDeliveryRules.Count > 0; 
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
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// [Optional] How long, in days, message data is kept for the data set. If not given
        /// or set to null, the latest version of the dataset content plus the latest succeeded
        /// version (if they are different) are retained for at most 90 days.
        /// </para>
        /// </summary>
        public RetentionPeriod RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the data set.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// A list of triggers. A trigger causes data set contents to be populated at a specified
        /// time interval or when another data set's contents are created. The list of triggers
        /// can be empty or contain up to five <b>DataSetTrigger</b> objects.
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