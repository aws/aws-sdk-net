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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
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
namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeJobExecution operation.
    /// Gets details of a job execution.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeJobExecution</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class DescribeJobExecutionRequest : AmazonIoTJobsDataPlaneRequest
    {
        private long? _executionNumber;
        private bool? _includeJobDocument;
        private string _jobId;
        private string _thingName;

        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// Optional. A number that identifies a particular job execution on a particular device.
        /// If not specified, the latest job execution is returned.
        /// </para>
        /// </summary>
        public long? ExecutionNumber
        {
            get { return this._executionNumber; }
            set { this._executionNumber = value; }
        }

        // Check to see if ExecutionNumber property is set
        internal bool IsSetExecutionNumber()
        {
            return this._executionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeJobDocument. 
        /// <para>
        /// Optional. Unless set to false, the response contains the job document. The default
        /// is true.
        /// </para>
        /// </summary>
        public bool? IncludeJobDocument
        {
            get { return this._includeJobDocument; }
            set { this._includeJobDocument = value; }
        }

        // Check to see if IncludeJobDocument property is set
        internal bool IsSetIncludeJobDocument()
        {
            return this._includeJobDocument.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier assigned to this job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The thing name associated with the device the job execution is running on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

    }
}