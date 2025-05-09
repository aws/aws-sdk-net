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
    /// This is the response object from the GetSellingSystemSettings operation.
    /// </summary>
    public partial class GetSellingSystemSettingsResponse : AmazonWebServiceResponse
    {
        private string _catalog;
        private string _resourceSnapshotJobRoleArn;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog in which the settings are defined. Acceptable values include
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
        /// Gets and sets the property ResourceSnapshotJobRoleArn. 
        /// <para>
        /// Specifies the ARN of the IAM Role used for resource snapshot job executions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ResourceSnapshotJobRoleArn
        {
            get { return this._resourceSnapshotJobRoleArn; }
            set { this._resourceSnapshotJobRoleArn = value; }
        }

        // Check to see if ResourceSnapshotJobRoleArn property is set
        internal bool IsSetResourceSnapshotJobRoleArn()
        {
            return this._resourceSnapshotJobRoleArn != null;
        }

    }
}