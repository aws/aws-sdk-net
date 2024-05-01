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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Update your FinSpace environment.
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonFinspaceRequest
    {
        private string _description;
        private string _environmentId;
        private FederationMode _federationMode;
        private FederationParameters _federationParameters;
        private string _name;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The identifier of the FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
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
        /// Gets and sets the property FederationMode. 
        /// <para>
        /// Authentication mode for the environment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FEDERATED</c> - Users access FinSpace through Single Sign On (SSO) via your Identity
        /// provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOCAL</c> - Users access FinSpace via email and password managed within the FinSpace
        /// environment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FederationMode FederationMode
        {
            get { return this._federationMode; }
            set { this._federationMode = value; }
        }

        // Check to see if FederationMode property is set
        internal bool IsSetFederationMode()
        {
            return this._federationMode != null;
        }

        /// <summary>
        /// Gets and sets the property FederationParameters.
        /// </summary>
        public FederationParameters FederationParameters
        {
            get { return this._federationParameters; }
            set { this._federationParameters = value; }
        }

        // Check to see if FederationParameters property is set
        internal bool IsSetFederationParameters()
        {
            return this._federationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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