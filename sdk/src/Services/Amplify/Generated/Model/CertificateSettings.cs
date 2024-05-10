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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The type of SSL/TLS certificate to use for your custom domain. If a certificate type
    /// isn't specified, Amplify uses the default <c>AMPLIFY_MANAGED</c> certificate.
    /// </summary>
    public partial class CertificateSettings
    {
        private string _customCertificateArn;
        private CertificateType _type;

        /// <summary>
        /// Gets and sets the property CustomCertificateArn. 
        /// <para>
        /// The Amazon resource name (ARN) for the custom certificate that you have already added
        /// to Certificate Manager in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// This field is required only when the certificate type is <c>CUSTOM</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string CustomCertificateArn
        {
            get { return this._customCertificateArn; }
            set { this._customCertificateArn = value; }
        }

        // Check to see if CustomCertificateArn property is set
        internal bool IsSetCustomCertificateArn()
        {
            return this._customCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The certificate type.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>AMPLIFY_MANAGED</c> to use the default certificate that Amplify provisions
        /// for you.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>CUSTOM</c> to use your own certificate that you have already added to Certificate
        /// Manager in your Amazon Web Services account. Make sure you request (or import) the
        /// certificate in the US East (N. Virginia) Region (us-east-1). For more information
        /// about using ACM, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// certificates into Certificate Manager</a> in the <i>ACM User guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}