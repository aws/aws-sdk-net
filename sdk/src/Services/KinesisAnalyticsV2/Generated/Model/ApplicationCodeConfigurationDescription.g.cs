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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes code configuration for an application.
    /// </summary>
    public partial class ApplicationCodeConfigurationDescription
    {
        /// <summary>
        /// Gets and sets the property CodeContentDescription. 
        /// <para>
        /// Describes details about the location and format of the application code.
        /// </para>
        /// </summary>
        public CodeContentDescription CodeContentDescription { get; set; }

        /// <summary>
        /// Checks to see if the CodeContentDescription property is set.
        /// </summary>
        internal bool IsSetCodeContentDescription() => this.CodeContentDescription != null;

        /// <summary>
        /// Gets and sets the property CodeContentType. 
        /// <para>
        /// Specifies whether the code content is in text or zip format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CodeContentType CodeContentType { get; set; }

        /// <summary>
        /// Checks to see if the CodeContentType property is set.
        /// </summary>
        internal bool IsSetCodeContentType() => this.CodeContentType != null;
    }
}
