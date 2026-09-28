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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Reference data.
    /// </summary>
    public partial class DataReference
    {
        /// <summary>
        /// Gets and sets the property ContentReference.
        /// </summary>
        public ContentReference ContentReference { get; set; }

        /// <summary>
        /// Checks to see if the ContentReference property is set.
        /// </summary>
        internal bool IsSetContentReference() => this.ContentReference != null;

        /// <summary>
        /// Gets and sets the property GenerativeReference. 
        /// <para>
        /// Reference information about the generative content.
        /// </para>
        /// </summary>
        public GenerativeReference GenerativeReference { get; set; }

        /// <summary>
        /// Checks to see if the GenerativeReference property is set.
        /// </summary>
        internal bool IsSetGenerativeReference() => this.GenerativeReference != null;

        /// <summary>
        /// Gets and sets the property SuggestedMessageReference. 
        /// <para>
        /// Reference information for suggested messages.
        /// </para>
        /// </summary>
        public SuggestedMessageReference SuggestedMessageReference { get; set; }

        /// <summary>
        /// Checks to see if the SuggestedMessageReference property is set.
        /// </summary>
        internal bool IsSetSuggestedMessageReference() => this.SuggestedMessageReference != null;
    }
}
