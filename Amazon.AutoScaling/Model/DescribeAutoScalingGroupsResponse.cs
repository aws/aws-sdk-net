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
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Returns a full description of the AutoScalingGroups from the given list. This includes all Amazon EC2
    /// instances that are members of the group. If a list of names is not provided, then the full details of all
    /// AutoScalingGroups is returned.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DescribeAutoScalingGroupsResponse
    {
        private DescribeAutoScalingGroupsResult describeAutoScalingGroupsResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the DescribeAutoScalingGroupsResult property.
        /// Returns a full description of the AutoScalingGroups from the given list. This includes all Amazon EC2
        /// instances that are members of the group. If a list of names is not provided, then the full details of all
        /// AutoScalingGroups is returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "DescribeAutoScalingGroupsResult")]
        public DescribeAutoScalingGroupsResult DescribeAutoScalingGroupsResult
        {
            get { return this.describeAutoScalingGroupsResultField; }
            set { this.describeAutoScalingGroupsResultField = value; }
        }

        /// <summary>
        /// Sets the DescribeAutoScalingGroupsResult property
        /// </summary>
        /// <param name="describeAutoScalingGroupsResult">Returns a full description of the AutoScalingGroups from the given list. This includes all Amazon EC2
        /// instances that are members of the group. If a list of names is not provided, then the full details of all
        /// AutoScalingGroups is returned.</param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingGroupsResponse WithDescribeAutoScalingGroupsResult(DescribeAutoScalingGroupsResult describeAutoScalingGroupsResult)
        {
            this.describeAutoScalingGroupsResultField = describeAutoScalingGroupsResult;
            return this;
        }

        /// <summary>
        /// Checks if DescribeAutoScalingGroupsResult property is set
        /// </summary>
        /// <returns>true if DescribeAutoScalingGroupsResult property is set</returns>
        public bool IsSetDescribeAutoScalingGroupsResult()
        {
            return this.describeAutoScalingGroupsResultField != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Returns the request ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField; }
            set { this.responseMetadataField = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">Returns the request ID.</param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingGroupsResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this.responseMetadataField = responseMetadata;
            return this;
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public bool IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }

        /// <summary>
        /// XML Representation for this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }
    }
}
