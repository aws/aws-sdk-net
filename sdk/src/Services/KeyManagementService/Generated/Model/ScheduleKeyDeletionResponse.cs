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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
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
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the ScheduleKeyDeletion operation.
    /// </summary>
    public partial class ScheduleKeyDeletionResponse : AmazonWebServiceResponse
    {
        private DateTime? _deletionDate;
        private string _keyId;
        private KeyState _keyState;
        private int? _pendingWindowInDays;

        /// <summary>
        /// Gets and sets the property DeletionDate. 
        /// <para>
        /// The date and time after which KMS deletes the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If the KMS key is a multi-Region primary key with replica keys, this field does not
        /// appear. The deletion date for the primary key isn't known until its last replica key
        /// is deleted.
        /// </para>
        /// </summary>
        public DateTime? DeletionDate
        {
            get { return this._deletionDate; }
            set { this._deletionDate = value; }
        }

        // Check to see if DeletionDate property is set
        internal bool IsSetDeletionDate()
        {
            return this._deletionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">key
        /// ARN</a>) of the KMS key whose deletion is scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyState. 
        /// <para>
        /// The current status of the KMS key.
        /// </para>
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public KeyState KeyState
        {
            get { return this._keyState; }
            set { this._keyState = value; }
        }

        // Check to see if KeyState property is set
        internal bool IsSetKeyState()
        {
            return this._keyState != null;
        }

        /// <summary>
        /// Gets and sets the property PendingWindowInDays. 
        /// <para>
        /// The waiting period before the KMS key is deleted. 
        /// </para>
        ///  
        /// <para>
        /// If the KMS key is a multi-Region primary key with replicas, the waiting period begins
        /// when the last of its replica keys is deleted. Otherwise, the waiting period begins
        /// immediately.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=365)]
        public int? PendingWindowInDays
        {
            get { return this._pendingWindowInDays; }
            set { this._pendingWindowInDays = value; }
        }

        // Check to see if PendingWindowInDays property is set
        internal bool IsSetPendingWindowInDays()
        {
            return this._pendingWindowInDays.HasValue; 
        }

    }
}