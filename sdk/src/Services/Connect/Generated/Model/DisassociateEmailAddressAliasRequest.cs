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
    /// Container for the parameters to the DisassociateEmailAddressAlias operation.
    /// Removes the alias association between two email addresses in an Amazon Connect instance.
    /// After disassociation, emails sent to the former alias email address are no longer
    /// forwarded to the primary email address. Both email addresses continue to exist independently
    /// and can receive emails directly.
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
    ///  <b>Department separation</b>: Remove alias relationships when splitting a consolidated
    /// support queue back into separate department-specific queues.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Email address retirement</b>: Cleanly remove forwarding relationships before decommissioning
    /// old email addresses.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Organizational restructuring</b>: Reconfigure email routing when business processes
    /// change and aliases are no longer needed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Important things to know</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Concurrent operations: This API uses distributed locking, so concurrent operations
    /// on the same email addresses may be temporarily blocked.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Emails sent to the former alias address are still delivered directly to that address
    /// if it exists.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You do not need to delete the email addresses after disassociation. Both addresses
    /// remain active independently.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After a successful disassociation, you can immediately create a new alias relationship
    /// with the same addresses.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 200 status means alias was successfully disassociated.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <c>DisassociateEmailAddressAlias</c> does not return the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Details in the response about the email that was disassociated. The response returns
    /// an empty body.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The timestamp of when the disassociation occurred.
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
    ///  <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_AssociateEmailAddressAlias.html">AssociateEmailAddressAlias</a>:
    /// Associates an email address alias with an existing email address in an Amazon Connect
    /// instance.
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
    public partial class DisassociateEmailAddressAliasRequest : AmazonConnectRequest
    {
        private AliasConfiguration _aliasConfiguration;
        private string _clientToken;
        private string _emailAddressId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property AliasConfiguration. 
        /// <para>
        /// Configuration object that specifies which alias relationship to remove. The alias
        /// association must currently exist between the primary email address and the specified
        /// alias email address.
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