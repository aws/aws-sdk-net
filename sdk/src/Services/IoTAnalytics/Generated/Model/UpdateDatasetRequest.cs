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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataset operation.
    /// Updates the settings of a data set.
    /// </summary>
    public partial class UpdateDatasetRequest : AmazonIoTAnalyticsRequest
    {
        private List<DatasetAction> _actions = new List<DatasetAction>();
        private List<DatasetContentDeliveryRule> _contentDeliveryRules = new List<DatasetContentDeliveryRule>();
        private string _datasetName;
        private RetentionPeriod _retentionPeriod;
        private List<DatasetTrigger> _triggers = new List<DatasetTrigger>();
        private VersioningConfiguration _versioningConfiguration;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of "DatasetAction" objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
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
        [AWSProperty(Min=0, Max=20)]
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
        /// The name of the data set to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// How long, in days, data set contents are kept for the data set.
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
        /// Gets and sets the property Triggers. 
        /// <para>
        /// A list of "DatasetTrigger" objects. The list can be empty or can contain up to five
        /// <b>DataSetTrigger</b> objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
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

        /// <summary>
        /// Gets and sets the property VersioningConfiguration. 
        /// <para>
        /// [Optional] How many versions of data set contents are kept. If not specified or set
        /// to null, only the latest version plus the latest succeeded version (if they are different)
        /// are kept for the time period specified by the "retentionPeriod" parameter. (For more
        /// information, see https://docs.aws.amazon.com/iotanalytics/latest/userguide/getting-started.html#aws-iot-analytics-dataset-versions)
        /// </para>
        /// </summary>
        public VersioningConfiguration VersioningConfiguration
        {
            get { return this._versioningConfiguration; }
            set { this._versioningConfiguration = value; }
        }

        // Check to see if VersioningConfiguration property is set
        internal bool IsSetVersioningConfiguration()
        {
            return this._versioningConfiguration != null;
        }

    }
}