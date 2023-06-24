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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains information about the delegated administrator.
    /// </summary>
    public partial class DelegatedAdministrator
    {
        private string _arn;
        private DateTime? _delegationEnabledDate;
        private string _email;
        private string _id;
        private AccountJoinedMethod _joinedMethod;
        private DateTime? _joinedTimestamp;
        private string _name;
        private AccountStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the delegated administrator's account.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DelegationEnabledDate. 
        /// <para>
        /// The date when the account was made a delegated administrator.
        /// </para>
        /// </summary>
        public DateTime DelegationEnabledDate
        {
            get { return this._delegationEnabledDate.GetValueOrDefault(); }
            set { this._delegationEnabledDate = value; }
        }

        // Check to see if DelegationEnabledDate property is set
        internal bool IsSetDelegationEnabledDate()
        {
            return this._delegationEnabledDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address that is associated with the delegated administrator's Amazon Web
        /// Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=6, Max=64)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) of the delegated administrator's account.
        /// </para>
        /// </summary>
        [AWSProperty(Max=12)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property JoinedMethod. 
        /// <para>
        /// The method by which the delegated administrator's account joined the organization.
        /// </para>
        /// </summary>
        public AccountJoinedMethod JoinedMethod
        {
            get { return this._joinedMethod; }
            set { this._joinedMethod = value; }
        }

        // Check to see if JoinedMethod property is set
        internal bool IsSetJoinedMethod()
        {
            return this._joinedMethod != null;
        }

        /// <summary>
        /// Gets and sets the property JoinedTimestamp. 
        /// <para>
        /// The date when the delegated administrator's account became a part of the organization.
        /// </para>
        /// </summary>
        public DateTime JoinedTimestamp
        {
            get { return this._joinedTimestamp.GetValueOrDefault(); }
            set { this._joinedTimestamp = value; }
        }

        // Check to see if JoinedTimestamp property is set
        internal bool IsSetJoinedTimestamp()
        {
            return this._joinedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the delegated administrator's account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the delegated administrator's account in the organization.
        /// </para>
        /// </summary>
        public AccountStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}