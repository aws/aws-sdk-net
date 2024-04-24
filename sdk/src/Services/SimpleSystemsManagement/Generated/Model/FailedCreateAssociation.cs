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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
        private CreateAssociationBatchRequestEntry _entry;
        private Fault _fault;
        private string _message;

        /// <summary>
        /// Gets and sets the property Entry. 
        /// <para>
        /// The association.
        /// </para>
        /// </summary>
        public CreateAssociationBatchRequestEntry Entry
        {
            get { return this._entry; }
            set { this._entry = value; }
        }

        // Check to see if Entry property is set
        internal bool IsSetEntry()
        {
            return this._entry != null;
        }

        /// <summary>
        /// Gets and sets the property Fault. 
        /// <para>
        /// The source of the failure.
        /// </para>
        /// </summary>
        public Fault Fault
        {
            get { return this._fault; }
            set { this._fault = value; }
        }

        // Check to see if Fault property is set
        internal bool IsSetFault()
        {
            return this._fault != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A description of the failure.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}