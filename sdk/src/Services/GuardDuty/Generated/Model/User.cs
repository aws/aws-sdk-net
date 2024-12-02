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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private Account _account;
        private string _credentialUid;
        private string _name;
        private string _type;
        private string _uid;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// Contains information about the Amazon Web Services account.
        /// </para>
        /// </summary>
        public Account Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialUid. 
        /// <para>
        /// The credentials of the user ID.
        /// </para>
        /// </summary>
        public string CredentialUid
        {
            get { return this._credentialUid; }
            set { this._credentialUid = value; }
        }

        // Check to see if CredentialUid property is set
        internal bool IsSetCredentialUid()
        {
            return this._credentialUid != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

    }
}