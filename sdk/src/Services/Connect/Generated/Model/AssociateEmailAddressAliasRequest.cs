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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateEmailAddressAlias operation.
    /// Associates an email address alias with an existing email address in an Amazon Connect
    /// instance. This creates a forwarding relationship where emails sent to the alias email
    /// address are automatically forwarded to the primary email address. 
    /// 
    ///  
    /// <para>
    ///  <b>Use cases</b> 
    /// </para>
    ///  
    /// <para>
    /// Following are common uses cases for this API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Unified customer support</b>: Create multiple entry points (for example, support@example.com,
    /// help@example.com, customercare@example.com) that all forward to a single agent queue
    /// for streamlined management.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Department consolidation</b>: Forward emails from legacy department addresses
    /// (for example, sales@example.com, info@example.com) to a centralized customer service
    /// email during organizational restructuring.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Brand management</b>: Enable you to use familiar brand-specific email addresses
    /// that forward to the appropriate Amazon Connect instance email address.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Important things to know</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Each email address can have a maximum of one alias. You cannot create multiple aliases
    /// for the same email address. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the alias email address already receives direct emails, it continues to receive
    /// direct emails plus forwarded emails.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You cannot chain email aliases together (that is, create an alias of an alias).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <c>AssociateEmailAddressAlias</c> does not return the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A confirmation of the alias relationship details (you must call <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeEmailAddress.html">DescribeEmailAddress</a>
    /// to verify).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The timestamp of when the association occurred.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The status of the forwarding configuration.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Endpoints</b>: See <a href="https://docs.aws.amazon.com/general/latest/gr/connect_region.html">Amazon
    /// Connect endpoints and quotas</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DisassociateEmailAddressAlias.html">DisassociateEmailAddressAlias</a>:
    /// Removes the alias association between two email addresses in an Amazon Connect instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DescribeEmailAddress.html">DescribeEmailAddress</a>:
    /// View current alias configurations for an email address.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_SearchEmailAddresses.html">SearchEmailAddresses</a>:
    /// Find email addresses and their alias relationships across an instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateEmailAddress.html">CreateEmailAddress</a>:
    /// Create new email addresses that can participate in alias relationships.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DeleteEmailAddress.html">DeleteEmailAddress</a>:
    /// Remove email addresses (automatically removes any alias relationships).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_UpdateEmailAddressMetadata.html">UpdateEmailAddressMetadata</a>:
    /// Modify email address properties (does not affect alias relationships).
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AssociateEmailAddressAliasRequest : AmazonConnectRequest
    {
        private AliasConfiguration _aliasConfiguration;
        private string _clientToken;
        private string _emailAddressId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property AliasConfiguration. 
        /// <para>
        /// Configuration object that specifies which email address will serve as the alias. The
        /// specified email address must already exist in the Amazon Connect instance and cannot
        /// already be configured as an alias or have an alias of its own.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AliasConfiguration AliasConfiguration
        {
            get { return this._aliasConfiguration; }
            set { this._aliasConfiguration = value; }
        }

        // Check to see if AliasConfiguration property is set
        internal bool IsSetAliasConfiguration()
        {
            return this._aliasConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddressId. 
        /// <para>
        /// The identifier of the email address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EmailAddressId
        {
            get { return this._emailAddressId; }
            set { this._emailAddressId = value; }
        }

        // Check to see if EmailAddressId property is set
        internal bool IsSetEmailAddressId()
        {
            return this._emailAddressId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}