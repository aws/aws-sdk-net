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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStarterMappingTemplate operation.
    /// Amazon Web Services B2B Data Interchange uses a mapping template in JSONata or XSLT
    /// format to transform a customer input file into a JSON or XML file that can be converted
    /// to EDI.
    /// 
    ///  
    /// <para>
    /// If you provide a sample EDI file with the same structure as the EDI files that you
    /// wish to generate, then the service can generate a mapping template. The starter template
    /// contains placeholder values which you can replace with JSONata or XSLT expressions
    /// to take data from your input file and insert it into the JSON or XML file that is
    /// used to generate the EDI.
    /// </para>
    ///  
    /// <para>
    /// If you do not provide a sample EDI file, then the service can generate a mapping template
    /// based on the EDI settings in the <c>templateDetails</c> parameter. 
    /// </para>
    ///  
    /// <para>
    ///  Currently, we only support generating a template that can generate the input to produce
    /// an Outbound X12 EDI file.
    /// </para>
    /// </summary>
    public partial class CreateStarterMappingTemplateRequest : AmazonB2biRequest
    {
        private MappingType _mappingType;
        private S3Location _outputSampleLocation;
        private TemplateDetails _templateDetails;

        /// <summary>
        /// Gets and sets the property MappingType. 
        /// <para>
        /// Specify the format for the mapping template: either JSONATA or XSLT.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MappingType MappingType
        {
            get { return this._mappingType; }
            set { this._mappingType = value; }
        }

        // Check to see if MappingType property is set
        internal bool IsSetMappingType()
        {
            return this._mappingType != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSampleLocation. 
        /// <para>
        /// Specify the location of the sample EDI file that is used to generate the mapping template.
        /// </para>
        /// </summary>
        public S3Location OutputSampleLocation
        {
            get { return this._outputSampleLocation; }
            set { this._outputSampleLocation = value; }
        }

        // Check to see if OutputSampleLocation property is set
        internal bool IsSetOutputSampleLocation()
        {
            return this._outputSampleLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateDetails. 
        /// <para>
        ///  Describes the details needed for generating the template. Specify the X12 transaction
        /// set and version for which the template is used: currently, we only support X12. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TemplateDetails TemplateDetails
        {
            get { return this._templateDetails; }
            set { this._templateDetails = value; }
        }

        // Check to see if TemplateDetails property is set
        internal bool IsSetTemplateDetails()
        {
            return this._templateDetails != null;
        }

    }
}