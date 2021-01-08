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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Permission for the resource.
    /// </summary>
    public partial class ResourcePermission
    {
        private List<string> _actions = new List<string>();
        private string _principal;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The IAM action to grant or revoke permissions on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the principal. This can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ARN of an Amazon QuickSight user or group associated with a data source or dataset.
        /// (This is common.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of an Amazon QuickSight user, group, or namespace associated with an analysis,
        /// dashboard, template, or theme. (This is common.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of an AWS account root: This is an IAM ARN rather than a QuickSight ARN. Use
        /// this option only to share resources (templates) across AWS accounts. (This is less
        /// common.) 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

    }
}