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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApp operation.
    /// Returns the state of the given custom app.
    /// </summary>
    public partial class DescribeAppRequest : AmazonSimSpaceWeaverRequest
    {
        private string _app;
        private string _domain;
        private string _simulation;

        /// <summary>
        /// Gets and sets the property App. 
        /// <para>
        /// The name of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string App
        {
            get { return this._app; }
            set { this._app = value; }
        }

        // Check to see if App property is set
        internal bool IsSetApp()
        {
            return this._app != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The name of the domain of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Simulation. 
        /// <para>
        /// The name of the simulation of the app.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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

    }
}