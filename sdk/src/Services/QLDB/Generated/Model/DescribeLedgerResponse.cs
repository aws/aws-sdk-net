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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// This is the response object from the DescribeLedger operation.
    /// </summary>
    public partial class DescribeLedgerResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationDateTime;
        private bool? _deletionProtection;
        private string _name;
        private LedgerState _state;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1600)]
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time, in epoch time format, when the ledger was created. (Epoch time
        /// format is the number of seconds elapsed since 12:00:00 AM January 1, 1970 UTC.)
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// The flag that prevents a ledger from being deleted by any user. If not provided on
        /// ledger creation, this feature is enabled (<code>true</code>) by default.
        /// </para>
        ///  
        /// <para>
        /// If deletion protection is enabled, you must first disable it before you can delete
        /// the ledger using the QLDB API or the AWS Command Line Interface (AWS CLI). You can
        /// disable it by calling the <code>UpdateLedger</code> operation to set the flag to <code>false</code>.
        /// The QLDB console disables deletion protection for you when you use it to delete a
        /// ledger.
        /// </para>
        /// </summary>
        public bool DeletionProtection
        {
            get { return this._deletionProtection.GetValueOrDefault(); }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the ledger.
        /// </para>
        /// </summary>
        public LedgerState State
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