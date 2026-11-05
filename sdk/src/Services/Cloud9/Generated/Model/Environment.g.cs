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

namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// Information about an Cloud9 development environment.
    /// </summary>
    public partial class Environment
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The connection type used for connecting to an Amazon EC2 environment. <c>CONNECT_SSH</c>
        /// is selected by default.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the environment.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The state of the environment in its creation or deletion lifecycle.
        /// </para>
        /// </summary>
        public EnvironmentLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property ManagedCredentialsStatus. 
        /// <para>
        /// Describes the status of Amazon Web Services managed temporary credentials for the
        /// Cloud9 environment. Available values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED_ON_CREATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED_BY_OWNER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED_BY_DEFAULT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED_BY_OWNER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED_BY_COLLABORATOR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_REMOVAL_BY_COLLABORATOR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_REMOVAL_BY_OWNER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_REMOVAL_BY_COLLABORATOR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED_BY_OWNER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED_BY_DEFAULT</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedCredentialsStatus ManagedCredentialsStatus { get; set; }

        /// <summary>
        /// Checks to see if the ManagedCredentialsStatus property is set.
        /// </summary>
        internal bool IsSetManagedCredentialsStatus() => this.ManagedCredentialsStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 60)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwnerArn { get; set; }

        /// <summary>
        /// Checks to see if the OwnerArn property is set.
        /// </summary>
        internal bool IsSetOwnerArn() => this.OwnerArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of environment. Valid values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ec2</c>: An Amazon Elastic Compute Cloud (Amazon EC2) instance connects to the
        /// environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ssh</c>: Your own server connects to the environment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnvironmentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
