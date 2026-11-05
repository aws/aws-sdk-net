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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Details about a security configuration for OpenSearch Serverless.
    /// </summary>
    public partial class SecurityConfigDetail
    {
        /// <summary>
        /// Gets and sets the property ConfigVersion. 
        /// <para>
        /// The version of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 36)]
        public string ConfigVersion { get; set; }

        /// <summary>
        /// Checks to see if the ConfigVersion property is set.
        /// </summary>
        internal bool IsSetConfigVersion() => this.ConfigVersion != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the configuration was created.
        /// </para>
        /// </summary>
        public long? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IamFederationOptions. 
        /// <para>
        /// Describes IAM federation options in the form of a key-value map. Contains configuration
        /// details about how OpenSearch Serverless integrates with external identity providers
        /// through federation.
        /// </para>
        /// </summary>
        public IamFederationConfigOptions IamFederationOptions { get; set; }

        /// <summary>
        /// Checks to see if the IamFederationOptions property is set.
        /// </summary>
        internal bool IsSetIamFederationOptions() => this.IamFederationOptions != null;

        /// <summary>
        /// Gets and sets the property IamIdentityCenterOptions. 
        /// <para>
        /// Describes IAM Identity Center options in the form of a key-value map.
        /// </para>
        /// </summary>
        public IamIdentityCenterConfigOptions IamIdentityCenterOptions { get; set; }

        /// <summary>
        /// Checks to see if the IamIdentityCenterOptions property is set.
        /// </summary>
        internal bool IsSetIamIdentityCenterOptions() => this.IamIdentityCenterOptions != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The timestamp of when the configuration was last modified.
        /// </para>
        /// </summary>
        public long? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property SamlOptions. 
        /// <para>
        /// SAML options for the security configuration in the form of a key-value map.
        /// </para>
        /// </summary>
        public SamlConfigOptions SamlOptions { get; set; }

        /// <summary>
        /// Checks to see if the SamlOptions property is set.
        /// </summary>
        internal bool IsSetSamlOptions() => this.SamlOptions != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of security configuration.
        /// </para>
        /// </summary>
        public SecurityConfigType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
