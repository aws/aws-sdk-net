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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// This is the response object from the GetSigningPlatform operation.
    /// </summary>
    public partial class GetSigningPlatformResponse : AmazonWebServiceResponse
    {
        private Category _category;
        private string _displayName;
        private int? _maxSizeInMB;
        private string _partner;
        private string _platformId;
        private bool? _revocationSupported;
        private SigningConfiguration _signingConfiguration;
        private SigningImageFormat _signingImageFormat;
        private string _target;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category type of the target signing platform.
        /// </para>
        /// </summary>
        public Category Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the target signing platform.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSizeInMB. 
        /// <para>
        /// The maximum size (in MB) of the payload that can be signed by the target platform.
        /// </para>
        /// </summary>
        public int? MaxSizeInMB
        {
            get { return this._maxSizeInMB; }
            set { this._maxSizeInMB = value; }
        }

        // Check to see if MaxSizeInMB property is set
        internal bool IsSetMaxSizeInMB()
        {
            return this._maxSizeInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Partner. 
        /// <para>
        /// A list of partner entities that use the target signing platform.
        /// </para>
        /// </summary>
        public string Partner
        {
            get { return this._partner; }
            set { this._partner = value; }
        }

        // Check to see if Partner property is set
        internal bool IsSetPartner()
        {
            return this._partner != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of the target signing platform.
        /// </para>
        /// </summary>
        public string PlatformId
        {
            get { return this._platformId; }
            set { this._platformId = value; }
        }

        // Check to see if PlatformId property is set
        internal bool IsSetPlatformId()
        {
            return this._platformId != null;
        }

        /// <summary>
        /// Gets and sets the property RevocationSupported. 
        /// <para>
        /// A flag indicating whether signatures generated for the signing platform can be revoked.
        /// </para>
        /// </summary>
        public bool? RevocationSupported
        {
            get { return this._revocationSupported; }
            set { this._revocationSupported = value; }
        }

        // Check to see if RevocationSupported property is set
        internal bool IsSetRevocationSupported()
        {
            return this._revocationSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SigningConfiguration. 
        /// <para>
        /// A list of configurations applied to the target platform at signing.
        /// </para>
        /// </summary>
        public SigningConfiguration SigningConfiguration
        {
            get { return this._signingConfiguration; }
            set { this._signingConfiguration = value; }
        }

        // Check to see if SigningConfiguration property is set
        internal bool IsSetSigningConfiguration()
        {
            return this._signingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SigningImageFormat. 
        /// <para>
        /// The format of the target platform's signing image.
        /// </para>
        /// </summary>
        public SigningImageFormat SigningImageFormat
        {
            get { return this._signingImageFormat; }
            set { this._signingImageFormat = value; }
        }

        // Check to see if SigningImageFormat property is set
        internal bool IsSetSigningImageFormat()
        {
            return this._signingImageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The validation template that is used by the target signing platform.
        /// </para>
        /// </summary>
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}