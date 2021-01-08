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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListNotebookExecutions operation.
    /// Provides summaries of all notebook executions. You can filter the list based on multiple
    /// criteria such as status, time range, and editor id. Returns a maximum of 50 notebook
    /// executions and a marker to track the paging of a longer notebook execution list across
    /// multiple <code>ListNotebookExecution</code> calls.
    /// </summary>
    public partial class ListNotebookExecutionsRequest : AmazonElasticMapReduceRequest
    {
        private string _editorId;
        private DateTime? _from;
        private string _marker;
        private NotebookExecutionStatus _status;
        private DateTime? _to;

        /// <summary>
        /// Gets and sets the property EditorId. 
        /// <para>
        /// The unique ID of the editor associated with the notebook execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string EditorId
        {
            get { return this._editorId; }
            set { this._editorId = value; }
        }

        // Check to see if EditorId property is set
        internal bool IsSetEditorId()
        {
            return this._editorId != null;
        }

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The beginning of time range filter for listing notebook executions. The default is
        /// the timestamp of 30 days ago.
        /// </para>
        /// </summary>
        public DateTime From
        {
            get { return this._from.GetValueOrDefault(); }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token, returned by a previous <code>ListNotebookExecutions</code> call,
        /// that indicates the start of the list for this <code>ListNotebookExecutions</code>
        /// call.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status filter for listing notebook executions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>START_PENDING</code> indicates that the cluster has received the execution
        /// request but execution has not begun.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STARTING</code> indicates that the execution is starting on the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RUNNING</code> indicates that the execution is being processed by the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FINISHING</code> indicates that execution processing is in the final stages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FINISHED</code> indicates that the execution has completed without error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILING</code> indicates that the execution is failing and will not finish
        /// successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> indicates that the execution failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOP_PENDING</code> indicates that the cluster has received a <code>StopNotebookExecution</code>
        /// request and the stop is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPING</code> indicates that the cluster is in the process of stopping the
        /// execution as a result of a <code>StopNotebookExecution</code> request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STOPPED</code> indicates that the execution stopped because of a <code>StopNotebookExecution</code>
        /// request.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NotebookExecutionStatus Status
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
        /// Gets and sets the property To. 
        /// <para>
        /// The end of time range filter for listing notebook executions. The default is the current
        /// timestamp.
        /// </para>
        /// </summary>
        public DateTime To
        {
            get { return this._to.GetValueOrDefault(); }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to.HasValue; 
        }

    }
}