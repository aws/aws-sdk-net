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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// This is the response object from the DescribeApp operation.
    /// </summary>
    public partial class DescribeAppResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _domain;
        private SimulationAppEndpointInfo _endpointInfo;
        private LaunchOverrides _launchOverrides;
        private string _name;
        private string _simulation;
        private SimulationAppStatus _status;
        private SimulationAppTargetStatus _targetStatus;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointInfo. 
        /// <para>
        /// Information about the network endpoint for the custom app. You can use the endpoint
        /// to connect to the custom app.
        /// </para>
        /// </summary>
        public SimulationAppEndpointInfo EndpointInfo
        {
            get { return this._endpointInfo; }
            set { this._endpointInfo = value; }
        }

        // Check to see if EndpointInfo property is set
        internal bool IsSetEndpointInfo()
        {
            return this._endpointInfo != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchOverrides.
        /// </summary>
        public LaunchOverrides LaunchOverrides
        {
            get { return this._launchOverrides; }
            set { this._launchOverrides = value; }
        }

        // Check to see if LaunchOverrides property is set
        internal bool IsSetLaunchOverrides()
        {
            return this._launchOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Simulation. 
        /// <para>
        /// The name of the simulation of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Simulation
        {
            get { return this._simulation; }
            set { this._simulation = value; }
        }

        // Check to see if Simulation property is set
        internal bool IsSetSimulation()
        {
            return this._simulation != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle state of the custom app.
        /// </para>
        /// </summary>
        public SimulationAppStatus Status
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
        /// Gets and sets the property TargetStatus. 
        /// <para>
        /// The desired lifecycle state of the custom app.
        /// </para>
        /// </summary>
        public SimulationAppTargetStatus TargetStatus
        {
            get { return this._targetStatus; }
            set { this._targetStatus = value; }
        }

        // Check to see if TargetStatus property is set
        internal bool IsSetTargetStatus()
        {
            return this._targetStatus != null;
        }

    }
}