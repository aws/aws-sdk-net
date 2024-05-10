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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a tool. Tools are used in a simulation job.
    /// </summary>
    public partial class Tool
    {
        private string _command;
        private ExitBehavior _exitBehavior;
        private string _name;
        private bool? _streamOutputToCloudWatch;
        private bool? _streamui;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// Command-line arguments for the tool. It must include the tool executable name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property ExitBehavior. 
        /// <para>
        /// Exit behavior determines what happens when your tool quits running. <c>RESTART</c>
        /// will cause your tool to be restarted. <c>FAIL</c> will cause your job to exit. The
        /// default is <c>RESTART</c>. 
        /// </para>
        /// </summary>
        public ExitBehavior ExitBehavior
        {
            get { return this._exitBehavior; }
            set { this._exitBehavior = value; }
        }

        // Check to see if ExitBehavior property is set
        internal bool IsSetExitBehavior()
        {
            return this._exitBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property StreamOutputToCloudWatch. 
        /// <para>
        /// Boolean indicating whether logs will be recorded in CloudWatch for the tool. The default
        /// is <c>False</c>. 
        /// </para>
        /// </summary>
        public bool? StreamOutputToCloudWatch
        {
            get { return this._streamOutputToCloudWatch; }
            set { this._streamOutputToCloudWatch = value; }
        }

        // Check to see if StreamOutputToCloudWatch property is set
        internal bool IsSetStreamOutputToCloudWatch()
        {
            return this._streamOutputToCloudWatch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamUI. 
        /// <para>
        /// Boolean indicating whether a streaming session will be configured for the tool. If
        /// <c>True</c>, AWS RoboMaker will configure a connection so you can interact with the
        /// tool as it is running in the simulation. It must have a graphical user interface.
        /// The default is <c>False</c>. 
        /// </para>
        /// </summary>
        public bool? StreamUI
        {
            get { return this._streamui; }
            set { this._streamui = value; }
        }

        // Check to see if StreamUI property is set
        internal bool IsSetStreamUI()
        {
            return this._streamui.HasValue; 
        }

    }
}