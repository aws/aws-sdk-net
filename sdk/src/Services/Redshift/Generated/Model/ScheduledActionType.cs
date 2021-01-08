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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// The action type that specifies an Amazon Redshift API operation that is supported
    /// by the Amazon Redshift scheduler.
    /// </summary>
    public partial class ScheduledActionType
    {
        private PauseClusterMessage _pauseCluster;
        private ResizeClusterMessage _resizeCluster;
        private ResumeClusterMessage _resumeCluster;

        /// <summary>
        /// Gets and sets the property PauseCluster. 
        /// <para>
        /// An action that runs a <code>PauseCluster</code> API operation. 
        /// </para>
        /// </summary>
        public PauseClusterMessage PauseCluster
        {
            get { return this._pauseCluster; }
            set { this._pauseCluster = value; }
        }

        // Check to see if PauseCluster property is set
        internal bool IsSetPauseCluster()
        {
            return this._pauseCluster != null;
        }

        /// <summary>
        /// Gets and sets the property ResizeCluster. 
        /// <para>
        /// An action that runs a <code>ResizeCluster</code> API operation. 
        /// </para>
        /// </summary>
        public ResizeClusterMessage ResizeCluster
        {
            get { return this._resizeCluster; }
            set { this._resizeCluster = value; }
        }

        // Check to see if ResizeCluster property is set
        internal bool IsSetResizeCluster()
        {
            return this._resizeCluster != null;
        }

        /// <summary>
        /// Gets and sets the property ResumeCluster. 
        /// <para>
        /// An action that runs a <code>ResumeCluster</code> API operation. 
        /// </para>
        /// </summary>
        public ResumeClusterMessage ResumeCluster
        {
            get { return this._resumeCluster; }
            set { this._resumeCluster = value; }
        }

        // Check to see if ResumeCluster property is set
        internal bool IsSetResumeCluster()
        {
            return this._resumeCluster != null;
        }

    }
}