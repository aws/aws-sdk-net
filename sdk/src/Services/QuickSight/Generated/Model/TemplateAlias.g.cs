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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The template alias.
    /// </summary>
    public partial class TemplateAlias
    {
        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The display name of the template alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the template alias.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property TemplateVersionNumber. 
        /// <para>
        /// The version number of the template alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? TemplateVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the TemplateVersionNumber property is set.
        /// </summary>
        internal bool IsSetTemplateVersionNumber() => this.TemplateVersionNumber.HasValue;
    }
}
