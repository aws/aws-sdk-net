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

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironment operation.
    /// Create a new FinSpace environment.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonFinspaceRequest
    {
        private List<string> _dataBundles = new List<string>();
        private string _description;
        private FederationMode _federationMode;
        private FederationParameters _federationParameters;
        private string _kmsKeyId;
        private string _name;
        private SuperuserParameters _superuserParameters;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DataBundles. 
        /// <para>
        /// The list of Amazon Resource Names (ARN) of the data bundles to install. Currently
        /// supported data bundle ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:finspace:${Region}::data-bundle/capital-markets-sample</code> - Contains
        /// sample Capital Markets datasets, categories and controlled vocabularies.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:finspace:${Region}::data-bundle/taq</code> (default) - Contains trades
        /// and quotes data in addition to sample Capital Markets data.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> DataBundles
        {
            get { return this._dataBundles; }
            set { this._dataBundles = value; }
        }

        // Check to see if DataBundles property is set
        internal bool IsSetDataBundles()
        {
            return this._dataBundles != null && this._dataBundles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the FinSpace environment to be created.
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
        /// Gets and sets the property FederationMode. 
        /// <para>
        /// Authentication mode for the environment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FEDERATED</code> - Users access FinSpace through Single Sign On (SSO) via your
        /// Identity provider.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LOCAL</code> - Users access FinSpace via email and password managed within
        /// the FinSpace environment.
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
        /// <para>
        /// Configuration information when authentication mode is FEDERATED.
        /// </para>
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key id to encrypt your data in the FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the FinSpace environment to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property SuperuserParameters. 
        /// <para>
        /// Configuration information for the superuser.
        /// </para>
        /// </summary>
        public SuperuserParameters SuperuserParameters
        {
            get { return this._superuserParameters; }
            set { this._superuserParameters = value; }
        }

        // Check to see if SuperuserParameters property is set
        internal bool IsSetSuperuserParameters()
        {
            return this._superuserParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Add tags to your FinSpace environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}