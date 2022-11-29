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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about the management of a security standard.
    /// </summary>
    public partial class StandardsManagedBy
    {
        private string _company;
        private string _product;

        /// <summary>
        /// Gets and sets the property Company. 
        /// <para>
        /// An identifier for the company that manages a specific security standard. For existing
        /// standards, the value is equal to <code>Amazon Web Services</code>.
        /// </para>
        /// </summary>
        public string Company
        {
            get { return this._company; }
            set { this._company = value; }
        }

        // Check to see if Company property is set
        internal bool IsSetCompany()
        {
            return this._company != null;
        }

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// An identifier for the product that manages a specific security standard. For existing
        /// standards, the value is equal to the Amazon Web Services service that manages the
        /// standard.
        /// </para>
        /// </summary>
        public string Product
        {
            get { return this._product; }
            set { this._product = value; }
        }

        // Check to see if Product property is set
        internal bool IsSetProduct()
        {
            return this._product != null;
        }

    }
}