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
    /// Container for the parameters to the CreateLakeFormationIdentityCenterConfiguration operation.
    /// Creates an IAM Identity Center connection with Lake Formation to allow IAM Identity
    /// Center users and groups to access Data Catalog resources.
    /// </summary>
    public partial class CreateLakeFormationIdentityCenterConfigurationRequest : AmazonLakeFormationRequest
    {
        private string _catalogId;
        private ExternalFilteringConfiguration _externalFiltering;
        private string _instanceArn;
        private List<DataLakePrincipal> _shareRecipients = AWSConfigs.InitializeCollections ? new List<DataLakePrincipal>() : null;

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
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the IAM Identity Center instance for which the operation will be executed.
        /// For more information about ARNs, see Amazon Resource Names (ARNs) and Amazon Web Services
        /// Service Namespaces in the Amazon Web Services General Reference.
        /// </para>
        /// </summary>
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ShareRecipients. 
        /// <para>
        /// A list of Amazon Web Services account IDs and/or Amazon Web Services organization/organizational
        /// unit ARNs that are allowed to access data managed by Lake Formation. 
        /// </para>
        ///  
        /// <para>
        /// If the <c>ShareRecipients</c> list includes valid values, a resource share is created
        /// with the principals you want to have access to the resources.
        /// </para>
        ///  
        /// <para>
        /// If the <c>ShareRecipients</c> value is null or the list is empty, no resource share
        /// is created.
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