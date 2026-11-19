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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about an application status check association. Each item in the <c>associationSet</c>
    /// of a <c>DescribeApplicationStatusCheckAssociations</c> response is of this type.
    /// </summary>
    public partial class ApplicationStatusCheckAssociationObject
    {
        /// <summary>
        /// Gets and sets the property ApplicationStatusCheckId. 
        /// <para>
        /// The ID of the application status check.
        /// </para>
        /// </summary>
        public string ApplicationStatusCheckId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationStatusCheckId property is set.
        /// </summary>
        internal bool IsSetApplicationStatusCheckId() => this.ApplicationStatusCheckId != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        /// The type of target that the application status check is associated with. Possible
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>tag</c> – The check applies to current and future instances with a matching tag
        /// key-value pair.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-id</c> – The check applies to a specific instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AssociationTypeEnum AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the association. This value is present only for tag-based associations,
        /// where it contains the tag key. For instance-based associations, this value is absent.
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the association target. For tag-based associations, this is the tag
        /// value. For instance-based associations, this is the instance ID (for example, <c>i-0123456789abcdef0</c>).
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
