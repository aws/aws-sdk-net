/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the Amazon Elastic Compute Cloud instance and related resources to be created
    /// using the <code>create cloud formation stack</code> operation.
    /// </summary>
    public partial class InstanceEntry
    {
        private string _availabilityZone;
        private string _instanceType;
        private PortInfoSourceType _portInfoSource;
        private string _sourceName;
        private string _userData;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the new Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type (e.g., <code>t2.micro</code>) to use for the new Amazon EC2 instance.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property PortInfoSource. 
        /// <para>
        /// The port configuration to use for the new Amazon EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// The following configuration options are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DEFAULT — Use the default firewall settings from the image.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE — Use the firewall settings from the source Lightsail instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NONE — Default to Amazon EC2.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLOSED — All ports closed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PortInfoSourceType PortInfoSource
        {
            get { return this._portInfoSource; }
            set { this._portInfoSource = value; }
        }

        // Check to see if PortInfoSource property is set
        internal bool IsSetPortInfoSource()
        {
            return this._portInfoSource != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the export snapshot record, which contains the exported Lightsail instance
        /// snapshot that will be used as the source of the new Amazon EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>get export snapshot records</code> operation to get a list of export
        /// snapshot records that you can use to create a CloudFormation stack.
        /// </para>
        /// </summary>
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// A launch script you can create that configures a server with additional user data.
        /// For example, you might want to run <code>apt-get -y update</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Depending on the machine image you choose, the command to get software on your instance
        /// varies. Amazon Linux and CentOS use <code>yum</code>, Debian and Ubuntu use <code>apt-get</code>,
        /// and FreeBSD uses <code>pkg</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public string UserData
        {
            get { return this._userData; }
            set { this._userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this._userData != null;
        }

    }
}