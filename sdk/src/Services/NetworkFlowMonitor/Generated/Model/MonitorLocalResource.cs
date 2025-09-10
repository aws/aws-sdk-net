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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// A local resource is the host where the agent is installed. Local resources can be
    /// a a subnet, a VPC, an Availability Zone, or an Amazon Web Services service.
    /// </summary>
    public partial class MonitorLocalResource
    {
        private string _identifier;
        private MonitorLocalResourceType _type;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the local resource. For a VPC or subnet, this identifier is the
        /// VPC Amazon Resource Name (ARN) or subnet ARN. For an Availability Zone, this identifier
        /// is the AZ name, for example, us-west-2b.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the local resource. Valid values are <c>AWS::EC2::VPC</c> <c>AWS::AvailabilityZone</c>,
        /// <c>AWS::EC2::Subnet</c>, or <c>AWS::Region</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitorLocalResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}