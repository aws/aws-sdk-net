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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the output of a <a>DetachObject</a> operation.
    /// </summary>
    public partial class BatchDetachObject
    {
        /// <summary>
        /// Gets and sets the property BatchReferenceName. 
        /// <para>
        /// The batch reference name. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/transaction_support.html">Transaction
        /// Support</a> for more information.
        /// </para>
        /// </summary>
        public string BatchReferenceName { get; set; }

        /// <summary>
        /// Checks to see if the BatchReferenceName property is set.
        /// </summary>
        internal bool IsSetBatchReferenceName() => this.BatchReferenceName != null;

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The name of the link.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string LinkName { get; set; }

        /// <summary>
        /// Checks to see if the LinkName property is set.
        /// </summary>
        internal bool IsSetLinkName() => this.LinkName != null;

        /// <summary>
        /// Gets and sets the property ParentReference. 
        /// <para>
        /// Parent reference from which the object with the specified link name is detached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ObjectReference ParentReference { get; set; }

        /// <summary>
        /// Checks to see if the ParentReference property is set.
        /// </summary>
        internal bool IsSetParentReference() => this.ParentReference != null;
    }
}
