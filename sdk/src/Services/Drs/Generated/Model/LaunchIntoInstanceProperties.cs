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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Launch into existing instance.
    /// </summary>
    public partial class LaunchIntoInstanceProperties
    {
        private string _launchIntoEC2InstanceID;

        /// <summary>
        /// Gets and sets the property LaunchIntoEC2InstanceID. 
        /// <para>
        /// Optionally holds EC2 instance ID of an instance to launch into, instead of launching
        /// a new instance during drill, recovery or failback.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string LaunchIntoEC2InstanceID
        {
            get { return this._launchIntoEC2InstanceID; }
            set { this._launchIntoEC2InstanceID = value; }
        }

        // Check to see if LaunchIntoEC2InstanceID property is set
        internal bool IsSetLaunchIntoEC2InstanceID()
        {
            return this._launchIntoEC2InstanceID != null;
        }

    }
}