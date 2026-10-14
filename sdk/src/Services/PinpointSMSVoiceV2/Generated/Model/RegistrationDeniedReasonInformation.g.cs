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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Provides the reason a registration was rejected.
    /// </summary>
    public partial class RegistrationDeniedReasonInformation
    {
        /// <summary>
        /// Gets and sets the property DocumentationLink. 
        /// <para>
        /// The link to the document.
        /// </para>
        /// </summary>
        public string DocumentationLink { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationLink property is set.
        /// </summary>
        internal bool IsSetDocumentationLink() => this.DocumentationLink != null;

        /// <summary>
        /// Gets and sets the property DocumentationTitle. 
        /// <para>
        /// The title of the document.
        /// </para>
        /// </summary>
        public string DocumentationTitle { get; set; }

        /// <summary>
        /// Checks to see if the DocumentationTitle property is set.
        /// </summary>
        internal bool IsSetDocumentationTitle() => this.DocumentationTitle != null;

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// A long description of the rejection reason.
        /// </para>
        /// </summary>
        public string LongDescription { get; set; }

        /// <summary>
        /// Checks to see if the LongDescription property is set.
        /// </summary>
        internal bool IsSetLongDescription() => this.LongDescription != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason a registration was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A short description of the rejection reason.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;
    }
}
