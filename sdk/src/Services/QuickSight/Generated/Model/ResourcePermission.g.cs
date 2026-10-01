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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Permission for the resource.
    /// </summary>
    public partial class ResourcePermission
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The IAM action to grant or revoke permissions on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<string> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the principal. This can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ARN of an Quick Sight user or group associated with a data source or dataset.
        /// (This is common.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of an Quick Sight user, group, or namespace associated with an analysis, dashboard,
        /// template, or theme. Namespace sharing is not supported for action connectors. (This
        /// is common.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ARN of an Amazon Web Services account root: This is an IAM ARN rather than a Quick
        /// Sight ARN. Use this option only to share resources (templates) across Amazon Web Services
        /// accounts. Account root sharing is not supported for action connectors. (This is less
        /// common.) 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;
    }
}
