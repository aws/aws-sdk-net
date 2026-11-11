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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes a failed association.
    /// </summary>
    public partial class FailedCreateAssociation
    {
        /// <summary>
        /// Gets and sets the property Entry. 
        /// <para>
        /// The association.
        /// </para>
        /// </summary>
        public CreateAssociationBatchRequestEntry Entry { get; set; }

        /// <summary>
        /// Checks to see if the Entry property is set.
        /// </summary>
        internal bool IsSetEntry() => this.Entry != null;

        /// <summary>
        /// Gets and sets the property Fault. 
        /// <para>
        /// The source of the failure.
        /// </para>
        /// </summary>
        public Fault Fault { get; set; }

        /// <summary>
        /// Checks to see if the Fault property is set.
        /// </summary>
        internal bool IsSetFault() => this.Fault != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the failure.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
