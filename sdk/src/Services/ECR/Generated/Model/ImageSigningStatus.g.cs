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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code, which is only present if <c>status</c> is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A description of why signing the image failed. This field is only present if <c>status</c>
        /// is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property SigningProfileArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Signer signing profile used to sign the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string SigningProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the SigningProfileArn property is set.
        /// </summary>
        internal bool IsSetSigningProfileArn() => this.SigningProfileArn != null;

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
        public SigningStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
