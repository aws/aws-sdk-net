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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        [AWSProperty(Required = true)]
        public ComponentType ComponentType { get; set; }

        /// <summary>
        /// Checks to see if the ComponentType property is set.
        /// </summary>
        internal bool IsSetComponentType() => this.ComponentType != null;

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
        [AWSProperty(Required = true)]
        public string Ec2InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the Ec2InstanceId property is set.
        /// </summary>
        internal bool IsSetEc2InstanceId() => this.Ec2InstanceId != null;

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
        [AWSProperty(Required = true)]
        public string Sid { get; set; }

        /// <summary>
        /// Checks to see if the Sid property is set.
        /// </summary>
        internal bool IsSetSid() => this.Sid != null;
    }
}
