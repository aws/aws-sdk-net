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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMonitoringSchedule operation.
    /// Creates a schedule that regularly starts Amazon SageMaker Processing Jobs to monitor
    /// the data captured for an Amazon SageMaker Endpoint.
    /// </summary>
    public partial class CreateMonitoringScheduleRequest : AmazonSageMakerRequest
    {
        private MonitoringScheduleConfig _monitoringScheduleConfig;
        private string _monitoringScheduleName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property MonitoringScheduleConfig. 
        /// <para>
        /// The configuration object that specifies the monitoring schedule and defines the monitoring
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitoringScheduleConfig MonitoringScheduleConfig
        {
            get { return this._monitoringScheduleConfig; }
            set { this._monitoringScheduleConfig = value; }
        }

        // Check to see if MonitoringScheduleConfig property is set
        internal bool IsSetMonitoringScheduleConfig()
        {
            return this._monitoringScheduleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringScheduleName. 
        /// <para>
        /// The name of the monitoring schedule. The name must be unique within an Amazon Web
        /// Services Region within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string MonitoringScheduleName
        {
            get { return this._monitoringScheduleName; }
            set { this._monitoringScheduleName = value; }
        }

        // Check to see if MonitoringScheduleName property is set
        internal bool IsSetMonitoringScheduleName()
        {
            return this._monitoringScheduleName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) An array of key-value pairs. For more information, see <a href=" https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-whatURL">Using
        /// Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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

    }
}