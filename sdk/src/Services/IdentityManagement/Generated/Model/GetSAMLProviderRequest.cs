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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetSAMLProvider operation.
    /// Returns the SAML provider metadocument that was uploaded when the IAM SAML provider
    /// resource object was created or updated.
    /// 
    ///  <note> 
    /// <para>
    /// This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetSAMLProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private string _samlProviderArn;

        /// <summary>
        /// Gets and sets the property SAMLProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider resource object in IAM to get
        /// information about.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SAMLProviderArn
        {
            get { return this._samlProviderArn; }
            set { this._samlProviderArn = value; }
        }

        // Check to see if SAMLProviderArn property is set
        internal bool IsSetSAMLProviderArn()
        {
            return this._samlProviderArn != null;
        }

    }
}