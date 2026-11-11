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
    /// Container for the parameters to the DescribeImageAttribute operation. Describes the
    /// specified attribute of the specified AMI. You can specify only one attribute at a
    /// time. <note> <para> The order of the elements in the response, including those within
    /// nested structures, might vary. Applications should not assume the elements appear
    /// in a particular order. </para> </note>
    /// </summary>
    public partial class DescribeImageAttributeRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DescribeImageAttributeRequest() { }

        /// <summary>
        /// Instantiates DescribeImageAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI.</param>
        /// <param name="attribute">The AMI attribute.      <b>Note</b>: The <c>blockDeviceMapping</c> attribute is   deprecated. Using this attribute returns the <c>Client.AuthFailure</c> error. To get   information about the block device mappings for an AMI, describe the image instead.</param>
        public DescribeImageAttributeRequest(string imageId, ImageAttributeName attribute)
        {
            this.ImageId = imageId;
            this.Attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The AMI attribute.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note</b>: The <c>blockDeviceMapping</c> attribute is deprecated. Using this attribute
        /// returns the <c>Client.AuthFailure</c> error. To get information about the block device
        /// mappings for an AMI, describe the image instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageAttributeName Attribute { get; set; }

        /// <summary>
        /// Checks to see if the Attribute property is set.
        /// </summary>
        internal bool IsSetAttribute() => this.Attribute != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;
    }
}
