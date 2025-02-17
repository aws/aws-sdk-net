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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The configuration for associating a package with a domain.
    /// </summary>
    public partial class PackageAssociationConfiguration
    {
        private KeyStoreAccessOption _keyStoreAccessOption;

        /// <summary>
        /// Gets and sets the property KeyStoreAccessOption. 
        /// <para>
        /// The configuration parameters to enable accessing the key store required by the package.
        /// </para>
        /// </summary>
        public KeyStoreAccessOption KeyStoreAccessOption
        {
            get { return this._keyStoreAccessOption; }
            set { this._keyStoreAccessOption = value; }
        }

        // Check to see if KeyStoreAccessOption property is set
        internal bool IsSetKeyStoreAccessOption()
        {
            return this._keyStoreAccessOption != null;
        }

    }
}