/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Container for the parameters to the ResetImageAttribute operation.
    /// Resets an attribute of an AMI to its default value.
    /// 
    ///  <note>
    /// <para>
    ///  The productCodes attribute can't be reset. 
    /// </para>
    /// </note>
    /// </summary>
    public partial class ResetImageAttributeRequest : AmazonEC2Request
    {
        private ResetImageAttributeName _attribute;
        private string _imageId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ResetImageAttributeRequest() { }

        /// <summary>
        /// Instantiates ResetImageAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI.</param>
        /// <param name="attribute">The attribute to reset (currently you can only reset the launch permission attribute).</param>
        public ResetImageAttributeRequest(string imageId, ResetImageAttributeName attribute)
        {
            _imageId = imageId;
            _attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The attribute to reset (currently you can only reset the launch permission attribute).
        /// </para>
        /// </summary>
        public ResetImageAttributeName Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

    }
}