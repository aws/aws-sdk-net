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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// A ProfileObjectTypeTemplate in a list of ProfileObjectTypeTemplates.
    /// </summary>
    public partial class ListProfileObjectTypeTemplateItem
    {
        private string _sourceName;
        private string _sourceObject;
        private string _templateId;

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the source of the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceObject. 
        /// <para>
        /// The source of the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SourceObject
        {
            get { return this._sourceObject; }
            set { this._sourceObject = value; }
        }

        // Check to see if SourceObject property is set
        internal bool IsSetSourceObject()
        {
            return this._sourceObject != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique identifier for the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

    }
}