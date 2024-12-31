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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// This is information about the component of your SAP application, such as Web Dispatcher.
    /// </summary>
    public partial class ComponentInfo
    {
        private ComponentType _componentType;
        private string _ec2InstanceId;
        private string _sid;

        /// <summary>
        /// Gets and sets the property ComponentType. 
        /// <para>
        /// This string is the type of the component.
        /// </para>
        ///  
        /// <para>
        /// Accepted value is <c>WD</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComponentType ComponentType
        {
            get { return this._componentType; }
            set { this._componentType = value; }
        }

        // Check to see if ComponentType property is set
        internal bool IsSetComponentType()
        {
            return this._componentType != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// This is the Amazon EC2 instance on which your SAP component is running.
        /// </para>
        ///  
        /// <para>
        /// Accepted values are alphanumeric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Ec2InstanceId
        {
            get { return this._ec2InstanceId; }
            set { this._ec2InstanceId = value; }
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this._ec2InstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Sid. 
        /// <para>
        /// This string is the SAP System ID of the component.
        /// </para>
        ///  
        /// <para>
        /// Accepted values are alphanumeric.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Sid
        {
            get { return this._sid; }
            set { this._sid = value; }
        }

        // Check to see if Sid property is set
        internal bool IsSetSid()
        {
            return this._sid != null;
        }

    }
}