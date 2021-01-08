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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A single private workforce, which is automatically created when you create your first
    /// private work team. You can create one private work force in each AWS Region. By default,
    /// any workforce-related API operation used in a specific region will apply to the workforce
    /// created in that region. To learn how to create a private workforce, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private.html">Create
    /// a Private Workforce</a>.
    /// </summary>
    public partial class Workforce
    {
        private CognitoConfig _cognitoConfig;
        private DateTime? _createDate;
        private DateTime? _lastUpdatedDate;
        private OidcConfigForResponse _oidcConfig;
        private SourceIpConfig _sourceIpConfig;
        private string _subDomain;
        private string _workforceArn;
        private string _workforceName;

        /// <summary>
        /// Gets and sets the property CognitoConfig. 
        /// <para>
        /// The configuration of an Amazon Cognito workforce. A single Cognito workforce is created
        /// using and corresponds to a single <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">
        /// Amazon Cognito user pool</a>.
        /// </para>
        /// </summary>
        public CognitoConfig CognitoConfig
        {
            get { return this._cognitoConfig; }
            set { this._cognitoConfig = value; }
        }

        // Check to see if CognitoConfig property is set
        internal bool IsSetCognitoConfig()
        {
            return this._cognitoConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date that the workforce is created.
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The most recent date that was used to successfully add one or more IP address ranges
        /// (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>)
        /// to a private workforce's allow list.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OidcConfig. 
        /// <para>
        /// The configuration of an OIDC Identity Provider (IdP) private workforce.
        /// </para>
        /// </summary>
        public OidcConfigForResponse OidcConfig
        {
            get { return this._oidcConfig; }
            set { this._oidcConfig = value; }
        }

        // Check to see if OidcConfig property is set
        internal bool IsSetOidcConfig()
        {
            return this._oidcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIpConfig. 
        /// <para>
        /// A list of one to ten IP address ranges (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>)
        /// to be added to the workforce allow list. By default, a workforce isn't restricted
        /// to specific IP addresses.
        /// </para>
        /// </summary>
        public SourceIpConfig SourceIpConfig
        {
            get { return this._sourceIpConfig; }
            set { this._sourceIpConfig = value; }
        }

        // Check to see if SourceIpConfig property is set
        internal bool IsSetSourceIpConfig()
        {
            return this._sourceIpConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SubDomain. 
        /// <para>
        /// The subdomain for your OIDC Identity Provider.
        /// </para>
        /// </summary>
        public string SubDomain
        {
            get { return this._subDomain; }
            set { this._subDomain = value; }
        }

        // Check to see if SubDomain property is set
        internal bool IsSetSubDomain()
        {
            return this._subDomain != null;
        }

        /// <summary>
        /// Gets and sets the property WorkforceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string WorkforceArn
        {
            get { return this._workforceArn; }
            set { this._workforceArn = value; }
        }

        // Check to see if WorkforceArn property is set
        internal bool IsSetWorkforceArn()
        {
            return this._workforceArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkforceName. 
        /// <para>
        /// The name of the private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string WorkforceName
        {
            get { return this._workforceName; }
            set { this._workforceName = value; }
        }

        // Check to see if WorkforceName property is set
        internal bool IsSetWorkforceName()
        {
            return this._workforceName != null;
        }

    }
}