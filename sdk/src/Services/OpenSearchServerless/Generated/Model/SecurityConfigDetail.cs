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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Details about a security configuration for OpenSearch Serverless.
    /// </summary>
    public partial class SecurityConfigDetail
    {
        private string _configVersion;
        private long? _createdDate;
        private string _description;
        private string _id;
        private long? _lastModifiedDate;
        private SamlConfigOptions _samlOptions;
        private SecurityConfigType _type;

        /// <summary>
        /// Gets and sets the property ConfigVersion. 
        /// <para>
        /// The version of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=36)]
        public string ConfigVersion
        {
            get { return this._configVersion; }
            set { this._configVersion = value; }
        }

        // Check to see if ConfigVersion property is set
        internal bool IsSetConfigVersion()
        {
            return this._configVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date the configuration was created.
        /// </para>
        /// </summary>
        public long CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the security configuration.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The timestamp of when the configuration was last modified.
        /// </para>
        /// </summary>
        public long LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SamlOptions. 
        /// <para>
        /// SAML options for the security configuration in the form of a key-value map.
        /// </para>
        /// </summary>
        public SamlConfigOptions SamlOptions
        {
            get { return this._samlOptions; }
            set { this._samlOptions = value; }
        }

        // Check to see if SamlOptions property is set
        internal bool IsSetSamlOptions()
        {
            return this._samlOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of security configuration.
        /// </para>
        /// </summary>
        public SecurityConfigType Type
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