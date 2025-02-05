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
    /// Container for the parameters to the StopResourceSnapshotJob operation.
    /// Stops a resource snapshot job. The job must be started prior to being stopped.
    /// </summary>
    public partial class StopResourceSnapshotJobRequest : AmazonPartnerCentralSellingRequest
    {
        private string _catalog;
        private string _resourceSnapshotJobIdentifier;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// Specifies the catalog related to the request. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS: Stops the request from the production AWS environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sandbox: Stops the request from a sandbox environment used for testing or development
        /// purposes.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property ResourceSnapshotJobIdentifier. 
        /// <para>
        /// The identifier of the job to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceSnapshotJobIdentifier
        {
            get { return this._resourceSnapshotJobIdentifier; }
            set { this._resourceSnapshotJobIdentifier = value; }
        }

        // Check to see if ResourceSnapshotJobIdentifier property is set
        internal bool IsSetResourceSnapshotJobIdentifier()
        {
            return this._resourceSnapshotJobIdentifier != null;
        }

    }
}