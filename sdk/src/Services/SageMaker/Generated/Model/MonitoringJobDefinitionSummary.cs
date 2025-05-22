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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Summary information about a monitoring job.
    /// </summary>
    public partial class MonitoringJobDefinitionSummary
    {
        private DateTime? _creationTime;
        private string _endpointName;
        private string _monitoringJobDefinitionArn;
        private string _monitoringJobDefinitionName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the monitoring job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the endpoint that the job monitors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringJobDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string MonitoringJobDefinitionArn
        {
            get { return this._monitoringJobDefinitionArn; }
            set { this._monitoringJobDefinitionArn = value; }
        }

        // Check to see if MonitoringJobDefinitionArn property is set
        internal bool IsSetMonitoringJobDefinitionArn()
        {
            return this._monitoringJobDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringJobDefinitionName. 
        /// <para>
        /// The name of the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string MonitoringJobDefinitionName
        {
            get { return this._monitoringJobDefinitionName; }
            set { this._monitoringJobDefinitionName = value; }
        }

        // Check to see if MonitoringJobDefinitionName property is set
        internal bool IsSetMonitoringJobDefinitionName()
        {
            return this._monitoringJobDefinitionName != null;
        }

    }
}