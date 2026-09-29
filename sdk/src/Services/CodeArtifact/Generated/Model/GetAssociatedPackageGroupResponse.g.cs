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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// This is the response object from the GetAssociatedPackageGroup operation.
    /// </summary>
    public partial class GetAssociatedPackageGroupResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// Describes the strength of the association between the package and package group. A
        /// strong match is also known as an exact match, and a weak match is known as a relative
        /// match.
        /// </para>
        /// </summary>
        public PackageGroupAssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property PackageGroup. 
        /// <para>
        /// The package group that is associated with the requested package.
        /// </para>
        /// </summary>
        public PackageGroupDescription PackageGroup { get; set; }

        /// <summary>
        /// Checks to see if the PackageGroup property is set.
        /// </summary>
        internal bool IsSetPackageGroup() => this.PackageGroup != null;
    }
}
