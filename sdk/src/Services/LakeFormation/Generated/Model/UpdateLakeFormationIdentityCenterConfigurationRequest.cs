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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<DataLakePrincipal> _shareRecipients = AWSConfigs.InitializeCollections ? new List<DataLakePrincipal>() : null;

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

        /// <summary>
        /// Gets and sets the property ShareRecipients. 
        /// <para>
        /// A list of Amazon Web Services account IDs or Amazon Web Services organization/organizational
        /// unit ARNs that are allowed to access to access data managed by Lake Formation. 
        /// </para>
        ///  
        /// <para>
        /// If the <c>ShareRecipients</c> list includes valid values, then the resource share
        /// is updated with the principals you want to have access to the resources.
        /// </para>
        ///  
        /// <para>
        /// If the <c>ShareRecipients</c> value is null, both the list of share recipients and
        /// the resource share remain unchanged.
        /// </para>
        ///  
        /// <para>
        /// If the <c>ShareRecipients</c> value is an empty list, then the existing share recipients
        /// list will be cleared, and the resource share will be deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<DataLakePrincipal> ShareRecipients
        {
            get { return this._shareRecipients; }
            set { this._shareRecipients = value; }
        }

        // Check to see if ShareRecipients property is set
        internal bool IsSetShareRecipients()
        {
            return this._shareRecipients != null && (this._shareRecipients.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}