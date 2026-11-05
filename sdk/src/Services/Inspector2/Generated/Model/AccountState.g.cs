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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object with details the status of an Amazon Web Services account within your Amazon
    /// Inspector environment.
    /// </summary>
    public partial class AccountState
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ResourceState. 
        /// <para>
        /// An object detailing which resources Amazon Inspector is enabled to scan for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceState ResourceState { get; set; }

        /// <summary>
        /// Checks to see if the ResourceState property is set.
        /// </summary>
        internal bool IsSetResourceState() => this.ResourceState != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// An object detailing the status of Amazon Inspector for the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public State State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
