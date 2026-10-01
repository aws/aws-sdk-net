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

namespace Amazon.WorkSpacesThinClient.Model
{
    /// <summary>
    /// Describes a software set.
    /// </summary>
    public partial class SoftwareSetSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the software set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the software set.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ReleasedAt. 
        /// <para>
        /// The timestamp of when the software set was released.
        /// </para>
        /// </summary>
        public DateTime? ReleasedAt { get; set; }

        /// <summary>
        /// Checks to see if the ReleasedAt property is set.
        /// </summary>
        internal bool IsSetReleasedAt() => this.ReleasedAt.HasValue;

        /// <summary>
        /// Gets and sets the property SupportedUntil. 
        /// <para>
        /// The timestamp of the end of support for the software set.
        /// </para>
        /// </summary>
        public DateTime? SupportedUntil { get; set; }

        /// <summary>
        /// Checks to see if the SupportedUntil property is set.
        /// </summary>
        internal bool IsSetSupportedUntil() => this.SupportedUntil.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// An option to define if the software set has been validated.
        /// </para>
        /// </summary>
        public SoftwareSetValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the software set.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
