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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Information about an Cloud9 development environment.
    /// </summary>
    public partial class Environment
    {
        private string _arn;
        private ConnectionType _connectionType;
        private string _description;
        private string _id;
        private EnvironmentLifecycle _lifecycle;
        private ManagedCredentialsStatus _managedCredentialsStatus;
        private string _name;
        private string _ownerArn;
        private EnvironmentType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The connection type used for connecting to an Amazon EC2 environment. <code>CONNECT_SSH</code>
        /// is selected by default.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the environment.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The state of the environment in its creation or deletion lifecycle.
        /// </para>
        /// </summary>
        public EnvironmentLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedCredentialsStatus. 
        /// <para>
        /// Describes the status of Amazon Web Services managed temporary credentials for the
        /// Cloud9 environment. Available values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLED_ON_CREATE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENABLED_BY_OWNER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED_BY_DEFAULT</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED_BY_OWNER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED_BY_COLLABORATOR</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_REMOVAL_BY_COLLABORATOR</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_REMOVAL_BY_OWNER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED_REMOVAL_BY_COLLABORATOR</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENABLED_BY_OWNER</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED_BY_DEFAULT</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedCredentialsStatus ManagedCredentialsStatus
        {
            get { return this._managedCredentialsStatus; }
            set { this._managedCredentialsStatus = value; }
        }

        // Check to see if ManagedCredentialsStatus property is set
        internal bool IsSetManagedCredentialsStatus()
        {
            return this._managedCredentialsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwnerArn
        {
            get { return this._ownerArn; }
            set { this._ownerArn = value; }
        }

        // Check to see if OwnerArn property is set
        internal bool IsSetOwnerArn()
        {
            return this._ownerArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of environment. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2</code>: An Amazon Elastic Compute Cloud (Amazon EC2) instance connects
        /// to the environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ssh</code>: Your own server connects to the environment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnvironmentType Type
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