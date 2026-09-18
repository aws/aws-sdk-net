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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteFunction operation. Deletes a function.
    /// MediaTailor prevents deletion of a function that is still referenced by a playback
    /// configuration or by another function. Remove all references before deleting. For more
    /// information about functions, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monetization-functions.html">Working
    /// with functions</a> in the <i>MediaTailor User Guide</i>.
    /// </summary>
    public partial class DeleteFunctionRequest : AmazonMediaTailorRequest
    {
        /// <summary>
        /// Gets and sets the property FunctionId. 
        /// <para>
        /// The identifier of the function to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FunctionId { get; set; }

        /// <summary>
        /// Checks to see if the FunctionId property is set.
        /// </summary>
        internal bool IsSetFunctionId() => this.FunctionId != null;
    }
}
