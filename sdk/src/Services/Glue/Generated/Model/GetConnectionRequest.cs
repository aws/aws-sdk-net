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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetConnection operation.
    /// Retrieves a connection definition from the Data Catalog.
    /// </summary>
    public partial class GetConnectionRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private bool? _hidePassword;
        private string _name;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the connection resides. If none is provided, the
        /// AWS account ID is used by default.
        /// </para>
        /// </summary>
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property HidePassword. 
        /// <para>
        /// Allows you to retrieve the connection metadata without returning the password. For
        /// instance, the AWS Glue console uses this flag to retrieve the connection, and does
        /// not display the password. Set this parameter when the caller might not have permission
        /// to use the AWS KMS key to decrypt the password, but does have permission to access
        /// the rest of the connection properties.
        /// </para>
        /// </summary>
        public bool HidePassword
        {
            get { return this._hidePassword.GetValueOrDefault(); }
            set { this._hidePassword = value; }
        }

        // Check to see if HidePassword property is set
        internal bool IsSetHidePassword()
        {
            return this._hidePassword.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connection definition to retrieve.
        /// </para>
        /// </summary>
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