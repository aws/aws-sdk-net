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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains configuration information for the default behavior of the CRL Distribution
    /// Point (CDP) extension in certificates issued by your CA. This extension contains a
    /// link to download the CRL, so you can check whether a certificate has been revoked.
    /// To choose whether you want this extension omitted or not in certificates issued by
    /// your CA, you can set the <b>OmitExtension</b> parameter.
    /// </summary>
    public partial class CrlDistributionPointExtensionConfiguration
    {
        private bool? _omitExtension;

        /// <summary>
        /// Gets and sets the property OmitExtension. 
        /// <para>
        /// Configures whether the CRL Distribution Point extension should be populated with the
        /// default URL to the CRL. If set to <c>true</c>, then the CDP extension will not be
        /// present in any certificates issued by that CA unless otherwise specified through CSR
        /// or API passthrough.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only set this if you have another way to distribute the CRL Distribution Points ffor
        /// certificates issued by your CA, such as the Matter Distributed Compliance Ledger
        /// </para>
        ///  
        /// <para>
        /// This configuration cannot be enabled with a custom CNAME set.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? OmitExtension
        {
            get { return this._omitExtension; }
            set { this._omitExtension = value; }
        }

        // Check to see if OmitExtension property is set
        internal bool IsSetOmitExtension()
        {
            return this._omitExtension.HasValue; 
        }

    }
}