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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// The signing status for an image. Each status corresponds to a signing profile.
    /// </summary>
    public partial class ImageSigningStatus
    {
        private string _failureCode;
        private string _failureReason;
        private string _signingProfileArn;
        private SigningStatus _status;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code, which is only present if <c>status</c> is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A description of why signing the image failed. This field is only present if <c>status</c>
        /// is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property SigningProfileArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Signer signing profile used to sign the image.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string SigningProfileArn
        {
            get { return this._signingProfileArn; }
            set { this._signingProfileArn = value; }
        }

        // Check to see if SigningProfileArn property is set
        internal bool IsSetSigningProfileArn()
        {
            return this._signingProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The image's signing status. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - Signing is currently in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> - The signature was successfully generated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Signing failed. See <c>failureCode</c> and <c>failureReason</c> for
        /// details.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SigningStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}