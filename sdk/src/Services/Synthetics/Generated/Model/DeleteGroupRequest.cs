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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteGroup operation.
    /// Deletes a group. The group doesn't need to be empty to be deleted. If there are canaries
    /// in the group, they are not deleted when you delete the group. 
    /// 
    ///  
    /// <para>
    /// Groups are a global resource that appear in all Regions, but the request to delete
    /// a group must be made from its home Region. You can find the home Region of a group
    /// within its ARN.
    /// </para>
    /// </summary>
    public partial class DeleteGroupRequest : AmazonSyntheticsRequest
    {
        private string _groupIdentifier;

        /// <summary>
        /// Gets and sets the property GroupIdentifier. 
        /// <para>
        /// Specifies which group to delete. You can specify the group name, the ARN, or the group
        /// ID as the <c>GroupIdentifier</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GroupIdentifier
        {
            get { return this._groupIdentifier; }
            set { this._groupIdentifier = value; }
        }

        // Check to see if GroupIdentifier property is set
        internal bool IsSetGroupIdentifier()
        {
            return this._groupIdentifier != null;
        }

    }
}