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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an application with the given name and description.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private string _description;
        private string _name;
        private string _wave;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=127)]
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
        /// Gets and sets the property Wave. 
        /// <para>
        /// The name of the migration wave of the application to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Wave
        {
            get { return this._wave; }
            set { this._wave = value; }
        }

        // Check to see if Wave property is set
        internal bool IsSetWave()
        {
            return this._wave != null;
        }

    }
}