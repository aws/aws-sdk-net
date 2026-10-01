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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// This is the response object from the PutSigningProfile operation.
    /// </summary>
    public partial class PutSigningProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the signing profile created.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ProfileVersion. 
        /// <para>
        /// The version of the signing profile being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string ProfileVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersion property is set.
        /// </summary>
        internal bool IsSetProfileVersion() => this.ProfileVersion != null;

        /// <summary>
        /// Gets and sets the property ProfileVersionArn. 
        /// <para>
        /// The signing profile ARN, including the profile version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProfileVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersionArn property is set.
        /// </summary>
        internal bool IsSetProfileVersionArn() => this.ProfileVersionArn != null;
    }
}
