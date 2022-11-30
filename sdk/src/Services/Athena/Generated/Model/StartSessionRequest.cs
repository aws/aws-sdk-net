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
    /// Container for the parameters to the StartSession operation.
    /// Creates a session for running calculations within a workgroup. The session is ready
    /// when it reaches an <code>IDLE</code> state.
    /// </summary>
    public partial class StartSessionRequest : AmazonAthenaRequest
    {
        private string _clientRequestToken;
        private string _description;
        private EngineConfiguration _engineConfiguration;
        private string _notebookVersion;
        private int? _sessionIdleTimeoutInMinutes;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique case-sensitive string used to ensure the request to create the session is
        /// idempotent (executes only once). If another <code>StartSessionRequest</code> is received,
        /// the same response is returned and another session is not created. If a parameter has
        /// changed, an error is returned.
        /// </para>
        ///  <important> 
        /// <para>
        /// This token is listed as not required because Amazon Web Services SDKs (for example
        /// the Amazon Web Services SDK for Java) auto-generate the token for users. If you are
        /// not using the Amazon Web Services SDK or the Amazon Web Services CLI, you must provide
        /// this token or the action will fail.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

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
        /// Contains engine data processing unit (DPU) configuration settings and parameter mappings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NotebookVersion. 
        /// <para>
        /// The notebook version. This value is required only when requesting that a notebook
        /// server be started for the session. The only valid notebook version is <code>Jupyter1.0</code>.
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
        /// Gets and sets the property SessionIdleTimeoutInMinutes. 
        /// <para>
        /// The idle timeout in minutes for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=480)]
        public int SessionIdleTimeoutInMinutes
        {
            get { return this._sessionIdleTimeoutInMinutes.GetValueOrDefault(); }
            set { this._sessionIdleTimeoutInMinutes = value; }
        }

        // Check to see if SessionIdleTimeoutInMinutes property is set
        internal bool IsSetSessionIdleTimeoutInMinutes()
        {
            return this._sessionIdleTimeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The workgroup to which the session belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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