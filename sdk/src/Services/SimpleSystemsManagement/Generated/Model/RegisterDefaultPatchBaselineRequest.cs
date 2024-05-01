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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterDefaultPatchBaseline operation.
    /// Defines the default patch baseline for the relevant operating system.
    /// 
    ///  
    /// <para>
    /// To reset the Amazon Web Services-predefined patch baseline as the default, specify
    /// the full patch baseline Amazon Resource Name (ARN) as the baseline ID value. For example,
    /// for CentOS, specify <c>arn:aws:ssm:us-east-2:733109147000:patchbaseline/pb-0574b43a65ea646ed</c>
    /// instead of <c>pb-0574b43a65ea646ed</c>.
    /// </para>
    /// </summary>
    public partial class RegisterDefaultPatchBaselineRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _baselineId;

        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the patch baseline that should be the default patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=128)]
        public string BaselineId
        {
            get { return this._baselineId; }
            set { this._baselineId = value; }
        }

        // Check to see if BaselineId property is set
        internal bool IsSetBaselineId()
        {
            return this._baselineId != null;
        }

    }
}