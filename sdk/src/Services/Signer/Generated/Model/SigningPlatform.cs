/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Contains information about the signing configurations and parameters that is used
    /// to perform an AWS Signer job.
    /// </summary>
    public partial class SigningPlatform
    {
        private Category _category;
        private string _displayName;
        private int? _maxSizeInMB;
        private string _partner;
        private string _platformId;
        private SigningConfiguration _signingConfiguration;
        private SigningImageFormat _signingImageFormat;
        private string _target;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of an AWS Signer platform.
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
        /// The display name of an AWS Signer platform.
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
        /// The maximum size (in MB) of code that can be signed by a AWS Signer platform.
        /// </para>
        /// </summary>
        public int MaxSizeInMB
        {
            get { return this._maxSizeInMB.GetValueOrDefault(); }
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
        /// Any partner entities linked to an AWS Signer platform.
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
        /// The ID of an AWS Signer platform.
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
        /// Gets and sets the property SigningConfiguration. 
        /// <para>
        /// The configuration of an AWS Signer platform. This includes the designated hash algorithm
        /// and encryption algorithm of a signing platform.
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
        /// The signing image format that is used by an AWS Signer platform.
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
        /// The types of targets that can be signed by an AWS Signer platform.
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