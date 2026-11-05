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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Contains properties for the Redshift IDC application.
    /// </summary>
    public partial class RedshiftIdcApplication
    {
        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The type of application being created. Valid values are <c>None</c> or <c>Lakehouse</c>.
        /// Use <c>Lakehouse</c> to enable Amazon Redshift federated permissions on cluster.
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property AuthorizedTokenIssuerList. 
        /// <para>
        /// The authorized token issuer list for the Amazon Redshift IAM Identity Center application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AuthorizedTokenIssuer> AuthorizedTokenIssuerList { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthorizedTokenIssuer>() : null;

        /// <summary>
        /// Checks to see if the AuthorizedTokenIssuerList property is set.
        /// </summary>
        internal bool IsSetAuthorizedTokenIssuerList() => this.AuthorizedTokenIssuerList != null && (this.AuthorizedTokenIssuerList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN for the Amazon Redshift IAM Identity Center application. It has the required
        /// permissions to be assumed and invoke the IDC Identity Center API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property IdcDisplayName. 
        /// <para>
        /// The display name for the Amazon Redshift IAM Identity Center application. It appears
        /// on the console.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string IdcDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the IdcDisplayName property is set.
        /// </summary>
        internal bool IsSetIdcDisplayName() => this.IdcDisplayName != null;

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The ARN for the IAM Identity Center instance that Redshift integrates with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string IdcInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdcInstanceArn() => this.IdcInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IdcManagedApplicationArn. 
        /// <para>
        /// The ARN for the Amazon Redshift IAM Identity Center application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string IdcManagedApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcManagedApplicationArn property is set.
        /// </summary>
        internal bool IsSetIdcManagedApplicationArn() => this.IdcManagedApplicationArn != null;

        /// <summary>
        /// Gets and sets the property IdcOnboardStatus. 
        /// <para>
        /// The onboarding status for the Amazon Redshift IAM Identity Center application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string IdcOnboardStatus { get; set; }

        /// <summary>
        /// Checks to see if the IdcOnboardStatus property is set.
        /// </summary>
        internal bool IsSetIdcOnboardStatus() => this.IdcOnboardStatus != null;

        /// <summary>
        /// Gets and sets the property IdentityNamespace. 
        /// <para>
        /// The identity namespace for the Amazon Redshift IAM Identity Center application. It
        /// determines which managed application verifies the connection token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string IdentityNamespace { get; set; }

        /// <summary>
        /// Checks to see if the IdentityNamespace property is set.
        /// </summary>
        internal bool IsSetIdentityNamespace() => this.IdentityNamespace != null;

        /// <summary>
        /// Gets and sets the property RedshiftIdcApplicationArn. 
        /// <para>
        /// The ARN for the Redshift application that integrates with IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string RedshiftIdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftIdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetRedshiftIdcApplicationArn() => this.RedshiftIdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property RedshiftIdcApplicationName. 
        /// <para>
        /// The name of the Redshift application in IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string RedshiftIdcApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftIdcApplicationName property is set.
        /// </summary>
        internal bool IsSetRedshiftIdcApplicationName() => this.RedshiftIdcApplicationName != null;

        /// <summary>
        /// Gets and sets the property ServiceIntegrations. 
        /// <para>
        /// A list of service integrations for the Redshift IAM Identity Center application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceIntegrationsUnion> ServiceIntegrations { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceIntegrationsUnion>() : null;

        /// <summary>
        /// Checks to see if the ServiceIntegrations property is set.
        /// </summary>
        internal bool IsSetServiceIntegrations() => this.ServiceIntegrations != null && (this.ServiceIntegrations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SsoTagKeys. 
        /// <para>
        /// A list of tags keys that Redshift Identity Center applications copy to IAM Identity
        /// Center. For each input key, the tag corresponding to the key-value pair is propagated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SsoTagKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SsoTagKeys property is set.
        /// </summary>
        internal bool IsSetSsoTagKeys() => this.SsoTagKeys != null && (this.SsoTagKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
