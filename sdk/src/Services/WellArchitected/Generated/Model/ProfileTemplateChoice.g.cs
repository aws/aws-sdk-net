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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A profile template choice.
    /// </summary>
    public partial class ProfileTemplateChoice
    {
        /// <summary>
        /// Gets and sets the property ChoiceDescription.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ChoiceDescription { get; set; }

        /// <summary>
        /// Checks to see if the ChoiceDescription property is set.
        /// </summary>
        internal bool IsSetChoiceDescription() => this.ChoiceDescription != null;

        /// <summary>
        /// Gets and sets the property ChoiceId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ChoiceId { get; set; }

        /// <summary>
        /// Checks to see if the ChoiceId property is set.
        /// </summary>
        internal bool IsSetChoiceId() => this.ChoiceId != null;

        /// <summary>
        /// Gets and sets the property ChoiceTitle.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ChoiceTitle { get; set; }

        /// <summary>
        /// Checks to see if the ChoiceTitle property is set.
        /// </summary>
        internal bool IsSetChoiceTitle() => this.ChoiceTitle != null;
    }
}
