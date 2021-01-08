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
    /// Container for the parameters to the CreateWorkforce operation.
    /// Use this operation to create a workforce. This operation will return an error if a
    /// workforce already exists in the AWS Region that you specify. You can only create one
    /// workforce in each AWS Region per AWS account.
    /// 
    ///  
    /// <para>
    /// If you want to create a new workforce in an AWS Region where a workforce already exists,
    /// use the API operation to delete the existing workforce and then use <code>CreateWorkforce</code>
    /// to create a new workforce.
    /// </para>
    ///  
    /// <para>
    /// To create a private workforce using Amazon Cognito, you must specify a Cognito user
    /// pool in <code>CognitoConfig</code>. You can also create an Amazon Cognito workforce
    /// using the Amazon SageMaker console. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private.html">
    /// Create a Private Workforce (Amazon Cognito)</a>.
    /// </para>
    ///  
    /// <para>
    /// To create a private workforce using your own OIDC Identity Provider (IdP), specify
    /// your IdP configuration in <code>OidcConfig</code>. Your OIDC IdP must support <i>groups</i>
    /// because groups are used by Ground Truth and Amazon A2I to create work teams. For more
    /// information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sms-workforce-create-private-oidc.html">
    /// Create a Private Workforce (OIDC IdP)</a>.
    /// </para>
    /// </summary>
    public partial class CreateWorkforceRequest : AmazonSageMakerRequest
    {
        private CognitoConfig _cognitoConfig;
        private OidcConfig _oidcConfig;
        private SourceIpConfig _sourceIpConfig;
        private List<Tag> _tags = new List<Tag>();
        private string _workforceName;

        /// <summary>
        /// Gets and sets the property CognitoConfig. 
        /// <para>
        /// Use this parameter to configure an Amazon Cognito private workforce. A single Cognito
        /// workforce is created using and corresponds to a single <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">
        /// Amazon Cognito user pool</a>.
        /// </para>
        ///  
        /// <para>
        /// Do not use <code>OidcConfig</code> if you specify values for <code>CognitoConfig</code>.
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
        /// Gets and sets the property OidcConfig. 
        /// <para>
        /// Use this parameter to configure a private workforce using your own OIDC Identity Provider.
        /// </para>
        ///  
        /// <para>
        /// Do not use <code>CognitoConfig</code> if you specify values for <code>OidcConfig</code>.
        /// </para>
        /// </summary>
        public OidcConfig OidcConfig
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs that contain metadata to help you categorize and organize
        /// our workforce. Each tag consists of a key and a value, both of which you define.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
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