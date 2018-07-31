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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Information about the resource that was non-compliant with the audit check.
    /// </summary>
    public partial class NonCompliantResource
    {
        private Dictionary<string, string> _additionalInfo = new Dictionary<string, string>();
        private ResourceIdentifier _resourceIdentifier;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Additional information about the non-compliant resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null && this._additionalInfo.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Information identifying the non-compliant resource.
        /// </para>
        /// </summary>
        public ResourceIdentifier ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the non-compliant resource.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}