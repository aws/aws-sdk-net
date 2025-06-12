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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Container for the parameters to the PutTaxExemption operation.
    /// Adds the tax exemption for a single account or all accounts listed in a consolidated
    /// billing family. The IAM action is <c>tax:UpdateExemptions</c>.
    /// </summary>
    public partial class PutTaxExemptionRequest : AmazonTaxSettingsRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Authority _authority;
        private ExemptionCertificate _exemptionCertificate;
        private string _exemptionType;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        ///  The list of unique account identifiers. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=550)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Authority.
        /// </summary>
        [AWSProperty(Required=true)]
        public Authority Authority
        {
            get { return this._authority; }
            set { this._authority = value; }
        }

        // Check to see if Authority property is set
        internal bool IsSetAuthority()
        {
            return this._authority != null;
        }

        /// <summary>
        /// Gets and sets the property ExemptionCertificate.
        /// </summary>
        [AWSProperty(Required=true)]
        public ExemptionCertificate ExemptionCertificate
        {
            get { return this._exemptionCertificate; }
            set { this._exemptionCertificate = value; }
        }

        // Check to see if ExemptionCertificate property is set
        internal bool IsSetExemptionCertificate()
        {
            return this._exemptionCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property ExemptionType. 
        /// <para>
        /// The exemption type. Use the supported tax exemption type description. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string ExemptionType
        {
            get { return this._exemptionType; }
            set { this._exemptionType = value; }
        }

        // Check to see if ExemptionType property is set
        internal bool IsSetExemptionType()
        {
            return this._exemptionType != null;
        }

    }
}