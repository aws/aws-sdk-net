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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetSensitivityInspectionTemplate operation.
    /// </summary>
    public partial class GetSensitivityInspectionTemplateResponse : AmazonWebServiceResponse
    {
        private string _description;
        private SensitivityInspectionTemplateExcludes _excludes;
        private SensitivityInspectionTemplateIncludes _includes;
        private string _name;
        private string _sensitivityInspectionTemplateId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the template.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Excludes.  
        /// <para>
        /// The managed data identifiers that are explicitly excluded (not used) when analyzing
        /// data.
        /// </para>
        /// </summary>
        public SensitivityInspectionTemplateExcludes Excludes
        {
            get { return this._excludes; }
            set { this._excludes = value; }
        }

        // Check to see if Excludes property is set
        internal bool IsSetExcludes()
        {
            return this._excludes != null;
        }

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// The allow lists, custom data identifiers, and managed data identifiers that are included
        /// (used) when analyzing data.
        /// </para>
        /// </summary>
        public SensitivityInspectionTemplateIncludes Includes
        {
            get { return this._includes; }
            set { this._includes = value; }
        }

        // Check to see if Includes property is set
        internal bool IsSetIncludes()
        {
            return this._includes != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the template: automated-sensitive-data-discovery.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SensitivityInspectionTemplateId. 
        /// <para>
        /// The unique identifier for the template.
        /// </para>
        /// </summary>
        public string SensitivityInspectionTemplateId
        {
            get { return this._sensitivityInspectionTemplateId; }
            set { this._sensitivityInspectionTemplateId = value; }
        }

        // Check to see if SensitivityInspectionTemplateId property is set
        internal bool IsSetSensitivityInspectionTemplateId()
        {
            return this._sensitivityInspectionTemplateId != null;
        }

    }
}