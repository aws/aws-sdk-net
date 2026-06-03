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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutTenantSuppressionAttributes operation.
    /// Configure the suppression list preferences for a tenant. Use this operation to enable
    /// or disable tenant-level suppression, or to change the suppressed reasons for a tenant.
    /// 
    ///  
    /// <para>
    /// When you set the suppression scope to <c>TENANT</c>, Amazon SES maintains a separate
    /// suppression list for the tenant. When you set the scope to <c>ACCOUNT</c>, the tenant
    /// uses the account-level suppression list.
    /// </para>
    /// </summary>
    public partial class PutTenantSuppressionAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        private List<string> _suppressedReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SuppressionListScope _suppressionScope;
        private string _tenantName;

        /// <summary>
        /// Gets and sets the property SuppressedReasons. 
        /// <para>
        /// A list that contains the reasons that email addresses are automatically added to the
        /// suppression list for the tenant. This list can contain any or all of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLAINT</c> – Amazon SES adds an email address to the suppression list when
        /// a message sent to that address results in a complaint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BOUNCE</c> – Amazon SES adds an email address to the suppression list when a message
        /// sent to that address results in a hard bounce.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SuppressedReasons
        {
            get { return this._suppressedReasons; }
            set { this._suppressedReasons = value; }
        }

        // Check to see if SuppressedReasons property is set
        internal bool IsSetSuppressedReasons()
        {
            return this._suppressedReasons != null && (this._suppressedReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuppressionScope. 
        /// <para>
        /// The suppression scope for the tenant. Specify <c>TENANT</c> to use the tenant's own
        /// suppression list, or <c>ACCOUNT</c> to use the account-level suppression list.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't specify a suppression scope, the tenant defaults to <c>ACCOUNT</c> scope
        /// and uses the account-level suppression list.
        /// </para>
        ///  </note>
        /// </summary>
        public SuppressionListScope SuppressionScope
        {
            get { return this._suppressionScope; }
            set { this._suppressionScope = value; }
        }

        // Check to see if SuppressionScope property is set
        internal bool IsSetSuppressionScope()
        {
            return this._suppressionScope != null;
        }

        /// <summary>
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant to configure suppression list preferences for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string TenantName
        {
            get { return this._tenantName; }
            set { this._tenantName = value; }
        }

        // Check to see if TenantName property is set
        internal bool IsSetTenantName()
        {
            return this._tenantName != null;
        }

    }
}