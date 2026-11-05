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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an application revision.
    /// </summary>
    public partial class RevisionInfo
    {
        /// <summary>
        /// Gets and sets the property GenericRevisionInfo. 
        /// <para>
        /// Information about an application revision, including usage details and associated
        /// deployment groups.
        /// </para>
        /// </summary>
        public GenericRevisionInfo GenericRevisionInfo { get; set; }

        /// <summary>
        /// Checks to see if the GenericRevisionInfo property is set.
        /// </summary>
        internal bool IsSetGenericRevisionInfo() => this.GenericRevisionInfo != null;

        /// <summary>
        /// Gets and sets the property RevisionLocation. 
        /// <para>
        /// Information about the location and type of an application revision.
        /// </para>
        /// </summary>
        public RevisionLocation RevisionLocation { get; set; }

        /// <summary>
        /// Checks to see if the RevisionLocation property is set.
        /// </summary>
        internal bool IsSetRevisionLocation() => this.RevisionLocation != null;
    }
}
