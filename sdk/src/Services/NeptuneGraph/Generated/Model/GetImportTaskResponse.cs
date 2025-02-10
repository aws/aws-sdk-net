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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// This is the response object from the GetImportTask operation.
    /// </summary>
    public partial class GetImportTaskResponse : AmazonWebServiceResponse
    {
        private int? _attemptNumber;
        private Format _format;
        private string _graphId;
        private ImportOptions _importOptions;
        private ImportTaskDetails _importTaskDetails;
        private ParquetType _parquetType;
        private string _roleArn;
        private string _source;
        private ImportTaskStatus _status;
        private string _statusReason;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property AttemptNumber. 
        /// <para>
        /// The number of the current attempts to execute the import task.
        /// </para>
        /// </summary>
        public int? AttemptNumber
        {
            get { return this._attemptNumber; }
            set { this._attemptNumber = value; }
        }

        // Check to see if AttemptNumber property is set
        internal bool IsSetAttemptNumber()
        {
            return this._attemptNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Specifies the format of S3 data to be imported. Valid values are <c>CSV</c>, which
        /// identifies the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
        /// CSV format</a> or <c>OPENCYPHER</c>, which identies the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
        /// load format</a>.
        /// </para>
        /// </summary>
        public Format Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property GraphId. 
        /// <para>
        /// The unique identifier of the Neptune Analytics graph.
        /// </para>
        /// </summary>
        public string GraphId
        {
            get { return this._graphId; }
            set { this._graphId = value; }
        }

        // Check to see if GraphId property is set
        internal bool IsSetGraphId()
        {
            return this._graphId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportOptions. 
        /// <para>
        /// Contains options for controlling the import process. For example, if the <c>failOnError</c>
        /// key is set to <c>false</c>, the import skips problem data and attempts to continue
        /// (whereas if set to <c>true</c>, the default, or if omitted, the import operation halts
        /// immediately when an error is encountered.
        /// </para>
        /// </summary>
        public ImportOptions ImportOptions
        {
            get { return this._importOptions; }
            set { this._importOptions = value; }
        }

        // Check to see if ImportOptions property is set
        internal bool IsSetImportOptions()
        {
            return this._importOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ImportTaskDetails. 
        /// <para>
        /// Contains details about the specified import task.
        /// </para>
        /// </summary>
        public ImportTaskDetails ImportTaskDetails
        {
            get { return this._importTaskDetails; }
            set { this._importTaskDetails = value; }
        }

        // Check to see if ImportTaskDetails property is set
        internal bool IsSetImportTaskDetails()
        {
            return this._importTaskDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ParquetType. 
        /// <para>
        /// The parquet type of the import task.
        /// </para>
        /// </summary>
        public ParquetType ParquetType
        {
            get { return this._parquetType; }
            set { this._parquetType = value; }
        }

        // Check to see if ParquetType property is set
        internal bool IsSetParquetType()
        {
            return this._parquetType != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that will allow access to the data that is to be imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// A URL identifying to the location of the data to be imported. This can be an Amazon
        /// S3 path, or can point to a Neptune database endpoint or snapshot
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the import task:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>INITIALIZING</b>   –   The necessary resources needed to create the graph are
        /// being prepared.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ANALYZING_DATA</b>   –   The data is being analyzed to determine the optimal infrastructure
        /// configuration for the new graph.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>RE_PROVISIONING</b>   –   The data did not fit into the provisioned graph, so
        /// it is being re-provisioned with more capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>IMPORTING</b>   –   The data is being loaded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ERROR_ENCOUNTERED</b>   –   An error has been encountered while trying to create
        /// the graph and import the data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ERROR_ENCOUNTERED_ROLLING_BACK</b>   –   Because of the error that was encountered,
        /// the graph is being rolled back and all its resources released.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SUCCEEDED</b>   –   Graph creation and data loading succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b>   –   Graph creation or data loading failed. When the status is <c>FAILED</c>,
        /// you can use <c>get-graphs</c> to get more information about the state of the graph.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELLING</b>   –   Because you cancelled the import task, cancellation is in
        /// progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CANCELLED</b>   –   You have successfully cancelled the import task.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason that the import task has this status value.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the import task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}