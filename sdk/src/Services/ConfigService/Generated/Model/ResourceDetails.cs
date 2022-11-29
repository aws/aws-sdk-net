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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns information about the resource being evaluated.
    /// </summary>
    public partial class ResourceDetails
    {
        private string _resourceConfiguration;
        private ResourceConfigurationSchemaType _resourceConfigurationSchemaType;
        private string _resourceId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ResourceConfiguration. 
        /// <para>
        /// The resource definition to be evaluated as per the resource configuration schema type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=51200)]
        public string ResourceConfiguration
        {
            get { return this._resourceConfiguration; }
            set { this._resourceConfiguration = value; }
        }

        // Check to see if ResourceConfiguration property is set
        internal bool IsSetResourceConfiguration()
        {
            return this._resourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceConfigurationSchemaType. 
        /// <para>
        /// The schema type of the resource configuration.
        /// </para>
        /// </summary>
        public ResourceConfigurationSchemaType ResourceConfigurationSchemaType
        {
            get { return this._resourceConfigurationSchemaType; }
            set { this._resourceConfigurationSchemaType = value; }
        }

        // Check to see if ResourceConfigurationSchemaType property is set
        internal bool IsSetResourceConfigurationSchemaType()
        {
            return this._resourceConfigurationSchemaType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// A unique resource ID for an evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=768)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource being evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceType
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