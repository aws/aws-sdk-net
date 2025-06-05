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
    /// This is the response object from the GetKeyRotationStatus operation.
    /// </summary>
    public partial class GetKeyRotationStatusResponse : AmazonWebServiceResponse
    {
        private string _keyId;
        private bool? _keyRotationEnabled;
        private DateTime? _nextRotationDate;
        private DateTime? _onDemandRotationStartDate;
        private int? _rotationPeriodInDays;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the specified symmetric encryption KMS key.
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
        /// Gets and sets the property KeyRotationEnabled. 
        /// <para>
        /// A Boolean value that specifies whether key rotation is enabled.
        /// </para>
        /// </summary>
        public bool? KeyRotationEnabled
        {
            get { return this._keyRotationEnabled; }
            set { this._keyRotationEnabled = value; }
        }

        // Check to see if KeyRotationEnabled property is set
        internal bool IsSetKeyRotationEnabled()
        {
            return this._keyRotationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextRotationDate. 
        /// <para>
        /// The next date that KMS will automatically rotate the key material.
        /// </para>
        /// </summary>
        public DateTime? NextRotationDate
        {
            get { return this._nextRotationDate; }
            set { this._nextRotationDate = value; }
        }

        // Check to see if NextRotationDate property is set
        internal bool IsSetNextRotationDate()
        {
            return this._nextRotationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnDemandRotationStartDate. 
        /// <para>
        /// Identifies the date and time that an in progress on-demand rotation was initiated.
        /// </para>
        ///  
        /// <para>
        /// KMS uses a background process to perform rotations. As a result, there might be a
        /// slight delay between initiating on-demand key rotation and the rotation's completion.
        /// Once the on-demand rotation is complete, KMS removes this field from the response.
        /// You can use <a>ListKeyRotations</a> to view the details of the completed on-demand
        /// rotation.
        /// </para>
        /// </summary>
        public DateTime? OnDemandRotationStartDate
        {
            get { return this._onDemandRotationStartDate; }
            set { this._onDemandRotationStartDate = value; }
        }

        // Check to see if OnDemandRotationStartDate property is set
        internal bool IsSetOnDemandRotationStartDate()
        {
            return this._onDemandRotationStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RotationPeriodInDays. 
        /// <para>
        /// The number of days between each automatic rotation. The default value is 365 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=90, Max=2560)]
        public int? RotationPeriodInDays
        {
            get { return this._rotationPeriodInDays; }
            set { this._rotationPeriodInDays = value; }
        }

        // Check to see if RotationPeriodInDays property is set
        internal bool IsSetRotationPeriodInDays()
        {
            return this._rotationPeriodInDays.HasValue; 
        }

    }
}