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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the DescribeLakeFormationIdentityCenterConfiguration
    /// operation.
    /// </summary>
    public partial class DescribeLakeFormationIdentityCenterConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Lake Formation application integrated with IAM
        /// Identity Center.
        /// </para>
        /// </summary>
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your Lake Formation environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property ExternalFiltering. 
        /// <para>
        /// Indicates if external filtering is enabled.
        /// </para>
        /// </summary>
        public ExternalFilteringConfiguration ExternalFiltering { get; set; }

        /// <summary>
        /// Checks to see if the ExternalFiltering property is set.
        /// </summary>
        internal bool IsSetExternalFiltering() => this.ExternalFiltering != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connection.
        /// </para>
        /// </summary>
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceShare. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the RAM share.
        /// </para>
        /// </summary>
        public string ResourceShare { get; set; }

        /// <summary>
        /// Checks to see if the ResourceShare property is set.
        /// </summary>
        internal bool IsSetResourceShare() => this.ResourceShare != null;

        /// <summary>
        /// Gets and sets the property ServiceIntegrations. 
        /// <para>
        /// A list of service integrations for enabling trusted identity propagation with external
        /// services such as Redshift.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceIntegrationUnion> ServiceIntegrations { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceIntegrationUnion>() : null;

        /// <summary>
        /// Checks to see if the ServiceIntegrations property is set.
        /// </summary>
        internal bool IsSetServiceIntegrations() => this.ServiceIntegrations != null && (this.ServiceIntegrations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ShareRecipients. 
        /// <para>
        /// A list of Amazon Web Services account IDs or Amazon Web Services organization/organizational
        /// unit ARNs that are allowed to access data managed by Lake Formation. 
        /// </para>
        ///  
        /// <para>
        /// If the <c>ShareRecipients</c> list includes valid values, a resource share is created
        /// with the principals you want to have access to the resources as the <c>ShareRecipients</c>.
        /// </para>
        ///  
        /// <para>
        /// If the <c>ShareRecipients</c> value is null or the list is empty, no resource share
        /// is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<DataLakePrincipal> ShareRecipients { get; set; } = AWSConfigs.InitializeCollections ? new List<DataLakePrincipal>() : null;

        /// <summary>
        /// Checks to see if the ShareRecipients property is set.
        /// </summary>
        internal bool IsSetShareRecipients() => this.ShareRecipients != null && (this.ShareRecipients.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
