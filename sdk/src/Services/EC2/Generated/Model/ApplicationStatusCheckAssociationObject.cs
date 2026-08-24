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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _applicationStatusCheckId;
        private AssociationTypeEnum _associationType;
        private string _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property ApplicationStatusCheckId. 
        /// <para>
        /// The ID of the application status check.
        /// </para>
        /// </summary>
        public string ApplicationStatusCheckId
        {
            get { return this._applicationStatusCheckId; }
            set { this._applicationStatusCheckId = value; }
        }

        // Check to see if ApplicationStatusCheckId property is set
        internal bool IsSetApplicationStatusCheckId()
        {
            return this._applicationStatusCheckId != null;
        }

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
        public AssociationTypeEnum AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the association. This value is present only for tag-based associations,
        /// where it contains the tag key. For instance-based associations, this value is absent.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the association target. For tag-based associations, this is the tag
        /// value. For instance-based associations, this is the instance ID (for example, <c>i-0123456789abcdef0</c>).
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}