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
    /// Specifies the AWS Mainframe Modernization non-managed application summary.
    /// </summary>
    public partial class M2NonManagedApplicationSummary
    {
        private int? _listenerPort;
        private M2NonManagedRuntime _runtime;
        private string _vpcEndpointServiceName;
        private string _webAppName;

        /// <summary>
        /// Gets and sets the property ListenerPort. 
        /// <para>
        /// The listener port of the AWS Mainframe Modernization non-managed application summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ListenerPort
        {
            get { return this._listenerPort; }
            set { this._listenerPort = value; }
        }

        // Check to see if ListenerPort property is set
        internal bool IsSetListenerPort()
        {
            return this._listenerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime of the AWS Mainframe Modernization non-managed application summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public M2NonManagedRuntime Runtime
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
        /// The VPC endpoint service name of the AWS Mainframe Modernization non-managed application
        /// summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property WebAppName. 
        /// <para>
        /// The web application name of the AWS Mainframe Modernization non-managed application
        /// summary.
        /// </para>
        /// </summary>
        public string WebAppName
        {
            get { return this._webAppName; }
            set { this._webAppName = value; }
        }

        // Check to see if WebAppName property is set
        internal bool IsSetWebAppName()
        {
            return this._webAppName != null;
        }

    }
}