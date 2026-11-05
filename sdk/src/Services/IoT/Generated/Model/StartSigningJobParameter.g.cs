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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information required to start a signing job.
    /// </summary>
    public partial class StartSigningJobParameter
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The location to write the code-signed file.
        /// </para>
        /// </summary>
        public Destination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property SigningProfileName. 
        /// <para>
        /// The code-signing profile name.
        /// </para>
        /// </summary>
        public string SigningProfileName { get; set; }

        /// <summary>
        /// Checks to see if the SigningProfileName property is set.
        /// </summary>
        internal bool IsSetSigningProfileName() => this.SigningProfileName != null;

        /// <summary>
        /// Gets and sets the property SigningProfileParameter. 
        /// <para>
        /// Describes the code-signing profile.
        /// </para>
        /// </summary>
        public SigningProfileParameter SigningProfileParameter { get; set; }

        /// <summary>
        /// Checks to see if the SigningProfileParameter property is set.
        /// </summary>
        internal bool IsSetSigningProfileParameter() => this.SigningProfileParameter != null;
    }
}
