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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        private string _description;
        private EngineConfiguration _engineConfiguration;
        private string _engineVersion;
        private string _notebookVersion;
        private SessionConfiguration _sessionConfiguration;
        private string _sessionId;
        private SessionStatistics _statistics;
        private SessionStatus _status;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The session description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EngineConfiguration. 
        /// <para>
        /// Contains engine configuration information like DPU usage.
        /// </para>
        /// </summary>
        public EngineConfiguration EngineConfiguration
        {
            get { return this._engineConfiguration; }
            set { this._engineConfiguration = value; }
        }

        // Check to see if EngineConfiguration property is set
        internal bool IsSetEngineConfiguration()
        {
            return this._engineConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version used by the session (for example, <code>PySpark engine version
        /// 3</code>). You can get a list of engine versions by calling <a>ListEngineVersions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookVersion. 
        /// <para>
        /// The notebook version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NotebookVersion
        {
            get { return this._notebookVersion; }
            set { this._notebookVersion = value; }
        }

        // Check to see if NotebookVersion property is set
        internal bool IsSetNotebookVersion()
        {
            return this._notebookVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SessionConfiguration. 
        /// <para>
        /// Contains the workgroup configuration information used by the session.
        /// </para>
        /// </summary>
        public SessionConfiguration SessionConfiguration
        {
            get { return this._sessionConfiguration; }
            set { this._sessionConfiguration = value; }
        }

        // Check to see if SessionConfiguration property is set
        internal bool IsSetSessionConfiguration()
        {
            return this._sessionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Contains the DPU execution time.
        /// </para>
        /// </summary>
        public SessionStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Contains information about the status of the session.
        /// </para>
        /// </summary>
        public SessionStatus Status
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
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The workgroup to which the session belongs.
        /// </para>
        /// </summary>
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}