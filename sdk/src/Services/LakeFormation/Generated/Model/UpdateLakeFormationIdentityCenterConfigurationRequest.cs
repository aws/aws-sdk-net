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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLakeFormationIdentityCenterConfiguration operation.
    /// Updates the IAM Identity Center connection parameters.
    /// </summary>
    public partial class UpdateLakeFormationIdentityCenterConfigurationRequest : AmazonLakeFormationRequest
    {
        private ApplicationStatus _applicationStatus;
        private string _catalogId;
        private ExternalFilteringConfiguration _externalFiltering;

        /// <summary>
        /// Gets and sets the property ApplicationStatus. 
        /// <para>
        /// Allows to enable or disable the IAM Identity Center connection.
        /// </para>
        /// </summary>
        public ApplicationStatus ApplicationStatus
        {
            get { return this._applicationStatus; }
            set { this._applicationStatus = value; }
        }

        // Check to see if ApplicationStatus property is set
        internal bool IsSetApplicationStatus()
        {
            return this._applicationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// view definitions, and other control information to manage your Lake Formation environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ExternalFiltering. 
        /// <para>
        /// A list of the account IDs of Amazon Web Services accounts of third-party applications
        /// that are allowed to access data managed by Lake Formation.
        /// </para>
        /// </summary>
        public ExternalFilteringConfiguration ExternalFiltering
        {
            get { return this._externalFiltering; }
            set { this._externalFiltering = value; }
        }

        // Check to see if ExternalFiltering property is set
        internal bool IsSetExternalFiltering()
        {
            return this._externalFiltering != null;
        }

    }
}