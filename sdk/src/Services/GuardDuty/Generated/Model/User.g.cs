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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the user involved in the attack sequence.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// Contains information about the Amazon Web Services account within which the activity
        /// took place. This is not necessarily the account that owns the user identity.
        /// </para>
        /// </summary>
        public Account Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property CredentialUid. 
        /// <para>
        /// The credentials of the user ID.
        /// </para>
        /// </summary>
        public string CredentialUid { get; set; }

        /// <summary>
        /// Checks to see if the CredentialUid property is set.
        /// </summary>
        internal bool IsSetCredentialUid() => this.CredentialUid != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;
    }
}
