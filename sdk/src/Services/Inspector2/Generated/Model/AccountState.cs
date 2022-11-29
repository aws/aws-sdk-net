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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object with details the status of an Amazon Web Services account within your Amazon
    /// Inspector environment.
    /// </summary>
    public partial class AccountState
    {
        private string _accountId;
        private ResourceState _resourceState;
        private State _state;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceState. 
        /// <para>
        /// An object detailing which resources Amazon Inspector is enabled to scan for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceState ResourceState
        {
            get { return this._resourceState; }
            set { this._resourceState = value; }
        }

        // Check to see if ResourceState property is set
        internal bool IsSetResourceState()
        {
            return this._resourceState != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// An object detailing the status of Amazon Inspector for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}