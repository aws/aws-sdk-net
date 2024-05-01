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
    /// Contains information about completed key material rotations.
    /// </summary>
    public partial class RotationsListEntry
    {
        private string _keyId;
        private DateTime? _rotationDate;
        private RotationType _rotationType;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Unique identifier of the key.
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
        /// Gets and sets the property RotationDate. 
        /// <para>
        /// Date and time that the key material rotation completed. Formatted as Unix time.
        /// </para>
        /// </summary>
        public DateTime RotationDate
        {
            get { return this._rotationDate.GetValueOrDefault(); }
            set { this._rotationDate = value; }
        }

        // Check to see if RotationDate property is set
        internal bool IsSetRotationDate()
        {
            return this._rotationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RotationType. 
        /// <para>
        /// Identifies whether the key material rotation was a scheduled <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotating-keys-enable-disable">automatic
        /// rotation</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotating-keys-on-demand">on-demand
        /// rotation</a>.
        /// </para>
        /// </summary>
        public RotationType RotationType
        {
            get { return this._rotationType; }
            set { this._rotationType = value; }
        }

        // Check to see if RotationType property is set
        internal bool IsSetRotationType()
        {
            return this._rotationType != null;
        }

    }
}