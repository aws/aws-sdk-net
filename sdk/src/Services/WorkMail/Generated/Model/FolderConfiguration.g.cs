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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// The configuration applied to an organization's folders by its retention policy.
    /// </summary>
    public partial class FolderConfiguration
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take on the folder contents at the end of the folder configuration period.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetentionAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The folder name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FolderName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The number of days for which the folder-configuration action applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 730)]
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;
    }
}
