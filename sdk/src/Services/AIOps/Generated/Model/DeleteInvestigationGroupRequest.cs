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
 * Do not modify this file. This file is generated from the aiops-2018-05-10.normal.json service model.
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
namespace Amazon.AIOps.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteInvestigationGroup operation.
    /// Deletes the specified investigation group from your account. You can currently have
    /// one investigation group per Region in your account. After you delete an investigation
    /// group, you can later create a new investigation group in the same Region.
    /// </summary>
    public partial class DeleteInvestigationGroupRequest : AmazonAIOpsRequest
    {
        private string _identifier;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Specify either the name or the ARN of the investigation group that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}