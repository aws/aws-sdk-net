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
    /// Each entry contains information about one of the key materials associated with a KMS
    /// key.
    /// </summary>
    public partial class RotationsListEntry
    {
        private ExpirationModelType _expirationModel;
        private ImportState _importState;
        private string _keyId;
        private string _keyMaterialDescription;
        private string _keyMaterialId;
        private KeyMaterialState _keyMaterialState;
        private DateTime? _rotationDate;
        private RotationType _rotationType;
        private DateTime? _validTo;

        /// <summary>
        /// Gets and sets the property ExpirationModel. 
        /// <para>
        /// Indicates if the key material is configured to automatically expire. There are two
        /// possible values for this field: <c>KEY_MATERIAL_EXPIRES</c> and <c>KEY_MATERIAL_DOES_NOT_EXPIRE</c>.
        /// For any key material that expires, the expiration date and time is indicated in <c>ValidTo</c>.
        /// This field is only present for symmetric encryption KMS keys with <c>EXTERNAL</c>
        /// origin.
        /// </para>
        /// </summary>
        public ExpirationModelType ExpirationModel
        {
            get { return this._expirationModel; }
            set { this._expirationModel = value; }
        }

        // Check to see if ExpirationModel property is set
        internal bool IsSetExpirationModel()
        {
            return this._expirationModel != null;
        }

        /// <summary>
        /// Gets and sets the property ImportState. 
        /// <para>
        /// Indicates if the key material is currently imported into KMS. It has two possible
        /// values: <c>IMPORTED</c> or <c>PENDING_IMPORT</c>. This field is only present for symmetric
        /// encryption KMS keys with <c>EXTERNAL</c> origin.
        /// </para>
        /// </summary>
        public ImportState ImportState
        {
            get { return this._importState; }
            set { this._importState = value; }
        }

        // Check to see if ImportState property is set
        internal bool IsSetImportState()
        {
            return this._importState != null;
        }

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
        /// Gets and sets the property KeyMaterialDescription. 
        /// <para>
        /// User-specified description of the key material. This field is only present for symmetric
        /// encryption KMS keys with <c>EXTERNAL</c> origin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string KeyMaterialDescription
        {
            get { return this._keyMaterialDescription; }
            set { this._keyMaterialDescription = value; }
        }

        // Check to see if KeyMaterialDescription property is set
        internal bool IsSetKeyMaterialDescription()
        {
            return this._keyMaterialDescription != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMaterialId. 
        /// <para>
        /// Unique identifier of the key material. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
        public string KeyMaterialId
        {
            get { return this._keyMaterialId; }
            set { this._keyMaterialId = value; }
        }

        // Check to see if KeyMaterialId property is set
        internal bool IsSetKeyMaterialId()
        {
            return this._keyMaterialId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyMaterialState. 
        /// <para>
        /// There are three possible values for this field: <c>CURRENT</c>, <c>NON_CURRENT</c>
        /// and <c>PENDING_ROTATION</c>. KMS uses <c>CURRENT</c> key material for both encryption
        /// and decryption and <c>NON_CURRENT</c> key material only for decryption. <c>PENDING_ROTATION</c>
        /// identifies key material that has been imported for on-demand key rotation but the
        /// rotation hasn't completed. Key material in <c>PENDING_ROTATION</c> is not permanently
        /// associated with the KMS key. You can delete this key material and import different
        /// key material in its place. The <c>PENDING_ROTATION</c> value is only used in symmetric
        /// encryption keys with imported key material. The other values, <c>CURRENT</c> and <c>NON_CURRENT</c>,
        /// are used for all KMS keys that support automatic or on-demand key rotation.
        /// </para>
        /// </summary>
        public KeyMaterialState KeyMaterialState
        {
            get { return this._keyMaterialState; }
            set { this._keyMaterialState = value; }
        }

        // Check to see if KeyMaterialState property is set
        internal bool IsSetKeyMaterialState()
        {
            return this._keyMaterialState != null;
        }

        /// <summary>
        /// Gets and sets the property RotationDate. 
        /// <para>
        /// Date and time that the key material rotation completed. Formatted as Unix time. This
        /// field is not present for the first key material or an imported key material in <c>PENDING_ROTATION</c>
        /// state.
        /// </para>
        /// </summary>
        public DateTime? RotationDate
        {
            get { return this._rotationDate; }
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
        /// Identifies whether the key material rotation was a scheduled <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
        /// rotation</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-on-demand.html">on-demand
        /// rotation</a>. This field is not present for the first key material or an imported
        /// key material in <c>PENDING_ROTATION</c> state.
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

        /// <summary>
        /// Gets and sets the property ValidTo. 
        /// <para>
        /// Date and time at which the key material expires. This field is only present for symmetric
        /// encryption KMS keys with <c>EXTERNAL</c> origin in rotation list entries with an <c>ExpirationModel</c>
        /// value of <c>KEY_MATERIAL_EXPIRES</c>.
        /// </para>
        /// </summary>
        public DateTime? ValidTo
        {
            get { return this._validTo; }
            set { this._validTo = value; }
        }

        // Check to see if ValidTo property is set
        internal bool IsSetValidTo()
        {
            return this._validTo.HasValue; 
        }

    }
}