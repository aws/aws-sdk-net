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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountVdmAttributes operation.
    /// Update your Amazon SES account VDM attributes.
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class PutAccountVdmAttributesRequest : AmazonSimpleEmailServiceV2Request
    {
        private VdmAttributes _vdmAttributes;

        /// <summary>
        /// Gets and sets the property VdmAttributes. 
        /// <para>
        /// The VDM attributes that you wish to apply to your Amazon SES account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VdmAttributes VdmAttributes
        {
            get { return this._vdmAttributes; }
            set { this._vdmAttributes = value; }
        }

        // Check to see if VdmAttributes property is set
        internal bool IsSetVdmAttributes()
        {
            return this._vdmAttributes != null;
        }

    }
}