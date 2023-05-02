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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// The ID for the provisioned product resources that are part of a resource group.
    /// </summary>
    public partial class EngineWorkflowResourceIdentifier
    {
        private UniqueTagResourceIdentifier _uniqueTag;

        /// <summary>
        /// Gets and sets the property UniqueTag. 
        /// <para>
        ///  The unique key-value pair for a tag that identifies provisioned product resources.
        /// 
        /// </para>
        /// </summary>
        public UniqueTagResourceIdentifier UniqueTag
        {
            get { return this._uniqueTag; }
            set { this._uniqueTag = value; }
        }

        // Check to see if UniqueTag property is set
        internal bool IsSetUniqueTag()
        {
            return this._uniqueTag != null;
        }

    }
}