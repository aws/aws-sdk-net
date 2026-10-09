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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the GetSession operation.
    /// </summary>
    public partial class GetSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The session description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EngineConfiguration. 
        /// <para>
        /// Contains engine configuration information like DPU usage.
        /// </para>
        /// </summary>
        public EngineConfiguration EngineConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EngineConfiguration property is set.
        /// </summary>
        internal bool IsSetEngineConfiguration() => this.EngineConfiguration != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version used by the session (for example, <c>PySpark engine version 3</c>).
        /// You can get a list of engine versions by calling <a>ListEngineVersions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration.
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetMonitoringConfiguration() => this.MonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property NotebookVersion. 
        /// <para>
        /// The notebook version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NotebookVersion { get; set; }

        /// <summary>
        /// Checks to see if the NotebookVersion property is set.
        /// </summary>
        internal bool IsSetNotebookVersion() => this.NotebookVersion != null;

        /// <summary>
        /// Gets and sets the property SessionConfiguration. 
        /// <para>
        /// Contains the workgroup configuration information used by the session.
        /// </para>
        /// </summary>
        public SessionConfiguration SessionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SessionConfiguration property is set.
        /// </summary>
        internal bool IsSetSessionConfiguration() => this.SessionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Contains the DPU execution time.
        /// </para>
        /// </summary>
        public SessionStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Contains information about the status of the session.
        /// </para>
        /// </summary>
        public SessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The workgroup to which the session belongs.
        /// </para>
        /// </summary>
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
