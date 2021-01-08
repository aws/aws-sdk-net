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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A list of user groups that exist in your OIDC Identity Provider (IdP). One to ten
    /// groups can be used to create a single private work team. When you add a user group
    /// to the list of <code>Groups</code>, you can add that user group to one or more private
    /// work teams. If you add a user group to a private work team, all workers in that user
    /// group are added to the work team.
    /// </summary>
    public partial class OidcMemberDefinition
    {
        private List<string> _groups = new List<string>();

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// A list of comma seperated strings that identifies user groups in your OIDC IdP. Each
        /// user group is made up of a group of private workers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

    }
}