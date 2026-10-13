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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A collection of settings that configure the Amazon Q experience within the domain.
    /// </summary>
    public partial class AmazonQSettings
    {
        /// <summary>
        /// Gets and sets the property QProfileArn. 
        /// <para>
        /// The ARN of the Amazon Q profile used within the domain.
        /// </para>
        /// </summary>
        public string QProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the QProfileArn property is set.
        /// </summary>
        internal bool IsSetQProfileArn() => this.QProfileArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Whether Amazon Q has been enabled within the domain.
        /// </para>
        /// </summary>
        public FeatureStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
