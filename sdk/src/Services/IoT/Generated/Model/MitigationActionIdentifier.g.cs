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
    /// Information that identifies a mitigation action. This information is returned by ListMitigationActions.
    /// </summary>
    public partial class MitigationActionIdentifier
    {
        /// <summary>
        /// Gets and sets the property ActionArn. 
        /// <para>
        /// The IAM role ARN used to apply this mitigation action.
        /// </para>
        /// </summary>
        public string ActionArn { get; set; }

        /// <summary>
        /// Checks to see if the ActionArn property is set.
        /// </summary>
        internal bool IsSetActionArn() => this.ActionArn != null;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The friendly name of the mitigation action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when this mitigation action was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;
    }
}
