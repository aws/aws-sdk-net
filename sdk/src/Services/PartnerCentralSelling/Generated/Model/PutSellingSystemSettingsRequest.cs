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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Container for the parameters to the PutSellingSystemSettings operation.
    /// Updates the currently set system settings, which include the IAM Role used for resource
    /// snapshot jobs.
    /// </summary>
    public partial class PutSellingSystemSettingsRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _resourceSnapshotJobRoleIdentifier;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which the settings will be updated. Acceptable values include
        /// <c>AWS</c> for production and <c>Sandbox</c> for testing environments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSnapshotJobRoleIdentifier. 
        /// <para>
        /// Specifies the ARN of the IAM Role used for resource snapshot job executions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ResourceSnapshotJobRoleIdentifier
        {
            get { return this._resourceSnapshotJobRoleIdentifier; }
            set { this._resourceSnapshotJobRoleIdentifier = value; }
        }

        // Check to see if ResourceSnapshotJobRoleIdentifier property is set
        internal bool IsSetResourceSnapshotJobRoleIdentifier()
        {
            return this._resourceSnapshotJobRoleIdentifier != null;
        }

    }
}