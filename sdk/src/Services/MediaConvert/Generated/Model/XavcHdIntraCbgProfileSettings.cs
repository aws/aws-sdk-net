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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Required when you set Profile to the value XAVC_HD_INTRA_CBG.
    /// </summary>
    public partial class XavcHdIntraCbgProfileSettings
    {
        private XavcHdIntraCbgProfileClass _xavcClass;

        /// <summary>
        /// Gets and sets the property XavcClass. Specify the XAVC Intra HD (CBG) Class to set
        /// the bitrate of your output. Outputs of the same class have similar image quality over
        /// the operating points that are valid for that class.
        /// </summary>
        public XavcHdIntraCbgProfileClass XavcClass
        {
            get { return this._xavcClass; }
            set { this._xavcClass = value; }
        }

        // Check to see if XavcClass property is set
        internal bool IsSetXavcClass()
        {
            return this._xavcClass != null;
        }

    }
}