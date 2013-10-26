/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeImageAttribute operation.
    /// <para> The DescribeImageAttribute operation returns information about an attribute of an AMI. Only one attribute can be specified per call.
    /// </para>
    /// </summary>
    public partial class DescribeImageAttributeRequest : AmazonEC2Request
    {
        private string imageId;
        private ImageAttributeName attribute;


        /// <summary>
        /// The ID of the AMI whose attribute is to be described.
        ///  
        /// </summary>
        public string ImageId
        {
            get { return this.imageId; }
            set { this.imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this.imageId != null;
        }

        /// <summary>
        /// The name of the attribute to describe. Available attribute names: <c>productCodes</c>, <c>kernel</c>, <c>ramdisk</c>,
        /// <c>launchPermisson</c>, <c>blockDeviceMapping</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>description, kernel, ramdisk, launchPermission, productCodes, blockDeviceMapping</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ImageAttributeName Attribute
        {
            get { return this.attribute; }
            set { this.attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this.attribute != null;
        }

    }
}
    
