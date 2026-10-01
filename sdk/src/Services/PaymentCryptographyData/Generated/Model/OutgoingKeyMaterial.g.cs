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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameter information of the outgoing TR31WrappedKeyBlock containing the transaction
    /// key.
    /// </summary>
    public partial class OutgoingKeyMaterial
    {
        /// <summary>
        /// Gets and sets the property Tr31KeyBlock. 
        /// <para>
        /// Parameter information of the TR31WrappedKeyBlock containing the transaction key wrapped
        /// using a KEK.
        /// </para>
        /// </summary>
        public OutgoingTr31KeyBlock Tr31KeyBlock { get; set; }

        /// <summary>
        /// Checks to see if the Tr31KeyBlock property is set.
        /// </summary>
        internal bool IsSetTr31KeyBlock() => this.Tr31KeyBlock != null;
    }
}
