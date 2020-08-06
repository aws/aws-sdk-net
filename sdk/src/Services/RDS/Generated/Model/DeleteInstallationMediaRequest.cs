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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInstallationMedia operation.
    /// Deletes the installation medium for a DB engine that requires an on-premises customer
    /// provided license, such as Microsoft SQL Server.
    /// </summary>
    public partial class DeleteInstallationMediaRequest : AmazonRDSRequest
    {
        private string _installationMediaId;

        /// <summary>
        /// Gets and sets the property InstallationMediaId. 
        /// <para>
        /// The installation medium ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstallationMediaId
        {
            get { return this._installationMediaId; }
            set { this._installationMediaId = value; }
        }

        // Check to see if InstallationMediaId property is set
        internal bool IsSetInstallationMediaId()
        {
            return this._installationMediaId != null;
        }

    }
}