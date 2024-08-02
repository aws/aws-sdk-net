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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies the AWS Mainframe Modernization managed application.
    /// </summary>
    public partial class M2ManagedApplication
    {
        private string _applicationId;
        private string _listenerPort;
        private M2ManagedRuntime _runtime;
        private string _vpcEndpointServiceName;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID of the AWS Mainframe Modernization managed application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ListenerPort. 
        /// <para>
        /// The listener port of the AWS Mainframe Modernization managed application.
        /// </para>
        /// </summary>
        public string ListenerPort
        {
            get { return this._listenerPort; }
            set { this._listenerPort = value; }
        }

        // Check to see if ListenerPort property is set
        internal bool IsSetListenerPort()
        {
            return this._listenerPort != null;
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime of the AWS Mainframe Modernization managed application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public M2ManagedRuntime Runtime
        {
            get { return this._runtime; }
            set { this._runtime = value; }
        }

        // Check to see if Runtime property is set
        internal bool IsSetRuntime()
        {
            return this._runtime != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointServiceName. 
        /// <para>
        /// The VPC endpoint service name of the AWS Mainframe Modernization managed application.
        /// </para>
        /// </summary>
        public string VpcEndpointServiceName
        {
            get { return this._vpcEndpointServiceName; }
            set { this._vpcEndpointServiceName = value; }
        }

        // Check to see if VpcEndpointServiceName property is set
        internal bool IsSetVpcEndpointServiceName()
        {
            return this._vpcEndpointServiceName != null;
        }

    }
}