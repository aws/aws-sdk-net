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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings associated with S3 destination
    /// </summary>
    public partial class S3DestinationSettings
    {
        private S3DestinationAccessControl _accessControl;
        private S3EncryptionSettings _encryption;

        /// <summary>
        /// Gets and sets the property AccessControl. Optional. Have MediaConvert automatically
        /// apply Amazon S3 access control for the outputs in this output group. When you don't
        /// use this setting, S3 automatically applies the default access control list PRIVATE.
        /// </summary>
        public S3DestinationAccessControl AccessControl
        {
            get { return this._accessControl; }
            set { this._accessControl = value; }
        }

        // Check to see if AccessControl property is set
        internal bool IsSetAccessControl()
        {
            return this._accessControl != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. Settings for how your job outputs are encrypted
        /// as they are uploaded to Amazon S3.
        /// </summary>
        public S3EncryptionSettings Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

    }
}