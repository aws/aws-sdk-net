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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the GetSensitivityInspectionTemplate operation.
    /// </summary>
    public partial class GetSensitivityInspectionTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the template.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Excludes. 
        /// <para>
        /// The managed data identifiers that are explicitly excluded (not used) when performing
        /// automated sensitive data discovery.
        /// </para>
        /// </summary>
        public SensitivityInspectionTemplateExcludes Excludes { get; set; }

        /// <summary>
        /// Checks to see if the Excludes property is set.
        /// </summary>
        internal bool IsSetExcludes() => this.Excludes != null;

        /// <summary>
        /// Gets and sets the property Includes. 
        /// <para>
        /// The allow lists, custom data identifiers, and managed data identifiers that are explicitly
        /// included (used) when performing automated sensitive data discovery.
        /// </para>
        /// </summary>
        public SensitivityInspectionTemplateIncludes Includes { get; set; }

        /// <summary>
        /// Checks to see if the Includes property is set.
        /// </summary>
        internal bool IsSetIncludes() => this.Includes != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the template: automated-sensitive-data-discovery.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SensitivityInspectionTemplateId. 
        /// <para>
        /// The unique identifier for the template.
        /// </para>
        /// </summary>
        public string SensitivityInspectionTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the SensitivityInspectionTemplateId property is set.
        /// </summary>
        internal bool IsSetSensitivityInspectionTemplateId() => this.SensitivityInspectionTemplateId != null;
    }
}
