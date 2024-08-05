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
    /// Specifies the AWS Mainframe Modernization managed application step input.
    /// </summary>
    public partial class M2ManagedApplicationStepInput
    {
        private M2ManagedActionType _actionType;
        private string _applicationId;
        private int? _listenerPort;
        private M2ManagedActionProperties _properties;
        private string _runtime;
        private string _vpcEndpointServiceName;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The action type of the AWS Mainframe Modernization managed application step input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public M2ManagedActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID of the AWS Mainframe Modernization managed application step input.
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
        /// The listener port of the AWS Mainframe Modernization managed application step input.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties of the AWS Mainframe Modernization managed application step input.
        /// </para>
        /// </summary>
        public M2ManagedActionProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// The runtime of the AWS Mainframe Modernization managed application step input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Runtime
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
        /// The VPC endpoint service name of the AWS Mainframe Modernization managed application
        /// step input.
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