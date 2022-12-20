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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableImageDeprecation operation.
    /// Enables deprecation of the specified AMI at the specified date and time.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-deprecate.html">Deprecate
    /// an AMI</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class EnableImageDeprecationRequest : AmazonEC2Request
    {
        private DateTime? _deprecateAt;
        private string _imageId;

        /// <summary>
        /// Gets and sets the property DeprecateAt. 
        /// <para>
        /// The date and time to deprecate the AMI, in UTC, in the following format: <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z.
        /// If you specify a value for seconds, Amazon EC2 rounds the seconds to the nearest minute.
        /// </para>
        ///  
        /// <para>
        /// You can’t specify a date in the past. The upper limit for <code>DeprecateAt</code>
        /// is 10 years from now, except for public AMIs, where the upper limit is 2 years from
        /// the creation date.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime DeprecateAt
        {
            get { return this._deprecateAt.GetValueOrDefault(); }
            set { this._deprecateAt = value; }
        }

        // Check to see if DeprecateAt property is set
        internal bool IsSetDeprecateAt()
        {
            return this._deprecateAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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