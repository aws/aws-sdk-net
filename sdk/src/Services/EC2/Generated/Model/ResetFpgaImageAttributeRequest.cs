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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the ResetFpgaImageAttribute operation.
    /// Resets the specified attribute of the specified Amazon FPGA Image (AFI) to its default
    /// value. You can only reset the load permission attribute.
    /// </summary>
    public partial class ResetFpgaImageAttributeRequest : AmazonEC2Request
    {
        private ResetFpgaImageAttributeName _attribute;
        private string _fpgaImageId;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The attribute.
        /// </para>
        /// </summary>
        public ResetFpgaImageAttributeName Attribute
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
        /// Gets and sets the property FpgaImageId. 
        /// <para>
        /// The ID of the AFI.
        /// </para>
        /// </summary>
        public string FpgaImageId
        {
            get { return this._fpgaImageId; }
            set { this._fpgaImageId = value; }
        }

        // Check to see if FpgaImageId property is set
        internal bool IsSetFpgaImageId()
        {
            return this._fpgaImageId != null;
        }

    }
}