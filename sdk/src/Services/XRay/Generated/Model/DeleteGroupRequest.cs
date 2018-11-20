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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteGroup operation.
    /// Deletes a group resource.
    /// </summary>
    public partial class DeleteGroupRequest : AmazonXRayRequest
    {
        private string _groupARN;
        private string _groupName;

        /// <summary>
        /// Gets and sets the property GroupARN. 
        /// <para>
        /// The ARN of the group that was generated on creation.
        /// </para>
        /// </summary>
        public string GroupARN
        {
            get { return this._groupARN; }
            set { this._groupARN = value; }
        }

        // Check to see if GroupARN property is set
        internal bool IsSetGroupARN()
        {
            return this._groupARN != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The case-sensitive name of the group.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

    }
}