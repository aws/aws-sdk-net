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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
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
namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// Container for the parameters to the DeploySystemInstance operation.
    /// <b>Greengrass and Cloud Deployments</b> 
    /// 
    ///  
    /// <para>
    /// Deploys the system instance to the target specified in <c>CreateSystemInstance</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Greengrass Deployments</b> 
    /// </para>
    ///  
    /// <para>
    /// If the system or any workflows and entities have been updated before this action is
    /// called, then the deployment will create a new Amazon Simple Storage Service resource
    /// file and then deploy it.
    /// </para>
    ///  
    /// <para>
    /// Since this action creates a Greengrass deployment on the caller's behalf, the calling
    /// identity must have write permissions to the specified Greengrass group. Otherwise,
    /// the call will fail with an authorization error.
    /// </para>
    ///  
    /// <para>
    /// For information about the artifacts that get added to your Greengrass core device
    /// when you use this API, see <a href="https://docs.aws.amazon.com/thingsgraph/latest/ug/iot-tg-greengrass.html">AWS
    /// IoT Things Graph and AWS IoT Greengrass</a>.
    /// </para>
    /// </summary>
    public partial class DeploySystemInstanceRequest : AmazonIoTThingsGraphRequest
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the system instance. This value is returned by the <c>CreateSystemInstance</c>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// The ID should be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>urn:tdm:REGION/ACCOUNT ID/default:deployment:DEPLOYMENTNAME</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=160)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}