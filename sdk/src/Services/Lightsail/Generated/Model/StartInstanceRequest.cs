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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the StartInstance operation.
    /// Starts a specific Amazon Lightsail instance from a stopped state. To restart an instance,
    /// use the <c>reboot instance</c> operation.
    /// 
    ///  <note> 
    /// <para>
    /// When you start a stopped instance, Lightsail assigns a new public IP address to the
    /// instance. To use the same IP address after stopping and starting an instance, create
    /// a static IP address and attach it to the instance. For more information, see the <a
    /// href="https://docs.aws.amazon.com/lightsail/latest/userguide/lightsail-create-static-ip">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The <c>start instance</c> operation supports tag-based access control via resource
    /// tags applied to the resource identified by <c>instance name</c>. For more information,
    /// see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class StartInstanceRequest : AmazonLightsailRequest
    {
        private string _instanceName;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the instance (a virtual private server) to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

    }
}