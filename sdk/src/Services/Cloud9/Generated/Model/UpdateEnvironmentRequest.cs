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
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Changes the settings of an existing Cloud9 development environment.
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonCloud9Request
    {
        private string _description;
        private string _environmentId;
        private ManagedCredentialsAction _managedCredentialsAction;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Any new or replacement description for the environment.
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment to change settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedCredentialsAction. 
        /// <para>
        /// Allows the environment owner to turn on or turn off the Amazon Web Services managed
        /// temporary credentials for an Cloud9 environment by using one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLE</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Only the environment owner can change the status of managed temporary credentials.
        /// An <code>AccessDeniedException</code> is thrown if an attempt to turn on or turn off
        /// managed temporary credentials is made by an account that's not the environment owner.
        /// </para>
        ///  </note>
        /// </summary>
        public ManagedCredentialsAction ManagedCredentialsAction
        {
            get { return this._managedCredentialsAction; }
            set { this._managedCredentialsAction = value; }
        }

        // Check to see if ManagedCredentialsAction property is set
        internal bool IsSetManagedCredentialsAction()
        {
            return this._managedCredentialsAction != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A replacement name for the environment.
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

    }
}