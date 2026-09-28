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
    /// Contains information about the signing configurations and parameters that are used
    /// to perform a code-signing job.
    /// </summary>
    public partial class SigningPlatform
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of a signing platform.
        /// </para>
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of a signing platform.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property MaxSizeInMB. 
        /// <para>
        /// The maximum size (in MB) of code that can be signed by a signing platform.
        /// </para>
        /// </summary>
        public int? MaxSizeInMB { get; set; }

        /// <summary>
        /// Checks to see if the MaxSizeInMB property is set.
        /// </summary>
        internal bool IsSetMaxSizeInMB() => this.MaxSizeInMB.HasValue;

        /// <summary>
        /// Gets and sets the property Partner. 
        /// <para>
        /// Any partner entities linked to a signing platform.
        /// </para>
        /// </summary>
        public string Partner { get; set; }

        /// <summary>
        /// Checks to see if the Partner property is set.
        /// </summary>
        internal bool IsSetPartner() => this.Partner != null;

        /// <summary>
        /// Gets and sets the property PlatformId. 
        /// <para>
        /// The ID of a signing platform.
        /// </para>
        /// </summary>
        public string PlatformId { get; set; }

        /// <summary>
        /// Checks to see if the PlatformId property is set.
        /// </summary>
        internal bool IsSetPlatformId() => this.PlatformId != null;

        /// <summary>
        /// Gets and sets the property RevocationSupported. 
        /// <para>
        /// Indicates whether revocation is supported for the platform.
        /// </para>
        /// </summary>
        public bool? RevocationSupported { get; set; }

        /// <summary>
        /// Checks to see if the RevocationSupported property is set.
        /// </summary>
        internal bool IsSetRevocationSupported() => this.RevocationSupported.HasValue;

        /// <summary>
        /// Gets and sets the property SigningConfiguration. 
        /// <para>
        /// The configuration of a signing platform. This includes the designated hash algorithm
        /// and encryption algorithm of a signing platform.
        /// </para>
        /// </summary>
        public SigningConfiguration SigningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SigningConfiguration property is set.
        /// </summary>
        internal bool IsSetSigningConfiguration() => this.SigningConfiguration != null;

        /// <summary>
        /// Gets and sets the property SigningImageFormat.
        /// </summary>
        public SigningImageFormat SigningImageFormat { get; set; }

        /// <summary>
        /// Checks to see if the SigningImageFormat property is set.
        /// </summary>
        internal bool IsSetSigningImageFormat() => this.SigningImageFormat != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The types of targets that can be signed by a signing platform.
        /// </para>
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
