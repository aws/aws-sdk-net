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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Container for the parameters to the ModifyRedshiftIdcApplication operation.
    /// Changes an existing Amazon Redshift IAM Identity Center application.
    /// </summary>
    public partial class ModifyRedshiftIdcApplicationRequest : AmazonRedshiftRequest
    {
        private List<AuthorizedTokenIssuer> _authorizedTokenIssuerList = AWSConfigs.InitializeCollections ? new List<AuthorizedTokenIssuer>() : null;
        private string _iamRoleArn;
        private string _idcDisplayName;
        private string _identityNamespace;
        private string _redshiftIdcApplicationArn;
        private List<ServiceIntegrationsUnion> _serviceIntegrations = AWSConfigs.InitializeCollections ? new List<ServiceIntegrationsUnion>() : null;

        /// <summary>
        /// Gets and sets the property AuthorizedTokenIssuerList. 
        /// <para>
        /// The authorized token issuer list for the Amazon Redshift IAM Identity Center application
        /// to change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AuthorizedTokenIssuer> AuthorizedTokenIssuerList
        {
            get { return this._authorizedTokenIssuerList; }
            set { this._authorizedTokenIssuerList = value; }
        }

        // Check to see if AuthorizedTokenIssuerList property is set
        internal bool IsSetAuthorizedTokenIssuerList()
        {
            return this._authorizedTokenIssuerList != null && (this._authorizedTokenIssuerList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The IAM role ARN associated with the Amazon Redshift IAM Identity Center application
        /// to change. It has the required permissions to be assumed and invoke the IDC Identity
        /// Center API.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdcDisplayName. 
        /// <para>
        /// The display name for the Amazon Redshift IAM Identity Center application to change.
        /// It appears on the console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string IdcDisplayName
        {
            get { return this._idcDisplayName; }
            set { this._idcDisplayName = value; }
        }

        // Check to see if IdcDisplayName property is set
        internal bool IsSetIdcDisplayName()
        {
            return this._idcDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityNamespace. 
        /// <para>
        /// The namespace for the Amazon Redshift IAM Identity Center application to change. It
        /// determines which managed application verifies the connection token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string IdentityNamespace
        {
            get { return this._identityNamespace; }
            set { this._identityNamespace = value; }
        }

        // Check to see if IdentityNamespace property is set
        internal bool IsSetIdentityNamespace()
        {
            return this._identityNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftIdcApplicationArn. 
        /// <para>
        /// The ARN for the Redshift application that integrates with IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string RedshiftIdcApplicationArn
        {
            get { return this._redshiftIdcApplicationArn; }
            set { this._redshiftIdcApplicationArn = value; }
        }

        // Check to see if RedshiftIdcApplicationArn property is set
        internal bool IsSetRedshiftIdcApplicationArn()
        {
            return this._redshiftIdcApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceIntegrations. 
        /// <para>
        /// A collection of service integrations associated with the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceIntegrationsUnion> ServiceIntegrations
        {
            get { return this._serviceIntegrations; }
            set { this._serviceIntegrations = value; }
        }

        // Check to see if ServiceIntegrations property is set
        internal bool IsSetServiceIntegrations()
        {
            return this._serviceIntegrations != null && (this._serviceIntegrations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}