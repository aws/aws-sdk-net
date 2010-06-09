/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-30
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Snapshot Attribute Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2009-11-30/", IsNullable = false)]
    public class DescribeSnapshotAttributeResult
    {
        private SnapshotAttribute snapshotAttributeField;

        /// <summary>
        /// Gets and sets the SnapshotAttribute property.
        /// list of snapshot attributes
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotAttribute")]
        public SnapshotAttribute SnapshotAttribute
        {
            get { return this.snapshotAttributeField ; }
            set { this.snapshotAttributeField = value; }
        }

        /// <summary>
        /// Sets the SnapshotAttribute property
        /// </summary>
        /// <param name="snapshotAttribute">list of snapshot attributes</param>
        /// <returns>this instance</returns>
        public DescribeSnapshotAttributeResult WithSnapshotAttribute(SnapshotAttribute snapshotAttribute)
        {
            this.snapshotAttributeField = snapshotAttribute;
            return this;
        }

        /// <summary>
        /// Checks if SnapshotAttribute property is set
        /// </summary>
        /// <returns>true if SnapshotAttribute property is set</returns>
        public bool IsSetSnapshotAttribute()
        {
            return this.snapshotAttributeField != null;
        }

    }
}
