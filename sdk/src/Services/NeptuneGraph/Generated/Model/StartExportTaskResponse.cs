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
    /// This is the response object from the StartExportTask operation.
    /// </summary>
    public partial class StartExportTaskResponse : AmazonWebServiceResponse
    {
        private string _destination;
        private ExportFilter _exportFilter;
        private ExportFormat _format;
        private string _graphId;
        private string _kmsKeyIdentifier;
        private ParquetType _parquetType;
        private string _roleArn;
        private ExportTaskStatus _status;
        private string _statusReason;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon S3 URI of the export task where data will be exported to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property ExportFilter. 
        /// <para>
        /// The export filter of the export task.
        /// </para>
        /// </summary>
        public ExportFilter ExportFilter
        {
            get { return this._exportFilter; }
            set { this._exportFilter = value; }
        }

        // Check to see if ExportFilter property is set
        internal bool IsSetExportFilter()
        {
            return this._exportFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportFormat Format
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
        /// The source graph identifier of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The KMS key identifier of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ParquetType. 
        /// <para>
        /// The parquet type of the export task.
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
        /// The ARN of the IAM role that will allow data to be exported to the destination.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportTaskStatus Status
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
        /// The reason that the export task has this status value.
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
        /// The unique identifier of the export task.
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